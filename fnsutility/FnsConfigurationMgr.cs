#region File Header
/**************************************************************************
 * First Notice Systems
 * 529 Main Street
 * Boston, MA 02129
 * (617) 886 2600
 *
 * Proprietary Source Code -- Distribution restricted
 *
 * Copyright (c) 2006 by First Notice Systems 
 **************************************************************************/
/* $Header: /SourceCode/Components/FNS2005/FnsUtility/FnsConfigurationMgr.cs 5     12/01/09 6:03p John.gwynn $ */
#endregion

using System;
using System.Collections;
using System.Collections.Specialized;
using System.Xml;
using DbLib=DbClassLibrary;

namespace FnsUtility
{
	/// <summary>
	///  FnsConfigurationMgr provides targeted configuration options.
	/// N.B. OBSOLETE Please do not use this class for production code
	/// </summary>
	public sealed class FnsConfigurationMgr  : IDisposable
	{
		private readonly ArrayList _registryDns;
		private NameValueCollection _appSettings;
		private readonly string _configFilename;
		#region Constructor
		/// <summary>
		/// Initializes a new instance of the <see cref="FnsConfigurationMgr"/> class.
		/// </summary>
		public FnsConfigurationMgr() :this (string.Empty)
		{}
		/// <summary>
		/// Initializes a new instance of the <see cref="FnsConfigurationMgr"/> class.
		/// </summary>
		/// <param name="configFile">The config file.</param>
		public FnsConfigurationMgr(string configFile)
		{
			try
			{
				_registryDns = new ArrayList(10);
			  if (configFile.Length <= 0) return;
			  var addFnsBinDirPRefix = (configFile.Length == 0) || (configFile.Length > 0 && configFile.IndexOf("\\", StringComparison.Ordinal) == -1);
			  if (addFnsBinDirPRefix)
			  {
			    var binDir = GeneralUtility.GetFnsRegistryKeyString("", "FNSBinDir");
			    _configFilename = binDir.Length > 0 ? String.Format("{0}{1}", binDir, configFile) : configFile;
			  }
			  else
			  {
			    _configFilename = configFile;
			  }
			  _appSettings = null;
			}
			catch(Exception ex)
			{
				ErrorLog.LogWarning(ex.Message, ToString());
			}
		}
		#endregion
		#region AppSettings
		/// <summary>
		/// Gets the app settings.
		/// </summary>
		/// <value>The app settings.</value>
		public NameValueCollection AppSettings
		{
			get
			{
				if(_appSettings == null)
				{
					lock (this)
					{
						if (_appSettings == null)
							ReadAndBuildAppSettings();
					}
				}
				return _appSettings;
			}
		}
		#endregion
		/// <summary>
		/// Performs application-defined tasks associated with freeing, releasing, or
		/// resetting unmanaged resources.
		/// </summary>
		public void Dispose()
		{
			while(_registryDns.Count > 0)
			{
				PopDns();
			}
		}
		/// <summary>
		/// Pushes the DNS.  N.B. Do not use this in production environments. 
		/// </summary>
		/// <param name="instance">The instance.</param>
		public void PushDns(string instance)
		{
      var dsn = DbLib.OdbcDsn.CreateFromEncypted(GeneralUtility.GetFnsRegistryKeyString("", "ConnectString"));
      _registryDns.Add(dsn.Server);
		  GeneralUtility.SetFnsRegistryKeyString("ConnectString", GeneralUtility.GetDsnFromInstance(instance));
		}
		/// <summary>
		/// Pops the DNS. For Development use only.  Do NOT USE in production Code!!!
		/// </summary>
		public void PopDns()
		{
      var dsn = DbLib.OdbcDsn.CreateFromEncypted(GeneralUtility.GetFnsRegistryKeyString("", "ConnectString"));
			var current = _registryDns.Count;
			if (current <= 0) return;
			var popInstance = (string) _registryDns[current - 1];	// BUGBUG Genrics (type safety)
			_registryDns.RemoveAt(current-1);

      if (popInstance.Length > 0 && popInstance != dsn.Server)
        GeneralUtility.SetFnsRegistryKeyString("ConnectString", GeneralUtility.GetDsnFromInstance(popInstance));
		}
		/// <summary>
		/// Reads the and build app settings. OBSOLETE Please do not use this class for production code
		/// </summary>
		private void ReadAndBuildAppSettings()
		{
			try
			{
				// never return null just empty
				if(_appSettings == null)
				{
					_appSettings = new NameValueCollection();
				}
				if (_configFilename.Length > 0)
				{
					var configDoc = new XmlDocument();
					{
						configDoc.Load(_configFilename);
						var root = configDoc.DocumentElement;
						if (root != null && String.Compare(root.Name, "configuration", StringComparison.OrdinalIgnoreCase) == 0)
						{
							XmlNode appSettings = GetAppSettings(root);
							if (appSettings != null)
							{
								foreach (XmlNode node in appSettings)
								{
									if (String.Compare(node.Name, "add", StringComparison.OrdinalIgnoreCase) == 0)
									{
										_appSettings.Add(GetKeyName(node), GetKeyValue(node));
									}
								}
							}
						}
					}
				}
			}
			catch(Exception ex)
			{
				ErrorLog.LogError("GetHtmlTransform() ERROR: " + ex.Message, ToString());
			}
		}
		/// <summary>
		/// Gets the app settings.
		/// </summary>
		/// <param name="root">The root.</param>
		/// <returns></returns>
		private static XmlElement GetAppSettings(XmlNode root)
		{
			XmlElement results = null;
			
			if(root != null)
			{
				foreach (XmlElement current in root)
				{
					if (String.Compare(current.Name, "appSettings", StringComparison.OrdinalIgnoreCase) != 0) continue;
					results = current;
					break;
				}
			}
			return results;
		}
		/// <summary>
		/// Gets the name of the key.
		/// </summary>
		private static string GetKeyName (XmlNode node)
		{
			return GetAttributeValue("key", node);
		}
		/// <summary>
		/// Gets the key value.
		/// </summary>
		private static string GetKeyValue (XmlNode node)
		{
			return GetAttributeValue("value", node);
		}
		/// <summary>
		/// Gets the attribute value.
		/// </summary>
		/// <param name="name">The attribute name.</param>
		/// <param name="node">The node whose attribute collection we are interested in.</param>
		/// <returns></returns>
		private static string GetAttributeValue (string name, XmlNode node)
		{
			var results = String.Empty;
			// iterate the children and get the skinny
			var attrColl = node.Attributes;
			if(null != attrColl)
			{
				foreach (XmlAttribute attrib in attrColl)
				{
					if (String.Compare(attrib.Name, name, StringComparison.OrdinalIgnoreCase) != 0) continue;
					results = attrib.Value;
					break;
				}
			}
			return results;
		}
	}
}
#region History
/*
 * $History: FnsConfigurationMgr.cs $
 * 
 * *****************  Version 5  *****************
 * User: John.gwynn   Date: 12/01/09   Time: 6:03p
 * Updated in $/SourceCode/Components/FNS2005/FnsUtility
 * All attemtps to read or write the ConnectString registry value will
 * encrypt/decrypt the PWD= parameter if it is encrypted.
 * 
 * *****************  Version 4  *****************
 * User: John.gwynn   Date: 9/28/09    Time: 4:03p
 * Updated in $/SourceCode/Components/FNS2005/FnsUtility
 * 
 * *****************  Version 3  *****************
 * User: John.gwynn   Date: 5/02/08    Time: 10:34a
 * Updated in $/SourceCode/Components/FNS2005/FnsUtility
 * fixed bug in lock
 * 
 * *****************  Version 2  *****************
 * User: John.gwynn   Date: 4/28/08    Time: 11:23a
 * Updated in $/SourceCode/Components/FNS2005/FnsUtility
 * fixed bug in FnsConfigurationMgr constructor where defaults are not
 * causing problems i.e. no registry or config file definition
 * 
 * *****************  Version 1  *****************
 * User: John.gwynn   Date: 1/18/07    Time: 2:38p
 * Created in $/SourceCode/Components/VS.NET2005/FnsUtility
 * Framework 2.0 upgrade
 * 
 * *****************  Version 2  *****************
 * User: John.gwynn   Date: 11/30/06   Time: 3:17p
 * Updated in $/SourceCode/Components/VS.NET/FNSUtility
 * Added support for custom Appsettings configurations
 */
#endregion
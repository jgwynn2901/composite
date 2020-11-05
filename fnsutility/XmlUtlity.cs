#region File Header
/**************************************************************************
 * First Notice Systems
 * 529 Main Street
 * Boston, MA 02129
 * (617) 886 2600
 *
 * Proprietary Source Code -- Distribution restricted
 *
 * Copyright (c) 1993-2005 by First Notice Systems
 **************************************************************************/
/* $Header: /SourceCode/Components/FNS2005/FnsUtility/XmlUtlity.cs 31    6/20/11 7:20p Gwynnj $ */
#endregion

#region References

using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Web.Services.Protocols;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.Xsl;
using ADODB;
using DbClassLibrary;
using Microsoft.Practices.EnterpriseLibrary.Security.Cryptography;

#endregion

namespace FnsUtility
{
  /// <summary>
  /// Summary description for XmlUtility.
  /// </summary>
  public static class XmlUtility
  {
    private const string ServiceName = "XmlUtility";
    private const string SymmProvider = "CallDataKey"; // BUGBUG:SCOPE need to add this as parm

    #region LoadFileText
    /// <summary>
    /// LoadFileText returns the contents of the specified filespec as string
    /// </summary>
    /// <param name="file">file to read</param>
    /// <returns>contents of file as string</returns>
    static public string LoadFileText(string file)
    {
      return TextFileReader.ReadFile(file);
    }
    #endregion
    /// <summary>
    /// Gets the data dir.
    /// </summary>
    /// <returns></returns>
    static public string GetDataDir()
    {
      return ApplicationConfiguration.Instance.DataDir;
    }
    /// <summary>
    /// Saves the file text.
    /// </summary>
    /// <param name="filename">The filename.</param>
    /// <param name="text">The text.</param>
    static public void SaveFileText(string filename, string text)
    {
      StreamWriter writer = null;
      try
      {
        using (writer = new StreamWriter(filename))
        {
          writer.WriteLine(text);
          writer.Flush();
          writer.Close();
        }
      }
      catch (Exception ex)
      {
        ErrorLog.LogError(string.Format("SaveFileText({0}): Error: {1} ", filename, ex.Message), ServiceName);
      }
      finally
      {
        if (writer != null)
        {
          writer.Close();
        }
      }
    }

    #region GetStringXslTransform
    /// <summary>
    /// GetHtmlTransform
    /// </summary>
    /// <param name="xmlFileName">Name of the XML file.</param>
    /// <param name="xslFileName">Name of the XSL file.</param>
    /// <returns></returns>
    static public string GetStringXslTransform(string xmlFileName, string xslFileName)
    {
      var results = String.Empty;
      try
      {
        if (xmlFileName.Length > 0 && xslFileName.Length > 0)
        {
          {
            //Enabledocumentfunction, enablescript
            var settings = new XsltSettings(true, true);
            var xslt = new XslCompiledTransform();
            xslt.Load(xslFileName, settings, new XmlUrlResolver());
            var sw = new StringWriter();
            XmlWriter xmlWriter = new XmlTextWriter(sw);

            try
            {
              xslt.Transform(xmlFileName, xmlWriter);
            }
            catch (Exception ex)
            {
              ErrorLog.LogWarning("XslTransform() Warning: " + ex.Message, ServiceName);
            }
            sw.Close();
            results = sw.GetStringBuilder().ToString();
          }
        }
      }
      catch (Exception ex)
      {
        ErrorLog.LogError("GetHtmlTransform() ERROR: " + ex.Message, ServiceName);
      }
      return results;
    }
    #endregion

    #region GetXmlObjectAsString

    /// <summary>
    /// Gets the XML object as string overloaded with namespace.
    /// </summary>
    static public string GetXmlObjectAsString(Object policy, string xmlNnamespace)
    {
      var results = String.Empty;

      try
      {
        if (null != policy)
        {
          // Create a stream buffer that can be read as a string
          using (var sw = new StringWriter())
          {
            var settings = new XmlWriterSettings { Indent = true, OmitXmlDeclaration = true, Encoding = Encoding.UTF8 };

            // Create a specialized writer for XML code
            using (var xtw = XmlWriter.Create(sw, settings))
            {
              var serializer = xmlNnamespace.Length > 0 ?
                new XmlSerializer(policy.GetType(), xmlNnamespace) :
                new XmlSerializer(policy.GetType());

              serializer.Serialize(xtw, policy);
              results = sw.ToString();
            }
          }
        }
      }
      catch (Exception ex)
      {
        ErrorLog.LogError("GetXmlObjectAsString() ERROR: " + ex.Message, ServiceName);
      }
      return results;
    }

    /// <summary>
    /// Gets the XML object as string.
    /// </summary>		
    static public string GetXmlObjectAsString(Object policy)
    {
      return GetXmlObjectAsString(policy, "");
    }
    #endregion

    #region FormatSoapExceptionMessage
    /// <summary>
    /// this code kept popping up in each web service so I refactored it here
    /// Basically just provide a standard format for Soap Exception reporting
    /// </summary>
    /// <param name="ex">The exception.</param>
    /// <param name="serviceName">Name of the service.</param>
    /// <returns></returns>
    static public string FormatSoapExceptionMessage(SoapException ex, string serviceName)
    {
      var results = String.Empty;

      try
      {
        if (null != ex)
        {
          var errorMessage = new StringBuilder();
          if (serviceName.Length > 0)
            errorMessage.Append(ServiceName);
          errorMessage.Append(".ExecuteLookup() ");
          errorMessage.Append(" Code: ");
          errorMessage.Append(ex.Code);
          errorMessage.Append(" Actor: ");
          errorMessage.Append(ex.Actor);
          errorMessage.Append(" Message: ");
          errorMessage.Append(ex.Message.Substring(0, Math.Min(ex.Message.Length, 200)));

          results = errorMessage.ToString();
        }
      }
      catch (Exception internalException)
      {
        ErrorLog.LogError("FormatSoapExceptionMessage() ERROR: " + internalException.Message, serviceName);
      }
      return results;
    }
    #endregion

    #region FormatCallDateToSoap
    /// <summary>
    /// Formats the call date to SOAP.
    /// </summary>
    /// <param name="date">The date.</param>
    /// <returns></returns>
    static public string FormatCallDateToSoap(string date)
    {
      var results = new StringBuilder(10);

      try
      {
        if (date.Length > 0)
        {
          date = date.Trim();

          if (date.Length == 8) // assume MMDDYYYY
          {
            results.Append(date.Substring(4));
            results.Append("-");
            results.Append(date.Substring(0, 2));
            results.Append("-");
            results.Append(date.Substring(2, 2));
          }
        }
      }
      catch (Exception internalException)
      {
        ErrorLog.LogError("FormatDate() ERROR: " + internalException.Message, ServiceName);
      }
      return results.ToString();
    }
    #endregion

    #region FormatSoapDateToCall
    /// <summary>
    /// Formats the SOAP date to call. [Obsolete]
    /// </summary>
    static public string FormatSoapDateToCall(string date)
    {
      var results = new StringBuilder(10);

      try
      {
        date = date.Trim();

        if (date.Length == 10) // assume YYYY-MM-DD
        {
          results.Append(date.Substring(5, 2));
          results.Append(date.Substring(8, 2));
          results.Append(date.Substring(0, 4));
        }
      }
      catch (Exception internalException)
      {
        ErrorLog.LogError("FormatDate() ERROR: " + internalException.Message, ServiceName);
      }
      return results.ToString();
    }
    #endregion

    #region DumpResponseBody
    /// <summary>
    /// dump reqest and (mostly) response received from a web service to
    /// the Data Directory with RQUID as filename and .xml as extension
    /// </summary>
    /// <param name="xml">The XML.</param>
    /// <param name="prefix">The prefix.</param>
    /// <param name="rqId">The request id.</param>
    static public void DumpResponseBody(string xml, string prefix, string rqId)
    {
      try
      {
        var outputDirectory = GetDataDir();
        using (var writer = new StreamWriter(outputDirectory + prefix + rqId + ".xml"))
        {
          writer.WriteLine(xml);
          writer.Flush();
          writer.Close();
        }
      }
      catch (Exception ex)
      {
        ErrorLog.LogError("DumpResponseBody(): Error on file = " + rqId + ex.Message, ServiceName);
      }
    }
    #endregion

    #region LogResponseBody
    /// <summary>
    /// Logs the response body.
    /// </summary>
    /// <param name="xml">The XML.</param>
    /// <param name="prefix">The prefix.</param>
    /// <param name="rqId">The rq id.</param>
    /// dms: in order to log into the correct dsn passed from the calling class, the old signature will call the fn. with new signature.
    static public void LogResponseBody(string xml, string prefix, string rqId)
    {
      LogResponseBody(xml, prefix, rqId, DbClassLibrary.ApplicationConfiguration.Instance.DefaultInstance);
    }
    /// <summary>
    /// Logs the response body.
    /// </summary>
    /// <param name="xml">The XML.</param>
    /// <param name="prefix">The prefix.</param>
    /// <param name="rqId">The rq id.</param>
    /// <param name="instance">The instance.</param>
    static public void LogResponseBody(string xml, string prefix, string rqId, string instance)
    {
      Log2ClaimSubmissionLog(new ClaimSubmissionLogger.LoggerPackage
      {
        Document = xml,
        Prefix = prefix.Equals("REQUEST", StringComparison.InvariantCultureIgnoreCase)
            ? ClaimSubmissionLogger.LogType.Request
            : ClaimSubmissionLogger.LogType.Response,
        Instance = instance,
        RquId = rqId,
        TimeStamp = DateTime.Now
      });
    }

    static internal void Log2ClaimSubmissionLog(ClaimSubmissionLogger.LoggerPackage package)
    {
      if (string.IsNullOrEmpty(package.RquId))
      {
        ErrorLog.LogWarning("LogResponseBody must have valid rquid", ServiceName);
        return;
      }

      var claimLog = new ClaimSubmissionLog
      {
        RquId = package.RquId,
        Instance = package.Instance,
        TimeStamp = package.TimeStamp.ToString(DatabaseInstance.DatabaseDateFormat)
      };
      var results = package.Prefix == ClaimSubmissionLogger.LogType.Request
          ? claimLog.SetRequest(package.Document)
          : claimLog.SetResponse(package.Document);

      ErrorLog.DebugLog(String.Format("claimLog.SetResponse returned {0}", results), ServiceName);

    }
    #endregion

    #region HasResponseBody
    /// <summary>
    /// Determines whether [has response body] [the specified rq id].
    /// </summary>
    /// <param name="rqId">The rq id.</param>
    /// <returns></returns>
    static public string HasResponseBody(string rqId)
    {
      return HasResponseBody(rqId, DbClassLibrary.ApplicationConfiguration.Instance.DefaultInstance);
    }


    /// <summary>
    /// Determines whether [has response body] [the specified rq id].
    /// </summary>
    /// <param name="rqId">The rq id.</param>
    /// <param name="instance">The database instance.</param>
    /// <returns></returns>
    static public string HasResponseBody(string rqId, string instance)
    {
      var results = string.Empty;
      if (rqId.Length == 0)
      {
        ErrorLog.LogWarning("HasResponseBody must have valid rquid", ServiceName);
        return results;
      }
      var claimLog = new ClaimSubmissionLog { RquId = rqId, Instance = instance };
      results = claimLog.GetResponse();

      ErrorLog.DebugLog(
        results.Length > 0
          ? "claimLog.HasResponseBody returned results"
          : "claimLog.HasResponseBody returned no results", ServiceName);

      return results;
    }
    #endregion

    #region ResetClaimResponse
    /// <summary>
    /// Resets the claim response.
    /// </summary>
    /// <param name="rqId">The request id.</param>
    /// <returns></returns>
    static public bool ResetClaimResponse(string rqId)
    {
      return ResetClaimResponse(rqId, DbClassLibrary.ApplicationConfiguration.Instance.DefaultInstance);
    }

    /// <summary>
    /// Resets the claim response.
    /// </summary>
    /// <param name="rqId">The request id.</param>
    /// <param name="instance">The database instance.</param>
    /// <returns></returns>
    static public bool ResetClaimResponse(string rqId, string instance)
    {
      if (rqId.Length == 0)
      {
        ErrorLog.LogWarning("ResetClaimResponse must have valid rquid", ServiceName);
        return false;
      }
      var claimLog = new ClaimSubmissionLog { RquId = rqId, Instance = instance };
      return claimLog.ResetResponse();
    }
    #endregion

    #region GetXmlFromAdoRecordset
    /// <summary>
    /// Another pattern that is refactored here
    /// Given ADODB.Recordset return a string of its xml
    /// </summary>
    /// <param name="record">The record.</param>
    /// <returns></returns>
    [CLSCompliantAttribute(false)]
    static public string GetXmlFromAdoRecordset(_Recordset record)
    {
      var results = String.Empty;
      _Stream stream = null;
      try
      {
        if (null != record)
        {
          stream = new ADODB.Stream();
          record.Save(stream, PersistFormatEnum.adPersistXML);
          results = stream.ReadText(-1);
        }
      }
      catch (Exception ex)
      {
        ErrorLog.LogError("GetXmlFromAdoRecordset(): Error " + ex.Message, ServiceName);
      }
      finally
      {
        if (stream != null)
          Marshal.ReleaseComObject(stream);
      }

      return results;
    }
    #endregion

    [CLSCompliant(false)]
    static public _Recordset GetRecordsetFromXml(string xml)
    {
      _Stream stream = null;
      try
      {
        stream = new ADODB.Stream();
        stream.Open(Missing.Value, ConnectModeEnum.adModeUnknown, StreamOpenOptionsEnum.adOpenStreamUnspecified, "", "");
        stream.WriteText(xml, StreamWriteEnum.adWriteChar);
        stream.Position = 0;

        var recordset = new Recordset();
        recordset.Open(stream, Missing.Value, CursorTypeEnum.adOpenUnspecified, LockTypeEnum.adLockUnspecified, 0);
        return recordset;

      }
      catch (Exception ex)
      {
        ErrorLog.LogError(ex, new CallingMethod());
        return default(_Recordset);
      }
      finally
      {
        if (stream != null)
          Marshal.ReleaseComObject(stream);
      }
    }

    /// <summary>
    /// Creates an empty AdoRecordset
    /// </summary>
    [CLSCompliant(false)]
    public static Recordset CreateRecordSet(string[] fields)
    {
      const int maxFieldSize = 2048;
      var record = new Recordset
       {
         CursorLocation = CursorLocationEnum.adUseClient
       };

      // Add fields
      foreach (var t in fields)
        record.Fields._Append(t, DataTypeEnum.adVarChar, maxFieldSize, FieldAttributeEnum.adFldIsNullable);

      // open recordset
      record.Open(Missing.Value, Missing.Value, CursorTypeEnum.adOpenUnspecified, LockTypeEnum.adLockUnspecified, 0);
      return record;
    }

    /// <summary>
    /// Creates the empty recordset with enclosed field defintions.
    /// </summary>
    public static string CreateEmptyRecordsetXml(string[] fields)
    {
      return GetXmlFromAdoRecordset(CreateRecordSet(fields));
    }

    /// <summary>
    /// Constructs an AdooRecordset from the given results
    /// </summary>
    [CLSCompliant(false)]
    public static Recordset PrepareAdoRecordset(string[] fieldNames, IEnumerable<List<Dictionary<string, string>>> values)
    {
      try
      {
        var results = CreateRecordSet(fieldNames);

        foreach (var record in values)  // for each record
        {
          results.AddNew(Missing.Value, Missing.Value);

          foreach (var field in record) //for each field
          {
            foreach (var name in fieldNames)
            {
              results.Fields[name].Value = field[name];
            }
          }
        }
        if (results.RecordCount > 0)
          results.MoveFirst();

        return results;
      }
      catch (Exception ex)
      {
        ErrorLog.LogError("PrepareAdoRecordset(): " + ex.Message, new CallingMethod());
      }
      return CreateRecordSet(fieldNames);
    }

    #region EncryptXmlFields
    /// <summary>
    /// Encrypts the XML fields.
    /// </summary>
    /// <param name="doc">The doc.</param>
    /// <param name="ahsId">The ahs id.</param>
    /// <param name="lobCd">The lob cd.</param>
    /// <param name="type">The type.</param>
    /// <param name="decrypt">if set to <c>true</c> [decrypt].</param>
    /// <returns></returns>
    static public string EncryptXmlFields(string doc, string ahsId, string lobCd, string type, bool decrypt)
    {
      var results = doc;
      try
      {
        var encryptDoc = new XmlDocument();
        encryptDoc.LoadXml(doc);
        var root = encryptDoc.DocumentElement;
        if (null != root)
        {
          var encyptAttributes = new EncryptAttributeSet { AhsId = ahsId, LobCd = lobCd, EncryptType = type };
          Assert.Test(encyptAttributes.Execute(), encyptAttributes.LastError);

          foreach (DataRow encryptRow in encyptAttributes)
          {
            var attributeName = encryptRow[(int)EncryptAttributeSet.ResultList.AttributeName].ToString();
            var nodes = encryptDoc.SelectNodes(attributeName);

            if (null == nodes) continue;
            foreach (XmlNode node in nodes)
            {
              if (string.IsNullOrEmpty(node.InnerText)) continue;
              node.InnerText = decrypt ? Cryptographer.DecryptSymmetric(SymmProvider, node.InnerText) : Cryptographer.EncryptSymmetric(SymmProvider, node.InnerText);
            }
          }
          results = encryptDoc.OuterXml;
        }
      }
      catch (Exception ex)
      {
        ErrorLog.LogError("EncryptXmlFields(): " + ex.Message, ServiceName);
      }
      return results;
    }
    #endregion
    /// <summary>
    /// Extracts the node value.
    /// </summary>
    static public string ExtractNodeValue(XmlNode doc, string nodeName)
    {
      if (doc != null && !string.IsNullOrEmpty(nodeName))
      {
        var current = doc.SelectSingleNode(nodeName) ?? doc.SelectSingleNode(string.Format("//*[local-name()='{0}']", nodeName));
        if (current != null)
          return current.InnerXml;
      }
      return "";
    }

    /// <summary>
    /// retrieves the Nodes InnerText value from document as string.
    /// </summary>
    /// <param name="document">The document.</param>
    /// <param name="value">The value.</param>
    /// <returns></returns>
    static public string NodeValueFromString(string document, string value)
    {
      var doc = new XmlDocument();
      doc.LoadXml(document);
      return ExtractNodeValue(doc.DocumentElement, value);
    }
    /// <summary>
    /// Formats the date. (moved from EsuranceWebConnect BUGBUG: may need to articulate)
    /// </summary>
    /// <param name="lossdate">The lossdate.</param>
    /// <param name="dateFormat">The date format.</param>
    /// <returns></returns>
    static public string FormatCallDate(string lossdate, string dateFormat)
    {
      var formattedDate = string.Empty;

      if (lossdate.Length > 0 && dateFormat.Length > 0)
      {
        try
        {
          if (dateFormat.Equals("DateTimeZone", StringComparison.InvariantCultureIgnoreCase))
          {
            var lossdt = XmlConvert.ToDateTime(lossdate, XmlDateTimeSerializationMode.Unspecified);
            var lossdtlongformat = lossdt.ToString("o");
            var lossdatetimezone = lossdtlongformat + lossdt.ToString("zzzz");
            formattedDate = lossdatetimezone;
          }
          else if (dateFormat.Equals("DateTime", StringComparison.InvariantCultureIgnoreCase))
          {
            var lossdt = XmlConvert.ToDateTime(lossdate, XmlDateTimeSerializationMode.Unspecified);
            var lossdtlongformat = lossdt.ToString("s");
            //lossdatetimezone = lossdtlongformat + lossdt.ToString("zzzz");
            formattedDate = lossdtlongformat;
          }
          else if (dateFormat.Equals("Date", StringComparison.InvariantCultureIgnoreCase))
          {
            formattedDate = string.Format("{0}/{1}/{2}",
                                          lossdate.Substring(5, 2),
                                          lossdate.Substring(8, 2),
                                          lossdate.Substring(0, 4));
          }
        }
        catch (Exception ex)
        {
          ErrorLog.LogError("FormatDate: " + ex.Message, new CallingMethod());
        }
      }
      return formattedDate;
      //return "2007-04-01T13:00:00.0000000-07:00";
    }

    /// <summary>
    /// Converts the String to UTF8 Byte array and is used in De serialization
    /// </summary>
    /// <param name="pXmlString"></param>
    /// <returns></returns>
    // ReSharper disable InconsistentNaming
    public static Byte[] StringToUTF8ByteArray(string pXmlString)
    // ReSharper restore InconsistentNaming
    {
      var encoding = new UTF8Encoding();
      var byteArray = encoding.GetBytes(pXmlString);
      return byteArray;
    }
    /// <summary>
    /// Serialize an object into an XML string
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="obj"></param>
    /// <returns></returns>
    public static string SerializeObject<T>(T obj)
    {
      try
      {
        var memoryStream = new StringWriter();
        var xs = new XmlSerializer(typeof(T));
        var settings = new XmlWriterSettings
                           {
                             OmitXmlDeclaration = true,
                             CloseOutput = true,
                             ConformanceLevel = ConformanceLevel.Document,
                             Encoding = Encoding.ASCII
                           };
        using (var xmlTextWriter = XmlWriter.Create(memoryStream, settings))
        {
          xs.Serialize(xmlTextWriter, obj);
        }
        return memoryStream.ToString();
      }
      catch (Exception ex)
      {
        ErrorLog.LogError(ex.Message, new CallingMethod());
        return string.Empty;
      }
    }

    /// <summary>
    /// Reconstruct an object from an XML string
    /// </summary>
    /// <param name="xml"></param>
    /// <returns></returns>
    public static T DeserializeObject<T>(string xml)
    {
      return DeserializeObject<T>(xml, string.Empty);
    }

    /// <summary>
    /// Deserializes the object.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="xml">The XML.</param>
    /// <param name="defaultNamespace">The default namespace.</param>
    /// <returns></returns>
    public static T DeserializeObject<T>(string xml, string defaultNamespace)
    {
      try
      {
        var xs = string.IsNullOrEmpty(defaultNamespace) ?
            new XmlSerializer(typeof(T)) :
            new XmlSerializer(typeof(T), defaultNamespace);

        var memoryStream = new MemoryStream(StringToUTF8ByteArray(xml));
        var reader = XmlReader.Create(memoryStream);
        return (T)xs.Deserialize(reader);
      }
      catch (Exception ex)
      {
        ErrorLog.LogError(ex.InnerException != null ? ex.InnerException.Message : ex.Message, new CallingMethod());
        return default(T);
      }
    }

    /// <summary>
    /// Serializes the data contract.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="work">The work.</param>
    /// <returns></returns>
    public static string SerializeDataContract<T>(T work)
    {
      using (var writer = new MemoryStream())
      {
        var serializer = new DataContractSerializer(typeof(T));
        serializer.WriteObject(writer, work);
        writer.Flush();
        return new ASCIIEncoding().GetString(writer.GetBuffer());
      }
    }

    public static string SerializeJsonDataContract<T>(T work)
    {
      using (var writer = new MemoryStream())
      {
        var serializer = new DataContractJsonSerializer(typeof(T));
        serializer.WriteObject(writer, work);
        writer.Flush();
        var json = writer.ToArray();
        return Encoding.UTF8.GetString(json, 0, json.Length);
      }
    }

    /// <summary>
    /// Deserializes the data contract.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="work">The work.</param>
    /// <returns></returns>
    public static T DeserializeDataContract<T>(string work)
    {
      return DeserializeDataContract<T>(work, string.Empty, string.Empty);
    }

    public static T DeserializeDataContract<T>(string work, string root, string defaultNamespace)
    {
      using (var stream = new MemoryStream(new UTF8Encoding().GetBytes(work)))
      {
        var reader = XmlDictionaryReader.CreateTextReader(stream, new XmlDictionaryReaderQuotas());
        var serialize = string.IsNullOrEmpty(defaultNamespace) ?
           new DataContractSerializer(typeof(T)) :
           new DataContractSerializer(typeof(T), root, defaultNamespace);

        // Deserialize the data and read it from the instance.
        return (T)serialize.ReadObject(reader, string.IsNullOrEmpty(defaultNamespace));
      }
    }

    public static T DeserializeJsonDataContract<T>(string work)
    {
      using (var stream = new MemoryStream(Encoding.UTF8.GetBytes(work)))
      {
        var serialize = new DataContractJsonSerializer(typeof(T));
        return (T)serialize.ReadObject(stream);
      }
    }
  }
}
#region Log
/*
 * $Log: /SourceCode/Components/FNS2005/FnsUtility/XmlUtlity.cs $
 * 
 * 31    6/20/11 7:20p Gwynnj
 * Modifications to ClaimSubmissionLog to accomodate asynchronous calls
 * with the addition of new timestamps to mark the actual point at witch
 * the request is made.  N.B. this requires a new version of
 * DbClassLibrary to be installed.
 * 
 * 30    12/22/10 1:56p Gwynnj
 * 
 * 29    11/03/10 11:12a Gwynnj
 * 
 * 28    10/19/10 7:03p Gwynnj
 * Added namespace to the data contract serializer
 * 
 * 27    10/13/10 10:24a Gwynnj
 * Added SerializeJsonDataContract<T> and DeserializeJsonDataContract<T>
 * for obvious reasons.
 * 
 * 26    9/29/10 5:30p Gwynnj
 * Added XmlUtility.GetRecordsetFromXml complemet to the serialize method
 * for testing
 * 
 * 25    8/17/10 1:06p Gwynnj
 * Moved all ClaimSubmissionLog functionality to ClaimSubmissionLogger and
 * added Asych logging using ThreadPool
 * 
 * 24    8/03/10 6:59p Gwynnj
 * Added Generic Execute delegate to encapsulate loggingTODO need to
 * uncouple logging as a function of this service wrapper.
 * 
 * 23    6/09/10 8:04p Gwynnj
 * Added (refactored from OutputProcessManager) generic DataContract
 * serialization support
 * 
 * 22    5/26/10 11:56a Gwynnj
 * expanded max field length for ado record fields to 2K
 * 
 * 21    5/11/10 2:11p Gwynnj
 * Warnings removed comments and CLSCompliance updates
 * 
 * 20    5/06/10 12:01p Gwynnj
 * Added CreateRecordSet for WebLookup support
 * 
 * 19    5/04/10 5:36p Gwynnj
 * extended GetSettingFromDatabase to use machine name which is of higher
 * precedence than app name
 * 
 * 18    2/01/10 2:31p Gwynnj
 * prefer using ... to try finally...
 * 
 * 17    1/06/10 4:40p Gwynnj
 * modified XmlUtility.ExtractNodeValue to allow for unique names and
 * ignore namespaces.  Also created NodeValueFromString to help extract
 * info from xml fragments etc. using the above.
 * 
 * 16    1/06/10 10:23a Gwynnj
 * Fixed file logging when UseAsynchLogging =false
 * 
 * 15    1/05/10 6:55p John.gwynn
 * replaced memory stream with stringWrite to remove garbage when
 * serializing from encoding inconsistencies.
 * 
 * 14    1/04/10 3:19p John.gwynn
 * Added Instance versions of the ClaimSubmissionLog as the default
 * instance can be different from the call instance and this is an error
 * 
 * 13    11/18/09 7:53p John.gwynn
 * Added Date.FormatCallDateString
 * 
 * 12    10/12/09 12:43p John.gwynn
 * Added ApplicationConfiguration singleton for general Fns Registry
 * settings
 * 
 * 11    3/04/09 7:09p John.gwynn
 * fixed a settings bug
 * 
 * 10    3/04/09 6:15p John.gwynn
 * forgot to return the results
 * 
 * 9     3/04/09 3:43p John.gwynn
 * added namespace override for XmlUtility.GetXmlObjectAsString
 * 
 * 8     2/06/08 7:34p John.gwynn
 * Added Serialize utilities and aability to handle multi-level namespaces
 * in the GeneralUtility.ExecuteMethod
 * 
 * 7     2/04/08 6:54p John.gwynn
 * added EncryptValue/DecryptValue, XmlUtility.FormatCallDate
 * 
 * 6     1/03/08 5:07p John.gwynn
 * added ExtractNodeValues to insulate SelectSingleNode from nulls
 * 
 * 5     10/30/07 12:51p John.gwynn
 * Added GetDataDir to XmlUtility and new Eval evaluator for dynamic (c#
 * only at this time) code execution -see FnsDispatch
 * 
 * 4     10/11/07 1:37p John.gwynn
 * 
 * 3     10/09/07 12:07p Deepika.sharma
 * dms: New signature for logresponsebody which passes the db instance to
 * log into.
 * 
 * 2     5/31/07 12:04p Deepika.sharma
 * dms: Replace Transform class with CompileTransform
 * 
 * 1     1/18/07 2:38p John.gwynn
 * Framework 2.0 upgrade
 * 
 * 14    12/19/06 1:26p John.gwynn
 * NDoc comments for technical documentation see:
 * http://cha1saxc/wiki/ndocs/fnsutility/index.html
 * 
 * 13    12/04/06 1:11p John.gwynn
 * removed a reference to FNSBA for the encrypt attributes
 * 
 * 12    12/01/06 5:23p John.gwynn
 * added EncryptXmlFields general purpose encrypt/decrypt functionality
 * 
 * 11    7/09/06 3:29p John.gwynn
 * Added ClaimSubmissionLog wrappers
 * 
 * 10    6/05/06 5:56p John.gwynn
 * added strong name key
 * 
 * 9     5/08/06 6:47p John.gwynn
 * documentation and file formatting
 * 
 * 8     4/20/06 11:54a John.gwynn
 * CLI Compliance modifications
 * 
 * 7     4/10/06 4:12p John.gwynn
 * New version with namespace fixed
 * 
 * 6     4/05/06 5:44p John.gwynn
 * refactoring
 * 
 * 5     3/30/06 11:22a John.gwynn
 * general fixes and refinements
 * 
 * 4     3/06/06 5:56p John.gwynn
 * added baseWebEngine
 * 
 * 3     3/04/06 5:28p John.gwynn
 * small utility refactoring
 * 
 * 2     2/21/06 6:49p John.gwynn
 * added several refactored utilities
 */
#endregion

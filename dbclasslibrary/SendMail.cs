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
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/SendMail.cs 4     5/26/09 11:05a John.gwynn $ */

using System;
using System.Data;
using System.Runtime.InteropServices;

namespace DbClassLibrary 
{
	/// <summary>
	/// Encapsulates the Oracle SendMail stored procedure
	/// </summary>
	[ComVisible(false)]	
	public sealed class SendMail :DbBaseClass
	{
		#region Constructor
		/// <summary>
		/// Initializes a new instance of the <see cref="SendMail"/> class.
		/// </summary>
		public SendMail() :this (String.Empty)
		{
		}
		/// <summary>
		/// Initializes a new instance of the <see cref="SendMail"/> class.
		/// </summary>
		/// <param name="instance"></param>
		public SendMail(string instance) :base(instance)
		{
			_name = "send_mail";
			Initialize();
		}
		#endregion
		#region Initialize
		/// <summary>
		/// Set up parameter definitions here
		/// </summary>
		/// <remarks>
		/// the definitions can be defined externally (configuration) 
		/// and iterated here for maximum flexibility
		/// </remarks>
		protected override void Initialize()
		{
			///////////////////////////////////////////////////
			/////sender
			///////////////////////////////////////////////////
			AddParm(ParameterDirection.Input,
				"sender","",DbType.AnsiString);
			///////////////////////////////////////////////////
			/////recipient
			///////////////////////////////////////////////////
			AddParm(ParameterDirection.Input,
				"recipient","",DbType.AnsiString);
			///////////////////////////////////////////////////
			/////cc
			///////////////////////////////////////////////////
			AddParm(ParameterDirection.Input,
				"cc","",DbType.AnsiString);
			///////////////////////////////////////////////////
			/////subject
			///////////////////////////////////////////////////
			AddParm(ParameterDirection.Input,
				"subject","",DbType.AnsiString);
			///////////////////////////////////////////////////
			/////message
			///////////////////////////////////////////////////
			AddParm(ParameterDirection.Input,
				"message","",DbType.AnsiString);
		}
		#endregion
		#region sender
		/// <summary>
		/// sender property
		/// </summary>
			public string sender 
		{
			get 
			{
				return GetValue("sender");
			}
			set 
			{
				SetValue("sender",value);
			}
		}
		#endregion
		#region recipient
		/// <summary>
		/// recipient property
		/// </summary>
		public string recipient 
		{
			get 
			{
				return GetValue("recipient");
			}
			set 
			{
				SetValue("recipient",value);
			}
		}
		#endregion
		#region cc
		/// <summary>
		/// cc property
		/// </summary>
		public string cc 
		{
			get 
			{
				return GetValue("cc");
			}
			set 
			{
				SetValue("cc",value);
			}
		}
		#endregion
		#region subject
		/// <summary>
		/// subject property
		/// </summary>
		public string subject 
		{
			get 
			{
				return GetValue("subject");
			}
			set 
			{
				SetValue("subject",value);
			}
		}
		#endregion
		#region message
		/// <summary>
		/// message property
		/// </summary>
		public string message 
		{
			get 
			{
				return GetValue("message");
			}
			set 
			{
				SetValue("message",value);
			}
		}
		#endregion
	}
}
/*
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/SendMail.cs $
 * 
 * 4     5/26/09 11:05a John.gwynn
 * Added interop definitions
 * 
 * 3     4/19/07 4:36p John.gwynn
 * Added COM Interop support and begun work on Callflow data access
 * 
 * 2     4/17/07 4:52p John.gwynn
 * Update from 1.1 version
 * 
 * 4     11/09/06 11:08a John.gwynn
 * modifed DbBaseClass to accept instance as the default parm in
 * constructor and adapted all subclasses to this structure.  Added onging
 * documentation improvements.
 * 
 * 3     4/06/06 6:16p John.gwynn
 * Added NcciCode and AhsIdFromLocation
 * 
 * 2     11/16/05 6:21p John.gwynn
 * Added AHS
 * 
 * 1     11/15/05 6:41p John.gwynn
 */
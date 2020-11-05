#region Header
/**************************************************************************
* First Notice Systems
* 95 Wells Avenue
* Newton, MA 02459
* (617) 886-2600
*
* Proprietary Source Code -- Distribution restricted
*
* Copyright (c) 2008 by Innovation First Notice
 **************************************************************************/
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/FraudLanguage.cs 3     5/26/09 11:05a John.gwynn $ */
#endregion

using System;

namespace DbClassLibrary
{
	/// <summary>
	/// Encapsulates getuserid stored proc using user table.
	/// </summary>
	[System.Runtime.InteropServices.ComVisible(false)]
	public class FraudLanguage : DbBaseClass
	{
		private enum eParmList
		{
			stateCode = 0,
			fraudLanguage

		};

		#region Constructor

		/// <summary>
		/// Initializes a new instance of the <see cref="FraudLanguage"/> class.
		/// </summary>
		public FraudLanguage() : this(String.Empty) { }

		/// <summary>
		/// Initializes a new instance of the <see cref="FraudLanguage"/> class.
		/// </summary>
		/// <param name="instance"></param>
		public FraudLanguage(string instance)
			: base(instance)
		{
			_name = "DBClassLibrary.GetStateFraudLanguage";

			_parameterNames = new string[]
				{
					"p_StateCode",
					"p_Results"
				};
			Initialize();
		}
		#endregion
		#region Initialize
		/// <summary>
		/// Initializes this instance.
		/// </summary>
		protected override void Initialize()
		{

			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.stateCode], "", System.Data.DbType.AnsiString);

			AddParm(System.Data.ParameterDirection.Output,
				_parameterNames[(int)eParmList.fraudLanguage], "", System.Data.DbType.AnsiString);
		}
		#endregion
		#region Public Properties
		/// <summary>
		/// Gets or sets the state code.
		/// </summary>
		/// <value>The state code.</value>
		public string StateCode
		{
			get
			{
				return GetValue((int)eParmList.stateCode);
			}
			set
			{
				SetValue((int)eParmList.stateCode, value);
			}
		}

		/// <summary>
		/// Gets or sets the fraud text.
		/// </summary>
		/// <value>The fraud text.</value>
		public string FraudText
		{
			get
			{
				return GetValue((int)eParmList.fraudLanguage);
			}
			set
			{
				SetValue((int)eParmList.fraudLanguage, value);
			}
		}

		#endregion

		/// <summary>
		/// Gets the fraud language by state code.
		/// </summary>
		/// <param name="instance">The instance.</param>
		/// <param name="stateCode">The state code.</param>
		/// <returns></returns>
		public static string GetFraudLanguageByStateCode(string stateCode, string instance)
		{
			string results = String.Empty;
			try
			{
				FraudLanguage fraud = new FraudLanguage(instance);
				fraud.StateCode = stateCode;
				if (fraud.Execute())
				{
					results = fraud.FraudText;
				}
			}
			catch (Exception ex)
			{
				GeneralUtility.DebugLog(ex.Message, "GetFraudLanguageByStateCode");
			}
			return results;
		}
	}
}
#region Log
/*
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/FraudLanguage.cs $
 * 
 * 3     5/26/09 11:05a John.gwynn
 * Added interop definitions
 * 
 * 2     12/23/08 1:35p John.gwynn
 * parm order is now correct
 * 
 * 1     2/19/08 3:26p John.gwynn
 * Added FraudLanguage for eSurance (current in ESUBA only)
 * 
 * 1     11/07/07 9:16a Jenny.cheung
 * 
 * 5     6/19/07 10:05a Jenny.cheung
 * 
 * 4     5/21/07 4:38p Jenny.cheung
 * Updated stored procedure in dbclasslibrary
 * 
 * 3     5/18/07 2:23p Jenny.cheung
 * Incorporated stored procedure into dbclass library
 * 
 * 2     5/16/07 11:55a Jenny.cheung
 * 
 * 1     5/14/07 4:39p Jenny.cheung
 * created for crawford cedar hill user setup enhancement
 * 
 * 3     11/15/06 5:32p John.gwynn
 * Added or updated comments for NDoc documentation
 * 
 * 2     11/09/06 11:08a John.gwynn
 * modifed DbBaseClass to accept instance as the default parm in
 * constructor and adapted all subclasses to this structure.  Added onging
 * documentation improvements.
 * 
 * 1     10/17/06 11:40a John.gwynn
 * first of what may be multiple location### classes to provide
 * LOCATION_CODE functionality, in this case: GetCityFromZip
 */
#endregion

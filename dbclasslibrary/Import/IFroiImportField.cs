#region Header
/**************************************************************************
* Innovation First Notice
* 95 Wells Avenue
* Newton, MA 02459
* (617) 886-2600
*
* Proprietary Source Code -- Distribution restricted
*
* Copyright (c) 2009 by Innovation First Notice 
**************************************************************************/
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/Import/IFroiImportField.cs 3     9/25/09 2:37p John.gwynn $ */
#endregion

namespace DbClassLibrary.Import
{
	/// <summary>
	/// 
	/// </summary>
	[System.Runtime.InteropServices.ComVisible(false)]
	public interface IFroiImportField : IImportField
	{
		/// <summary>
		/// 
		/// </summary>
		int Id { get; set; }
		/// <summary>
		/// 
		/// </summary>
		string AttributeName { get; set; }

		/// <summary>
		/// 
		/// </summary>
		int StartPosition { get; set; }

		/// <summary>
		/// 
		/// </summary>
		int Length { get; set; }

		/// <summary>
		/// 
		/// </summary>
		string LegacyFieldName { get; set; }

		/// <summary>
		/// 
		/// </summary>
		string DataDefinition { get; set; }

		/// <summary>
		/// 
		/// </summary>
		string DefaultValue { get; set; }

		/// <summary>
		/// 
		/// </summary>
		string FroiImpRecordType { get; set; }

		/// <summary>
		/// 
		/// </summary>
		string FunctionName { get; }

		/// <summary>
		/// 
		/// </summary>
		int ConversionCount { get; }
	}
}

#region Log
/*
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/Import/IFroiImportField.cs $
 * 
 * 3     9/25/09 2:37p John.gwynn
 * Added ActiveRecordSet<T> to achieve covariance with respect to the
 * IEnumerable<ActiveRecord> base implementation for articulating strongly
 * typed repositories.
 * 
 * 2     9/22/09 11:06a John.gwynn
 * Import Field updates
 * 
 * 1     9/15/09 5:01p John.gwynn
 * Created Import folder and moved Froi classes for further refinement and
 * generalization.  Also resharper reformatting 
 * 
 * 
 * 
 * 
 * 
 * 
 * 4     5/26/09 11:05a John.gwynn
 * Added interop definitions
 * 
 * 2     1/21/09 1:32p John.gwynn
 * fixed SS keyword bug and added UserId to the CallRecord update
 */
#endregion

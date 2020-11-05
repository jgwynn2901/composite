#region Header
/**************************************************************************
* First Notice Systems
* 95 Wells Avenue
* Newton, MA 02459
* (617) 886-2600
*
* Proprietary Source Code -- Distribution restricted
*
* Copyright (c) 2007 by First Notice Systems
**************************************************************************/
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/Callflow/DistributionSuppressionRecord.cs 5     7/13/10 11:39a Gwynnj $ */
#endregion

using System;
using System.Data;

namespace DbClassLibrary.Callflow
{
	/// <summary>
	/// Encapsulates a record from the ADDRESS_BOOK_ENTRY table
	/// </summary>
	[System.Runtime.InteropServices.ComVisible(false)]
	public sealed class DistributionSuppressionRecord : ActiveRecord
	{
		#region Constructor
		/// <summary>
		/// Initializes a new instance of the <see cref="AddressBookRecord"/> class.
		/// </summary>
		public DistributionSuppressionRecord()
			: base("DISTRIBUTION_SUPPRESSION")
		{
			// Begin Generated Column Definitions
			columns.Add(new Column("DISTRIBUTION_SUPPRESSION_ID", String.Empty, "NUMBER"));
			columns.Add(new Column("BRANCH", String.Empty, "VARCHAR2"));
			columns.Add(new Column("BENEFIT_STATE", String.Empty, "CHAR"));
			columns.Add(new Column("CLIENT_CODE", String.Empty, "CHAR"));
			columns.Add(new Column("DISTRIBUTION_SUP_FLAG", String.Empty, "CHAR"));
			// End Generated Column Definitions
		}
		/// <summary>
		/// Initializes a new instance of the <see cref="AddressBookRecord"/> class.
		/// </summary>
		/// <param name="reader">The reader.</param>
		public DistributionSuppressionRecord(IDataReader reader)
			: base(reader, "DISTRIBUTION_SUPPRESSION")
		{
		}
		#endregion

		#region Id

		/// <summary>
		/// Gets or sets the distribution_ suppression_ id.
		/// </summary>
		public string Id

		{
			get
			{
				return GetColumnValue("DISTRIBUTION_SUPPRESSION_ID");
			}
			set
			{
				SetColumnValue("DISTRIBUTION_SUPPRESSION_ID", value);
			}
		}
		#endregion

		#region ClientCode

		/// <summary>
		/// Gets or sets the client code.
		/// </summary>
		/// <value>The client code.</value>
		public string ClientCode
		{
			get
			{
				return GetColumnValue("CLIENT_CODE");
			}
			set
			{
				SetColumnValue("CLIENT_CODE", value);
			}
		}
		#endregion

		#region BenefitState

		/// <summary>
		/// Gets or sets the state of the benefit_.
		/// </summary>

		public string Benefit_State
		{
			get
			{
				return GetColumnValue("BENEFIT_STATE");
			}
			set
			{
				SetColumnValue("BENEFIT_STATE", value);
			}
		}
		#endregion

		#region BranchNumber

		/// <summary>
		/// Gets or sets the branch_ number.
		/// </summary>

		public string Branch_Number
		{
			get
			{
				return GetColumnValue("BRANCH_NUMBER");
			}
			set
			{
				SetColumnValue("BRANCH_NUMBER", value);
			}
		}
		#endregion

		#region DistributionSuppressionFlag
		/// <summary>
		/// Gets or sets the distribution_ sup_ flag.
		/// </summary>
		public string DistributionSuppressionFlag

		{
			get
			{
				return GetColumnValue("DISTRIBUTION_SUP_FLAG");
			}
			set
			{

				SetColumnValue("DISTRIBUTION_SUP_FLAG", value);
			}

		}
		#endregion

		/// <summary>
		/// Gets the supression flag.
		/// </summary>
		public static string GetSupressionFlag(string clientCode, string state, string branch)
		{
			// only go the the database if we have these values set
			if (clientCode.Length > 0 && state.Length == 2 && branch.Length > 0)
			{
				DistriubtionSuppressionRecordSet distributions = new DistriubtionSuppressionRecordSet();
				distributions.ClientCode = clientCode;
				distributions.BenefitState = state;
				distributions.BranchNumber = branch;

				if (distributions.Execute() && distributions.Count > 0)
					foreach (DistributionSuppressionRecord rec in distributions)
						return rec.DistributionSuppressionFlag;
			}

			return "";
		}
	}
}

#region Log
/*
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/Callflow/DistributionSuppressionRecord.cs $
 * 
 * 5     7/13/10 11:39a Gwynnj
 * Removed ColumnMap and refactored to ColumnList class to manage
 * multi-key indexing
 * 
 * 4     9/15/09 5:01p John.gwynn
 * Created Import folder and moved Froi classes for further refinement and
 * generalization.  Also resharper reformatting 
 * 
 * 
 * 
 * 
 * 
 * 
 * 3     5/26/09 11:06a John.gwynn
 * Added interop definitions
 * 
 * 2     5/12/09 12:31p John.gwynn
 * updates to coordinate with 1.1 code
 * 
 * 2     5/12/09 12:14p John.gwynn
 * 
 * 2     2/10/09 12:14p John.gwynn
 * cleaned up the DistributionSuppressionRecord mess
 * 
 * 1     1/24/08 11:46a Jenny.cheung
 * created for Ess to bring the distribution suppression flag from a new
 * db table (distribution suppression)
 * 
 * 1     8/08/07 11:19a John.gwynn
 * restructured the DbClassLibrary adding folders
 * 
 * 2     6/03/07 2:09p John.gwynn
 * 
 * 1     4/19/07 4:36p John.gwynn
 * Added COM Interop support and begun work on Callflow data access
 */
#endregion
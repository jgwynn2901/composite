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
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/EsisPolicyLookup.cs 4     5/26/09 11:05a John.gwynn $ */
#endregion

using System;
using System.Runtime.InteropServices;
using ADODB;

namespace DbClassLibrary
{
	/// <summary>
	/// Summary description for EsisPolicyLookup.
	/// </summary>
	[ComVisible(false)]	
	public class EsisPolicyLookup
	{
		private const string dbInstance = "FNSP";
		private string _parentNodeId;
		private string _lossDate;
		private string _lobCd;
		private string _name;
		private string _address;
		private string _city;
		private string _state;
		private string _zip;
		private string _locationCode;
		private string _departmentCode;
		private string _policyNumber;
		private string _contractNumber;
		private string _permittedNodeId;
		private string _lastError;

		/// <summary>
		/// Initializes a new instance of the <see cref="EsisPolicyLookup"/> class.
		/// </summary>
		public EsisPolicyLookup()
		{
			Reset();

		}
		/// <summary>
		/// Gets or sets the parent node id.
		/// </summary>
		/// <value>The parent node id.</value>
		public string ParentNodeId
		{
			get { return _parentNodeId; }
			set { _parentNodeId = value; }
		}
		/// <summary>
		/// Gets or sets the loss date.
		/// </summary>
		/// <value>The loss date.</value>
		public string LossDate
		{
			get { return _lossDate; }
			set { _lossDate = value; }
		}
		/// <summary>
		/// Gets or sets the lob cd.
		/// </summary>
		/// <value>The lob cd.</value>
		public string LobCd
		{
			get { return _lobCd; }
			set { _lobCd = value; }
    }
		/// <summary>
		/// Gets or sets the name.
		/// </summary>
		/// <value>The name.</value>
		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}
		/// <summary>
		/// Gets or sets the address.
		/// </summary>
		/// <value>The address.</value>
		public string Address
		{
			get { return _address; }
			set { _address = value; }
		}
		/// <summary>
		/// Gets or sets the city.
		/// </summary>
		/// <value>The city.</value>
		public string City
		{
			get { return _city; }
			set { _city = value; }
		}
		/// <summary>
		/// Gets or sets the state.
		/// </summary>
		/// <value>The state.</value>
		public string State
		{
			get { return _state; }
			set { _state = value; }
		}
		/// <summary>
		/// Gets or sets the zip.
		/// </summary>
		/// <value>The zip.</value>
		public string Zip
		{
			get { return _zip; }
			set { _zip = value; }
		}
		/// <summary>
		/// Gets or sets the location code.
		/// </summary>
		/// <value>The location code.</value>
		public string LocationCode
		{
			get { return _locationCode; }
			set { _locationCode = value; }
		}
		/// <summary>
		/// Gets or sets the department code.
		/// </summary>
		/// <value>The department code.</value>
		public string DepartmentCode
		{
			get { return _departmentCode; }
			set { _departmentCode = value; }
		}
		/// <summary>
		/// Gets or sets the policy number.
		/// </summary>
		/// <value>The policy number.</value>
		public string PolicyNumber
		{
			get { return _policyNumber; }
			set { _policyNumber = value; }
		}
		/// <summary>
		/// Gets or sets the contract number.
		/// </summary>
		/// <value>The contract number.</value>
		public string ContractNumber
		{
			get { return _contractNumber; }
			set { _contractNumber = value; }
		}
		/// <summary>
		/// Gets or sets the permitted.
		/// </summary>
		/// <value>The permitted.</value>
		public string Permitted
		{
			get { return _permittedNodeId; }
			set { _permittedNodeId = value; }
		}
		/// <summary>
		/// Gets the last error.
		/// </summary>
		/// <value>The last error.</value>
		public string LastError
		{
			get{ return _lastError; }
		}
		/// <summary>
		/// Resets this instance.
		/// </summary>
		public void Reset()
		{
			_parentNodeId = String.Empty;
			_lossDate = String.Empty;
			_lobCd = String.Empty;
			_name = String.Empty;
			_address = String.Empty;
			_city = String.Empty;
			_state = String.Empty;
			_zip = String.Empty;
			_locationCode = String.Empty;
			_departmentCode = String.Empty;
			_policyNumber = String.Empty;
			_contractNumber = String.Empty;
			_permittedNodeId = String.Empty;
			_lastError = String.Empty;
		}
		/// <summary>
		/// Executes this instance.
		/// </summary>
		/// <returns>The resultSet as ADODB.RecordSetwvb
		/// </returns>
		public string Execute ()
		{
			string results = String.Empty;
			object dummy = Type.Missing;
			try
			{
				Connection connection = new ConnectionClass();
				connection.Open(GeneralUtility.GetAdoConnectStringFromInstance(dbInstance), String.Empty, String.Empty, -1);
				Command command = new CommandClass();
				command.ActiveConnection = connection;
				command.CommandType = CommandTypeEnum.adCmdStoredProc;
				command.CommandText = "DBCLASSLIBRARY.DoEsisLookupByPolicy";
				//===========================================================
				// ParentNodeId
				//===========================================================
				AddParameter(command, "p_parentNodeId", _parentNodeId, DataTypeEnum.adInteger, false);
				//===========================================================
				// Permitted
				//===========================================================
				AddParameter(command, "p_permittedNodeId", _permittedNodeId, DataTypeEnum.adInteger, false);
				//===========================================================
				// Policy Number
				//===========================================================
				AddParameter(command, "p_policyNumber", _policyNumber, DataTypeEnum.adVarChar, false);
				//===========================================================
				// LOB_CD
				//===========================================================
				AddParameter(command, "p_lobCd", _lobCd, DataTypeEnum.adVarChar, false);
				//===========================================================
				// LocationCode
				//===========================================================
				AddParameter(command, "p_locationCode", _locationCode, DataTypeEnum.adVarChar, false);
				//===========================================================
				// DepartmentCode
				//===========================================================
				AddParameter(command, "p_departmentCode", _departmentCode, DataTypeEnum.adVarChar, false);
				//===========================================================
				// ContractNumber
				//===========================================================
				AddParameter(command, "p_contractNumber", _contractNumber, DataTypeEnum.adVarChar, false);
				//===========================================================
				// Name
				//===========================================================
				AddParameter(command, "p_name", _name, DataTypeEnum.adVarChar, false);
				//===========================================================
				// City
				//===========================================================
				AddParameter(command, "p_city", _city, DataTypeEnum.adVarChar, false);
				//===========================================================
				// State
				//===========================================================
				AddParameter(command, "p_state", _state, DataTypeEnum.adVarChar, false);
				//===========================================================
				// Zip
				//===========================================================
				AddParameter(command, "p_zip", _zip, DataTypeEnum.adVarChar, false);
				
				Recordset policies = command.Execute(out dummy, ref dummy, 0);
				if(policies != null)
				{
					results = GeneralUtility.GetXmlFromAdoRecordset(policies);
					policies.Close();
				}
				connection.Close();
			}
			catch(Exception ex)
			{
				_lastError = ex.Message;
			}

			return results;
		}
		/// <summary>
		/// Adds the parameter.
		/// </summary>
		/// <param name="command">The command.</param>
		/// <param name="parmName">Name of the parm.</param>
		/// <param name="parmValue">The parm value.</param>
		/// <param name="dataType">Type of the data.</param>
		/// <param name="isOutput">if set to <c>true</c> [is output].</param>
		private void AddParameter (Command command,string parmName, string parmValue, DataTypeEnum dataType, bool isOutput)
		{
			if(dataType == DataTypeEnum.adInteger)
			{
				if(parmValue.Length > 0)
				{
					command.Parameters.Append(
						command.CreateParameter(parmName, 
						DataTypeEnum.adInteger, 
						isOutput ? ParameterDirectionEnum.adParamOutput:ParameterDirectionEnum.adParamInput,
						4,Convert.ToInt32(parmValue)));
				}
				else
				{
					command.Parameters.Append(
						command.CreateParameter(parmName, 
						DataTypeEnum.adInteger,
						isOutput ? ParameterDirectionEnum.adParamOutput:ParameterDirectionEnum.adParamInput,
						-1,DBNull.Value));
				}
			}
			else
			{
				if(parmValue.Length > 0)
				{
					command.Parameters.Append(
						command.CreateParameter(parmName, 
						dataType, 
						isOutput ? ParameterDirectionEnum.adParamOutput:ParameterDirectionEnum.adParamInput,
						parmValue.Length,parmValue));
				}
				else
				{
					command.Parameters.Append(
						command.CreateParameter(parmName, 
						dataType,
						isOutput ? ParameterDirectionEnum.adParamOutput:ParameterDirectionEnum.adParamInput,
						-1,DBNull.Value));
				}
			}
		}
	}
}
#region Log
/*
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/EsisPolicyLookup.cs $
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
 * 2     4/03/07 6:49p John.gwynn
 * ActiveRecordBase changed to ActiveRecord.  EsisPolicyLookup nullADODB
 * parms fixed.
 * 
 * 1     3/29/07 6:43p John.gwynn
 * Building up the infrastructure for policy lookups via stored procedures
 * using ADODB primary interop assembly - first cut for ESIS prototype
 */
#endregion
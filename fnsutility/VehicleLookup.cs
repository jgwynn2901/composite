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
/* $Header: /SourceCode/Components/FNS2005/FnsUtility/VehicleLookup.cs 2     5/24/08 3:43p John.gwynn $ */
#endregion
using System;
using ADODB;

namespace FnsUtility
{
	/// <summary>
	/// Summary description for VehicleLookup.
	/// </summary>
	public sealed class VehicleLookup
	{
		private VehicleLookup()
		{
		}
		/// <summary>
		/// Does the lookup. BUGBUG: we can refactor data access to DbClassLibrary 
		/// need to build ADODB support -JJG
		/// </summary>
		/// <param name="vehicleId">The vehicle id.</param>
		/// <returns></returns>
		public static string DoLookup (int vehicleId)
		{
			string results = String.Empty;
			string connectString = GeneralUtility.GetFormattedConnectStringFromRegistry();
			string connectionString = String.Format("Provider=MSDAORA.1;{0}", connectString);
			Assert.Test(connectionString.Length > 0, "VehicleLookup: unable to obtaing ConnectionString");
			
			Connection conn = new Connection();
			Command command = new Command();
			
			try
			{
				conn.Open(connectionString, String.Empty, String.Empty, -1);
				
				command.ActiveConnection = conn;
        command.CommandType = CommandTypeEnum.adCmdStoredProc;
        command.CommandText = "GET_POL_VEHICLES_COV_PKG.GET_VEHICLE_COVERAGE";
				command.Parameters.Append(
				command.CreateParameter("POLICY_ID_IN_PARAM", DataTypeEnum.adInteger, 
				                        ParameterDirectionEnum.adParamInput,4,vehicleId));
				
				object dummy = Type.Missing;
				Recordset vehicles = command.Execute(out dummy, ref dummy, 0);
				if(vehicles != null)
				{
					results = XmlUtility.GetXmlFromAdoRecordset(vehicles);
				}
			}
			catch (Exception ex)
			{
				ErrorLog.LogError("GetXmlFromAdoRecordset(): Error " +  ex.Message, "VehicleLookup");
			}
			finally
			{
				conn.Close();
			}

			return results;
		}
	}
}
#region History
/*
 * $History: VehicleLookup.cs $
 * 
 * *****************  Version 2  *****************
 * User: John.gwynn   Date: 5/24/08    Time: 3:43p
 * Updated in $/SourceCode/Components/FNS2005/FnsUtility
 * minor edits
 * 
 * *****************  Version 1  *****************
 * User: John.gwynn   Date: 1/18/07    Time: 2:38p
 * Created in $/SourceCode/Components/VS.NET2005/FnsUtility
 * Framework 2.0 upgrade
 * 
 * *****************  Version 1  *****************
 * User: John.gwynn   Date: 7/26/06    Time: 6:07p
 * Created in $/SourceCode/Components/VS.NET/FNSUtility
 * added Vehicle lookup (ADO)
 */
#endregion

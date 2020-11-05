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
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/VehicleCoverage.cs 4     5/26/09 11:05a John.gwynn $ */

using System;
using System.Runtime.InteropServices;

namespace DbClassLibrary
{
	/// <summary>
	/// Summary description for VehicleCoverage.
	/// </summary>
	[ComVisible(false)]
	public sealed class VehicleCoverage :DbBaseClass
	{
		private enum eParmList 
		{
			eVehicleCoverageID = 0,
			eFileTranLogId,
			eVehicleID,
			eCoverageType,
			eLimit1,
			eLimit2,
			eDeductible1,
			eDeductible2,
			eUploadKey,
			eActiveStartDt,
			eActiveEndDt,
			eReceivedStartDt,
			eReceivedEndDt,
			eDescr	};
		
		
		
		/// <summary>
		/// Initializes a new instance of the <see cref="VehicleCoverage"/> class.
		/// </summary>
		public VehicleCoverage():this(String.Empty)
		{	}

		/// <summary>
		/// Initializes a new instance of the <see cref="VehicleCoverage"/> class.
		/// </summary>
		/// <param name="instance">The instance.</param>
		public VehicleCoverage(string instance) :base(instance)
		{
			_name = "DBCLASSLIBRARY.ProcessVehicleCoverage";

			_parameterNames = new string[] {
													"p_nVehicleCoverageID",
													"p_nFileTranLogId",
													"p_nVehicleID",
													"p_nCOVERAGE_TYPE",
													"p_nLIMIT1",
													"p_nLIMIT2",
													"p_nDEDUCTIBLE1",
													"p_nDEDUCTIBLE2",
													"p_nUploadKey",
													"p_nActiveStartDt",
													"p_nActiveEndDt",
													"p_nReceivedStartDt",
													"p_nReceivedEndDt",
													"p_nDescr" };
			Initialize();
		}
		/// <summary>
		/// Initializes this instance parameters.
		/// </summary>
		protected override void Initialize()
		{
			///////////////////////////////////////////////////
			/////p_nVehicleCoverageID
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Output,
				_parameterNames[(int)eParmList.eVehicleCoverageID],"",System.Data.DbType.Int32);
			///////////////////////////////////////////////////
			/////p_nFileTranLogId
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.eFileTranLogId],"",System.Data.DbType.Int32);
			///////////////////////////////////////////////////
			/////p_nVehicleID
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.eVehicleID],"",System.Data.DbType.Int32);
			///////////////////////////////////////////////////
			///// p_nCOVERAGE_TYPE
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.eCoverageType],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// p_nLIMIT1
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.eLimit1],"",System.Data.DbType.Double);
			///////////////////////////////////////////////////
			///// p_nLIMIT2
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.eLimit2],"",System.Data.DbType.Double);
			///////////////////////////////////////////////////
			///// p_nDEDUCTIBLE1
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.eDeductible1],"",System.Data.DbType.Double);
			///////////////////////////////////////////////////
			///// p_nDEDUCTIBLE2
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.eDeductible2],"",System.Data.DbType.Double);
			///////////////////////////////////////////////////
			///// p_nUploadKey
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.eUploadKey],"",System.Data.DbType.AnsiString);
			///////////////////////////////////////////////////
			///// p_nActiveStartDt
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.eActiveStartDt],"",System.Data.DbType.Date);
			///////////////////////////////////////////////////
			///// p_nActiveEndDt
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.eActiveEndDt],"",System.Data.DbType.Date);
			///////////////////////////////////////////////////
			///// p_nReceivedStartDt
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.eReceivedStartDt],"",System.Data.DbType.Date);
			///////////////////////////////////////////////////
			///// p_nReceivedEndDt
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.eReceivedEndDt],"",System.Data.DbType.Date);
			///////////////////////////////////////////////////
			///// p_nDescr
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[(int)eParmList.eDescr],"",System.Data.DbType.AnsiString);
		}
		/// <summary>
		/// Gets the vehicle Coverage ID.
		/// </summary>
		/// <value>The vehicle Coverage ID.</value>
		public string VehicleCoverageID 
		{
			get 
			{
				return GetValue((int)eParmList.eVehicleCoverageID);
			}
		}
		/// <summary>
		/// Gets the vehicle ID.
		/// </summary>
		/// <value>The vehicle ID.</value>
		public string VehicleID 
		{
			get 
			{
				return GetValue((int)eParmList.eVehicleID);
			}
			set 
			{
				SetValue((int)eParmList.eVehicleID,value);
			}
		}
		/// <summary>
		/// Gets or sets the file tran log id.
		/// </summary>
		/// <value>The file tran log id.</value>
		public string FileTranLogId 
		{
			get 
			{
				return GetValue((int)eParmList.eFileTranLogId);
			}
			set 
			{
				SetValue((int)eParmList.eFileTranLogId,value);
			}
		}
		/// <summary>
		/// Gets or sets the type of the coverage.
		/// </summary>
		/// <value>The type of the coverage.</value>
		public string CoverageType 
		{
			get 
			{
				return GetValue((int)eParmList.eCoverageType);
			}
			set 
			{
				SetValue((int)eParmList.eCoverageType,value);
			}
		}
		/// <summary>
		/// Gets or sets the limit1.
		/// </summary>
		/// <value>The limit1.</value>
		public string Limit1 
		{
			get 
			{
				return GetValue((int)eParmList.eLimit1);
			}
			set 
			{
				SetValue((int)eParmList.eLimit1,value);
			}
		}
		/// <summary>
		/// Gets or sets the limit2.
		/// </summary>
		/// <value>The limit2.</value>
		public string Limit2 
		{
			get 
			{
				return GetValue((int)eParmList.eLimit2);
			}
			set 
			{
				SetValue((int)eParmList.eLimit2,value);
			}
		}
		/// <summary>
		/// Gets or sets the deductible1.
		/// </summary>
		/// <value>The deductible1.</value>
		public string Deductible1 
		{
			get 
			{
				return GetValue((int)eParmList.eDeductible1);
			}
			set 
			{
				SetValue((int)eParmList.eDeductible1,value);
			}
		}
		/// <summary>
		/// Gets or sets the deductible2.
		/// </summary>
		/// <value>The deductible2.</value>
		public string Deductible2 
		{
			get 
			{
				return GetValue((int)eParmList.eDeductible2);
			}
			set 
			{
				SetValue((int)eParmList.eDeductible2,value);
			}
		}
		/// <summary>
		/// Gets or sets the upload key.
		/// </summary>
		/// <value>The upload key.</value>
		public string UploadKey 
		{
			get 
			{
				return GetValue((int)eParmList.eUploadKey);
			}
			set 
			{
				SetValue((int)eParmList.eUploadKey,value);
			}
		}
		/// <summary>
		/// Gets or sets the description.
		/// </summary>
		/// <value>The description.</value>
		public string Description 
		{
			get 
			{
				return GetValue((int)eParmList.eDescr);
			}
			set 
			{
				SetValue((int)eParmList.eDescr,value);
			}
		}
		/// <summary>
		/// Gets or sets the active start date.
		/// </summary>
		/// <value>The active start date.</value>
		public string ActiveStartDate 
		{
			get 
			{
				return GetValue((int)eParmList.eActiveStartDt);
			}
			set 
			{
				SetValue((int)eParmList.eActiveStartDt,value);
			}
		}
		/// <summary>
		/// Gets or sets the active end date.
		/// </summary>
		/// <value>The active end date.</value>
		public string ActiveEndDate 
		{
			get 
			{
				return GetValue((int)eParmList.eActiveEndDt);
			}
			set 
			{
				SetValue((int)eParmList.eActiveEndDt,value);
			}
		}
		/// <summary>
		/// Gets or sets the received start date.
		/// </summary>
		/// <value>The received start date.</value>
		public string ReceivedStartDate 
		{
			get 
			{
				return GetValue((int)eParmList.eReceivedStartDt);
			}
			set 
			{
				SetValue((int)eParmList.eReceivedStartDt,value);
			}
		}
		/// <summary>
		/// Gets or sets the received end date.
		/// </summary>
		/// <value>The received end date.</value>
		public string ReceivedEndDate
		{
			get 
			{
				return GetValue((int)eParmList.eReceivedEndDt);
			}
			set 
			{
				SetValue((int)eParmList.eReceivedEndDt,value);
			}
		}
	}
}
/*
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/VehicleCoverage.cs $
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
 * 5     11/09/06 11:08a John.gwynn
 * modifed DbBaseClass to accept instance as the default parm in
 * constructor and adapted all subclasses to this structure.  Added onging
 * documentation improvements.
 * 
 * 4     8/25/06 10:07a John.gwynn
 * added vehicle coverage extensions and vehicle lien support
 * 
 * 3     4/06/06 6:16p John.gwynn
 * Added NcciCode and AhsIdFromLocation
 * 
 * 2     3/29/06 5:38p John.gwynn
 * added Vehicle Coverage
 * 
 * 1     3/29/06 4:09p John.gwynn
 * added Coverages
 */

using System;

namespace DbClassLibrary
{
	/// <summary>
	/// Summary description for eSurancePolicy.
	/// </summary>
	[System.Runtime.InteropServices.ComVisible(false)]
	public class eSurancePolicy : Policy
	{
		#region Constructor

		/// <summary>
		/// default constructor uses the registry db instance
		/// </summary>
		public eSurancePolicy()
			: this(String.Empty)
		{
		}
		/// <summary>
		/// user can name db instance
		/// </summary>
		/// <param name="instance"></param>
		public eSurancePolicy(string instance)
			: base(instance)
		{
			_name = "DBCLASSLIBRARY.ProcessPolicy";
			///////////////////////////////////////////////////
			/////p_nLoadedFlag
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Output,
				"p_nLoadedFlag", "", System.Data.DbType.Int32);
		}

		#endregion

		/// <summary>
		/// Gets the loaded flag.
		/// </summary>
		public string LoadedFlag
		{
			get
			{
				return GetValue("p_nLoadedFlag");
			}
		}
	}
}

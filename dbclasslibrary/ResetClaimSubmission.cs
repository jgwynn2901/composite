using System;
using System.Runtime.InteropServices;

namespace DbClassLibrary
{
	/// <summary>
	/// Summary description for ResetClaimSubmission.
	/// </summary>
	[ComVisible(false)]	
	public class ResetClaimSubmission : DbBaseClass
	{
		private int eRquId = 0;
		
		#region Constructor
		/// <summary>
		/// Initializes a new instance of the <see cref="ResetClaimSubmission"/> class.
		/// </summary>
		public ResetClaimSubmission():this(String.Empty) {}	
	
		/// <summary>
		/// Initializes a new instance of the <see cref="ResetClaimSubmission"/> class.
		/// </summary>
		/// <param name="instance">The instance.</param>
		public ResetClaimSubmission(string instance) :base(instance)
		{
			_name = "DBCLASSLIBRARY.ResetClaimSubmissionStatus";

			_parameterNames = new string[] { "rquId" };
			Initialize();
		}
		#endregion
		#region Initialize
		/// <summary>
		/// Initializes this instance.
		/// </summary>
		protected override void Initialize()
		{
			///////////////////////////////////////////////////
			/////p_nFileTranLogID
			///////////////////////////////////////////////////
			AddParm(System.Data.ParameterDirection.Input,
				_parameterNames[eRquId],"",System.Data.DbType.AnsiString);
		}
		#endregion

		#region Public Properties
		
		/// <summary>
		/// Gets or sets the rqu id.
		/// </summary>
		/// <value>The rqu id.</value>
		public string RquId 
		{
			get 
			{
				return GetValue(eRquId);
			}
			set 
			{
				SetValue(eRquId,value);
			}
		}
		#endregion
	}
}

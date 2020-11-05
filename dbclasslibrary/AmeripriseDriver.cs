using System.Data;
using System.Runtime.InteropServices;

namespace DbClassLibrary
{
	///<summary>
	///</summary>
	[ComVisible(false)]
	public sealed class AmeripriseDriver : Driver
	{
		private const string dbInstance = "AMEP";
		
		/// <summary>
		/// Initializes a new instance of the <see cref="EsuranceDriver"/> class.
		/// </summary>
		public AmeripriseDriver():this(dbInstance)
		{
		}
		
		///<summary>
		///</summary>
		///<param name="instance"></param>
		public AmeripriseDriver(string instance) :base(instance)
		{
			_name = "DBCLASSLIBRARY.ProcessDriverExtended";

		}
		/// <summary>
		/// Set up parameter definitions here
		/// </summary>
		/// <remarks>
		/// the definitions can be defined externally (configuration)
		/// and iterated here for maximum flexibility
		/// </remarks>
		protected override void Initialize()
		{
			base.Initialize();
			///////////////////////////////////////////////////
			///// Type
			///////////////////////////////////////////////////
			AddParm(ParameterDirection.Input,
				"p_nNameMi", "", DbType.AnsiString);
			AddParm(ParameterDirection.Input,
				"p_nMaritalStatus", "", DbType.AnsiString);
		}
		/// <summary>
		/// Gets or sets the name mi.
		/// </summary>
		/// <value>The name mi.</value>
		public string NameMi
		{
			get
			{
				return GetValue("p_nNameMi");
			}
			set
			{
				SetValue("p_nNameMi", value);
			}
		}
		/// <summary>
		/// Gets or sets the marital status.
		/// </summary>
		/// <value>The marital status.</value>
		public string MaritalStatus
		{
			get
			{
				return GetValue("p_nMaritalStatus");
			}
			set
			{
				SetValue("p_nMaritalStatus", value);
			}
		}
	}
}

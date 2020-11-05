using System;
using System.Data;
using FnsComposite.Interfaces;

namespace DbClassLibrary
{
	/// <summary>
	/// 
	/// </summary>
    [Obsolete("Use ActiveRecords.Policy instead.")]
    public class PolicyActiveRecord : ActiveRecords.Policy, IPolicy
	{
		private CarrierActiveRecord _carrier;

		#region Constructors
		/// <summary>
		/// Initializes a new instance of the <see cref="PolicyActiveRecord"/> class.
		/// </summary>
		public PolicyActiveRecord()
		{}

		/// <summary>
		/// Initializes a new instance of the <see cref="PolicyActiveRecord"/> class.
		/// </summary>
		/// <param name="reader">The reader.</param>
		public PolicyActiveRecord(IDataReader reader) : base(reader)
		{ }

		#endregion 
        
		#region CarrierId

		/// <summary>
		/// Gets the ahs id.
		/// </summary>
		/// <value>The ahs id.</value>
		public string AhsId
		{
			get { return AccntHrcyStepId; }
		}

		/// <summary>
		/// Gets the line of business.
		/// </summary>
		/// <value>The line of business.</value>
		public string LineOfBusiness
		{
			get { return LobCode; }
        }

        #endregion

        /// <summary>
        /// EFFECTIVE_DATE
        /// </summary>
        /// <value></value>
	    public new string EffectiveDate
	    {
            get { return base.EffectiveDate.ToShortDateString(); }
	    }

        /// <summary>
        /// EXPIRATION_DATE
        /// </summary>
        /// <value></value>
	    public new string ExpirationDate
	    {
	        get { return base.ExpirationDate.ToShortDateString(); }
	    }

	    /// <summary>
		/// Gets the description.
		/// </summary>
		public string Description
		{
			get { return PolicyDecription; }
		}

		/// <summary>
		/// Gets the coverage codes.
		/// </summary>
		public string CoverageCodes
		{
			get { return ""; }
		}

		/// <summary>
		/// Gets the carrier.
		/// </summary>
		/// <value>The carrier.</value>
		public CarrierActiveRecord Carrier
		{
			get
			{
				if (_carrier == null)
					_carrier = GetCarrierRecord();

				return _carrier;

			}
		}

		private CarrierActiveRecord GetCarrierRecord()
		{
			if (!string.IsNullOrEmpty(CarrierId))
			{
				var results = new CarrierActiveRecord {Instance = Instance, CarrierId = CarrierId};
				if (results.Execute())
					return results;
			}
			return null;
		}

		/// <summary>
		/// Generates the update SQL.
		/// </summary>
		/// <returns></returns>
		protected override string GenerateUpdateSql()
		{
			return GenerateUpdateSqlForChanges();
		}
	}
}



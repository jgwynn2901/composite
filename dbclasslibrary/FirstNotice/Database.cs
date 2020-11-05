namespace DbClassLibrary.FirstNotice
{
	/// <summary>
	/// Provides data context for Linq queries against
	/// FirstNotice database based in instance.
	/// </summary>
	public class Database : FNSOWNER
	{
        /// <summary>
        /// Initializes a new instance of the <see cref="Database"/> class.
        /// </summary>
        public Database()
            : this(ApplicationConfiguration.Instance.DefaultInstance)
	    {}

	    /// <summary>
		/// Initializes a new instance of the <see cref="Database"/> class.
		/// </summary>
		/// <param name="instance">The instance.</param>
		public Database (string instance) : base (GeneralUtility.GetConnectStringFromInstance(instance))
		{}
	}

	/// <summary>
	/// Direct access to FNSP
	/// </summary>
	public sealed class Production : Database
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="Production"/> class.
		/// </summary>
		public Production() : base (DbBaseClass.FNSP)
		{}
	}

	/// <summary>
	/// Direct access to AMEP
	/// </summary>
	public sealed class Ameriprise : Database
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="Ameriprise"/> class.
		/// </summary>
		public Ameriprise()
			: base(DbBaseClass.AMEP)
		{ }
	}

	/// <summary>
	/// Direct access to ESUP
	/// </summary>
	public sealed class Esurance : Database
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="Esurance"/> class.
		/// </summary>
		public Esurance()
			: base(DbBaseClass.ESUP)
		{ }
	}

	/// <summary>
	/// Direct access to SEDP
	/// </summary>
	public sealed class Sedgewick : Database
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="Sedgewick"/> class.
		/// </summary>
		public Sedgewick()
			: base(DbBaseClass.SEDP)
		{ }
	}

	/// <summary>
	/// Direct access to SENP
	/// </summary>
	public sealed class Sentry : Database
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="Sentry"/> class.
		/// </summary>
		public Sentry()
			: base(DbBaseClass.SENP)
		{ }
	}

	/// <summary>
	/// Direct access to SELP
	/// </summary>
	public sealed class Selective : Database
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="Selective"/> class.
		/// </summary>
		public Selective()
			: base(DbBaseClass.SELP)
		{ }
	}
}

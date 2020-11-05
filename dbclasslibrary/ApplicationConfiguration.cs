namespace DbClassLibrary
{
	/// <summary>
	/// 
	/// </summary>
  public class ApplicationConfiguration : ApConfigBase
	{
		private static ApplicationConfiguration _singletonInstance;

		/// <summary>
		/// Gets the instance.
		/// </summary>
		/// <value>The instance.</value>
		public static ApplicationConfiguration Instance
		{
			get { return _singletonInstance ?? (_singletonInstance = new ApplicationConfiguration()); }
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="ApplicationConfiguration"/> class.
		/// </summary>
		protected ApplicationConfiguration()
		{
			DefaultInstance = DatabaseInstance.InstanceFromRegistry();
		}

		/// <summary>
		/// encapsulates the DefaultInstance registry value.
		/// </summary>
		public string DefaultInstance { get; private set; }

		


	}
}

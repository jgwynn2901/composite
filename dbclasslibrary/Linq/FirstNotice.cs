namespace DbClassLibrary.Linq
{
	/// <summary>
	/// 
	/// </summary>
	public class FirstNotice
	{
		/// <summary>
		/// 
		/// </summary>
		public Query<ActiveRecords.Employee> Employees;

		/// <summary>
		/// 
		/// </summary>
        public Query<ActiveRecords.EmployeeExtension> EmployeeExtensions;

        /// <summary>
        /// 
        /// </summary>
        public Query<Security.User> Users;

		/// <summary>
		/// 
		/// </summary>
		public Query<AutoMakeRecord> AutoMakes;

		/// <summary>
		/// 
		/// </summary>
		public Query<AutoModelRecord> AutoModels;

		/// <summary>
		/// Initializes a new instance of the <see cref="FirstNotice"/> class.
		/// </summary>
		public FirstNotice(string instance)
		{
			QueryProvider provider = new ActiveQueryProvider(instance);
			Employees = new Query<ActiveRecords.Employee>(provider);
			EmployeeExtensions = new Query<ActiveRecords.EmployeeExtension>(provider);
			AutoMakes = new Query<AutoMakeRecord>(provider);
            AutoModels = new Query<AutoModelRecord>(provider);
            Users = new Query<Security.User>(provider);
        }

	}
}

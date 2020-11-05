namespace DbClassLibrary.Linq
{
	/// <summary>
	/// Nortwind Class
	/// </summary>
	public class Customers : ActiveRecord
	{
		/// <summary>
		/// Gets or sets the customer ID.
		/// </summary>
		/// <value>The customer ID.</value>
		public string CustomerId
		{
			get { return GetColumnValue("CustomerId"); }
			set { SetColumnValue("CustomerId", value); }
		}

		/// <summary>
		/// Gets or sets the name of the contact.
		/// </summary>
		/// <value>The name of the contact.</value>
		public string ContactName
		{
			get { return GetColumnValue("ContactName"); }
			set { SetColumnValue("ContactName", value); }
		}
		/// <summary>
		/// Gets or sets the phone.
		/// </summary>
		/// <value>The phone.</value>
		public string Phone
		{
			get { return GetColumnValue("Phone"); }
			set { SetColumnValue("Phone", value); }
		}

		/// <summary>
		/// Gets or sets the city.
		/// </summary>
		/// <value>The city.</value>
		public string City
		{
			get { return GetColumnValue("City"); }
			set { SetColumnValue("City", value); }
		}

		/// <summary>
		/// Gets or sets the country.
		/// </summary>
		/// <value>The country.</value>
		public string Country
		{
			get { return GetColumnValue("Country"); }
			set { SetColumnValue("Country", value); }
		}

	}
}

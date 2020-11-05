namespace DbClassLibrary
{
	/// <summary>
	/// 
	/// </summary>
	public class ContactActiveRecordSet : ActiveRecordSet
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ContactActiveRecordSet"/> class.
		/// </summary>
		public ContactActiveRecordSet()
			: base("ContactActiveRecord")
		{}

		/// <summary>
		/// Gets the contacts by ahs id.
		/// </summary>
		/// <param name="ahsId">The ahs id.</param>
		/// <returns></returns>
		static public ContactActiveRecordSet GetContactsByAhsId(string ahsId)
		{
			return GetContactsByAhsId(ahsId, ApplicationConfiguration.Instance.DefaultInstance);
		}

		/// <summary>
		/// Gets the contacts by ahs id.
		/// </summary>
		/// <param name="ahsId">The ahs id.</param>
		/// <param name="instance">The instance.</param>
		/// <returns></returns>
		static public ContactActiveRecordSet GetContactsByAhsId(string ahsId, string instance)
		{
			var contacts = new ContactActiveRecordSet
			               	{
			               		Instance = instance,
			               		Query =
			               			"select * from CONTACT where CONTACT_ID IN (select CONTACT_ID from AHS_CONTACT where ACCNT_HRCY_STEP_ID = :ahsId)"
			               	};
			contacts.AddParameter("ahsId",ahsId);
			contacts.Execute();
			return contacts;
		}
	}
}

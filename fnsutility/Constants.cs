namespace FnsUtility
{
	/// <summary>
	/// Please aggregate company wide constants here
	/// </summary>
	public static class Constants
	{
		/// <summary>
		/// Selective AccountHierarchyStepId
		/// </summary>
		public const int SelectiveAhsId = Client.Selective;

		/// <summary>
		/// CSAA AccountHierarchyStepId
		/// </summary>
		public const int CsaaAhsId = Client.CaliforniaStateAuto;

		/// <summary>
		/// Beech AccountHierarchyStepId
		/// </summary>
        public const int BeechAhsId = Client.Beech;

		/// <summary>
		/// Esis AccountHierarchyStepId
		/// </summary>
        public const int EsisAhsId = Client.Esis;

		/// <summary>
		/// Ace AccountHierarchyStepId
		/// </summary>
        public const int AceAhsId = Client.Ace;

		/// <summary>
		/// Esurance AccountHierarchyStepId
		/// </summary>
        public const int EsuranceAhsId = Client.Esurance;

		/// <summary>
		/// Ameriprise AccountHierarchyStepId
		/// </summary>
        public const int AmeripriseAhsId = Client.Ameriprise;

        /// <summary>
        /// Call.Claim.ClaimNumber
        /// </summary>
        public const string ClaimNumberAttribute = "CLAIM:CLAIM_NUMBER";

        /// <summary>
        /// Call.LastError
        /// </summary>
        public const string LastErrorAttribute = "LAST_ERROR";

	    /// <summary>
	    /// Destination String
	    /// </summary>
	    public const string DestinationStringAttribute = "DESTINATION_STRING";

        /// <summary>
        /// OPM Error string
        /// </summary>
        public const string ErrorStringAttribute = "ERRORSTRING";
    }
}

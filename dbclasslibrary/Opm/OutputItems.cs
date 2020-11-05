using System;

namespace DbClassLibrary.Opm
{
	/// <summary>
	/// 
	/// </summary>
	[System.Runtime.InteropServices.ComVisible(false)]
	public class OutputItems : ActiveRecordSet<OutputItem>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="OutputItems"/> class.
		/// Example: var items = new OutputItems {Instance = DbBaseClass.FNSP, TransmissionSequenceStepId = 115163};
		/// returns the output items for a given output sequence.
		/// </summary>
		public OutputItems()
			: base("OutputItem")
		{ }

		/// <summary>
		/// Gets or sets the transmission sequence step id.
		///  </summary>
		/// <value>The transmission sequence step id.</value>
		public int TransmissionSequenceStepId { get; set; }

        /// <summary>
        /// Gets or sets the query.
        /// </summary>
        /// <value>The query.</value>
		public override string Query
		{
			get
			{
				return ResourceReader.ReadFileResource(typeof(OutputItem).Assembly.FullName, "DbClassLibrary.Opm.OutputItemSql.txt");
			}
			set
			{
				throw new NotImplementedException();
			}
		}

        /// <summary>
        /// Adds the query parameters.
        /// </summary>
		protected override void AddQueryParameters()
		{
			AddParameter("TranSeqId", TransmissionSequenceStepId);
		}
	}
}

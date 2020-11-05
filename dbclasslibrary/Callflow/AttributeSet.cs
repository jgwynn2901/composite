namespace DbClassLibrary.Callflow
{
	/// <summary>
	/// ATTRIBUTES repository
	/// </summary>
	[System.Runtime.InteropServices.ComVisible(false)]
	public class AttributeSet : ActiveRecordSet<Attribute>
	{
		private int _frameId;
		/// <summary>
		/// Initializes a new instance of the <see cref="AttributeSet"/> class.
		/// </summary>
		public AttributeSet()
			: base("Attribute")
		{}

		/// <summary>
		/// will return the attributes for a given parent frame by Id.
		/// </summary>
		public int FrameId
		{
			get { return _frameId; }
			set { _frameId = value; }
		}

		/// <summary>
		/// for the convenience of setting or resetting Id from string
		/// </summary>
		public void SetFrameId(string frame)
		{
			if (string.IsNullOrEmpty(frame))
				_frameId = 0;
			else if (!int.TryParse(frame, out _frameId))
				_frameId = 0;
		}

		/// <summary>
		/// Gets or sets the query.
		/// </summary>
		/// <value>The query.</value>
		public override string Query
		{
			get
			{
				if (string.IsNullOrEmpty(query))
					return "select * from ATTRIBUTE_VIEW where FRAME_ID = " + _frameId + " ORDER BY SEQUENCE, ATTR_INSTANCE_ID, AO_SEQUENCE";
				
				return query;
			}
		}
	}
}

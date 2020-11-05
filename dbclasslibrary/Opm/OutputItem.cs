using System.Data;

namespace DbClassLibrary.Opm
{
	/// <summary>
	/// encapsuates the outitems for a given output page
	/// </summary>
	[System.Runtime.InteropServices.ComVisible(false)]
	public class OutputItem : ActiveRecord
	{
		#region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="CallRouting"/> class.
        /// </summary>
        public OutputItem()
            : base("OUTPUT_FIELD_VIEW")
        {
        	
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallRouting"/> class.
        /// </summary>
        /// <param name="reader">The reader.</param>
		public OutputItem(IDataReader reader)
			: base(reader, "OUTPUT_FIELD_VIEW")
		{ }

        #endregion

		#region FieldName
		/// <summary>
		/// NAME
		/// </summary>
		public string FieldName
		{
			get { return GetColumnValue("NAME"); }
			set { SetColumnValue("NAME", value); }
		}
		#endregion

		#region Sequence
		/// <summary>
		/// OUTPUT_FLD_ID
		/// </summary>
		public int Sequence
		{
			get { return GetColumnValueAsInt("SEQUENCE") ?? 0; }
			set { SetColumnValue("SEQUENCE", value.ToString()); }
		}
		#endregion

		#region FontName
		/// <summary>
		/// FONT_NAME
		/// </summary>
		public string FontName
		{
			get { return GetColumnValue("FONT_NAME"); }
			set { SetColumnValue("FONT_NAME", value); }
		}
		#endregion

		#region FontSize
		/// <summary>
		/// FONT_SIZE
		/// </summary>
		public int FontSize
		{
			get { return GetColumnValueAsInt("FONT_SIZE") ?? 0; }
			set { SetColumnValue("FONT_SIZE", value.ToString()); }
		}
		#endregion

		#region BoldFlag
		/// <summary>
		/// BOLD_FLG
		/// </summary>
		public string BoldFlag
		{
			get { return GetColumnValue("BOLD_FLG"); }
			set { SetColumnValue("BOLD_FLG", value); }
		}
		#endregion

		#region ItalicFlag
		/// <summary>
		/// ITALIC_FLG
		/// </summary>
		public string ItalicFlag
		{
			get { return GetColumnValue("ITALIC_FLG"); }
			set { SetColumnValue("ITALIC_FLG", value); }
		}
		#endregion

		#region UnderlineFlag
		/// <summary>
		/// UNDERLINE_FLG
		/// </summary>
		public string UnderlineFlag
		{
			get { return GetColumnValue("UNDERLINE_FLG"); }
			set { SetColumnValue("UNDERLINE_FLG", value); }
		}
		#endregion

		#region StrikeoutFlag
		/// <summary>
		/// STRIKEOUT_FLG
		/// </summary>
		public string StrikeoutFlag
		{
			get { return GetColumnValue("STRIKEOUT_FLG"); }
			set { SetColumnValue("STRIKEOUT_FLG", value); }
		}
		#endregion

		#region Width
		/// <summary>
		/// WIDTH
		/// </summary>
		public int Width
		{
			get { return GetColumnValueAsInt("WIDTH") ?? 0; }
			set { SetColumnValue("WIDTH", value.ToString()); }
		}
		#endregion

		#region Height
		/// <summary>
		/// HEIGHT
		/// </summary>
		public int Height
		{
			get { return GetColumnValueAsInt("HEIGHT") ?? 0; }
			set { SetColumnValue("HEIGHT", value.ToString()); }
		}
		#endregion

		#region Xposition
		/// <summary>
		/// XPOS
		/// </summary>
		public int Xposition
		{
			get { return GetColumnValueAsInt("XPOS") ?? 0; }
			set { SetColumnValue("XPOS", value.ToString()); }
		}
		#endregion

		#region Yposition
		/// <summary>
		/// YPOS
		/// </summary>
		public int Yposition
		{
			get { return GetColumnValueAsInt("YPOS") ?? 0; }
			set { SetColumnValue("YPOS", value.ToString()); }
		}
		#endregion

		#region MultilineFlag
		/// <summary>
		/// MULTILINE_FLG
		/// </summary>
		public string MultilineFlag
		{
			get { return GetColumnValue("MULTILINE_FLG"); }
			set { SetColumnValue("MULTILINE_FLG", value); }
		}
		#endregion

		#region PageNumber
		/// <summary>
		/// Gets or sets the page number.
		/// </summary>
		/// <value>The page number.</value>
		public int PageNumber
		{
			get { return GetColumnValueAsInt("PAGE_NUMBER") ?? 0; }
			set { SetColumnValue("PAGE_NUMBER", value.ToString()); }
		}

		#endregion

		#region Bitmap
		/// <summary>
		/// Gets or sets the bitmap.
		/// </summary>
		public string Bitmap
		{
			get { return GetColumnValue("BMP"); }
			set { SetColumnValue("BMP", value); }
		}
		#endregion

		#region DuplexPrintFlag
		/// <summary>
		/// DUPLEX_PRINT_FLG
		/// </summary>
		public string DuplexPrintFlag
		{
			get { return GetColumnValue("DUPLEX_PRINT_FLG"); }
			set { SetColumnValue("DUPLEX_PRINT_FLG", value); }
		}
		#endregion

		#region BackgroundBitmap
		/// <summary>
		/// Gets or sets the background bitmap.
		/// </summary>
		public string BackgroundBitmap
		{
			get { return GetColumnValue("BACKGROUND_BMP"); }
			set { SetColumnValue("BACKGROUND_BMP", value); }
		}
		#endregion

		#region Orientation
		/// <summary>
		/// ORIENTATION
		/// </summary>
		public string Orientation
		{
			get { return GetColumnValue("ORIENTATION"); }
			set { SetColumnValue("ORIENTATION", value); }
		}
		#endregion

		#region PageName
		/// <summary>
		/// PAGE_NAME
		/// </summary>
		public string PageName
		{
			get { return GetColumnValue("PAGE_NAME"); }
			set { SetColumnValue("PAGE_NAME", value); }
		}
		#endregion

		#region Mapping
		/// <summary>
		/// MAPPING
		/// </summary>
		public string Mapping
		{
			get { return GetColumnValue("MAPPING"); }
			set { SetColumnValue("MAPPING", value); }
		}
		#endregion

		#region RuleId
		/// <summary>
		/// Gets or sets the page number.
		/// </summary>
		/// <value>The page number.</value>
		public int RuleId
		{
			get { return GetColumnValueAsInt("RULE_ID") ?? 0; }
			set { SetColumnValue("RULE_ID", value.ToString()); }
		}
		#endregion
	}
}

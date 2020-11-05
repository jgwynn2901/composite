using System.Data;
using System.Runtime.InteropServices;

namespace DbClassLibrary.ActiveRecords
{
	/// <summary>
	/// 
	/// </summary>
	[ComVisible(false), TableDefinition(TableName = "FNSOWNER.EMPLOYEE_EXT")]
	public class EmployeeExtension : ActiveRecord
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="EmployeeExtension"/> class.
		/// </summary>
		public EmployeeExtension()
			: base("EMPLOYEE_EXT")
		{
			columns.Add(new Column("EMPLOYEE_ID", string.Empty, "NUMBER"));
    		columns.Add(new Column("FIELD_NAME", string.Empty, "VARCHAR2"));
			columns.Add(new Column("FIELD_VALUE", string.Empty, "VARCHAR2"));
		}

        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeExtension"/> class.
        /// </summary>
        /// <param name="reader">The reader.</param>
        public EmployeeExtension(IDataReader reader)
            : base(reader, "EMPLOYEE_EXT")
        {
        }

		/// <summary>
		/// Gets or sets the employee id.
		/// </summary>
		/// <value>The employee id.</value>
		[FieldDefintion(FieldName = "EMPLOYEE_ID")]
		public string EmployeeId
		{
			get { return GetColumnValue("EMPLOYEE_ID"); }
			set { SetColumnValue("EMPLOYEE_ID", value); }
		}

		/// <summary>
		/// Gets or sets the name of the field.
		/// </summary>
		/// <value>The name of the field.</value>
		[FieldDefintion(FieldName = "FIELD_NAME")]
		public string FieldName
		{
			get { return GetColumnValue("FIELD_NAME"); }
			set { SetColumnValue("FIELD_NAME", value); }
		}

		/// <summary>
		/// Gets or sets the field value.
		/// </summary>
		/// <value>The field value.</value>
		[FieldDefintion(FieldName = "FIELD_VALUE")]
		public string FieldValue
		{
			get { return GetColumnValue("FIELD_VALUE"); }
			set { SetColumnValue("FIELD_VALUE", value); }
		}
	}
}

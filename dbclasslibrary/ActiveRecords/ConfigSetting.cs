using System.Data;
using System.Runtime.InteropServices;

namespace DbClassLibrary.ActiveRecords
{

    /// <summary>
    /// 
    /// </summary>
    [ComVisible(false)]
    public class ConfigSettings : ActiveRecordSet<ConfigSetting>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Employees"/> class.
        /// </summary>
        public ConfigSettings()
            : base("ConfigSetting")
        { }
    }
    /// <summary>
    /// 
    /// </summary>
    [ComVisible(false)]
    public class ConfigSetting : ActiveRecord
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigSetting"/> class.
        /// </summary>
        public ConfigSetting() : base ("CONFIG_SETTINGS")
        {
            columns.Add(new Column("APPLICATION", string.Empty, "VARCHAR2"));
            columns.Add(new Column("KEY", string.Empty, "VARCHAR2"));
            columns.Add(new Column("VALUE", string.Empty, "VARCHAR2"));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigSetting"/> class.
        /// </summary>
        /// <param name="reader">The reader.</param>
        public ConfigSetting(IDataReader reader)
            : base(reader, "CONFIG_SETTINGS")
		{}

        #region Application
        /// <summary>
        /// APPLICATION
        /// </summary>
        public string Application
        {
            get { return GetColumnValue("APPLICATION"); }
            set { SetColumnValue("APPLICATION", value); }
        }
        #endregion

        #region ConfigKey
        /// <summary>
        /// KEY
        /// </summary>
        public string ConfigKey
        {
            get { return GetColumnValue("KEY"); }
            set { SetColumnValue("KEY", value); }
        }
        #endregion

        #region ConfigValue
        /// <summary>
        /// VALUE
        /// </summary>
        public string ConfigValue
        {
            get { return GetColumnValue("VALUE"); }
            set { SetColumnValue("VALUE", value); }
        }
        #endregion


    }
}

#region Header
/**************************************************************************
* Innovation First Notice
* 95 Wells Avenue
* Newton, MA 02459
* (617) 886-2600
*
* Proprietary Source Code -- Distribution restricted
*
* Copyright (c) 2009 by Innovation First Notice 
**************************************************************************/
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/Import/FroiImportFields.cs 4     5/06/10 10:40a Ashley.pinto $ */
#endregion

using System.Text;

namespace DbClassLibrary.Import
{
    /// <summary>
    /// 
    /// </summary>
    [System.Runtime.InteropServices.ComVisible(false)]
    public class FroiImportFields : ActiveRecordSet<FroiImportField>
    {
        private int _fileDefId;

        /// <summary>
        /// Initializes a new instance of the <see cref="FroiImportFields"/> class.
        /// </summary>
        public FroiImportFields()
            : base("FroiImportField")
        { }

        /// <summary>
        /// 
        /// </summary>
        public int FileDefId
        {
            get { return _fileDefId; }
            set { _fileDefId = value; }
        }

        /// <summary>
        /// Gets or sets the file_rec_id.
        /// </summary>
        public int FileRecId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public override string Query
        {
            get
            {
                return string.IsNullOrEmpty(base.Query) ? BuildQuery() : base.Query;
            }
            set
            {
                base.Query = value;
            }
        }

        private string BuildQuery()
        {
            var sql = new StringBuilder();
            if (FileRecId == 1 || FileRecId == 2)
            {
                sql.Append("SELECT FROI_IMP_MAP.FROI_IMP_MAP_ID, ATTRIBUTE_NAME, STARTPOS, LENGTH, FUNCTION_NAME, DEFAULT_VALUE,FROI_IMP_RECORD_ID,FROI_IMP_RECORD_TYPE,");
                sql.Append("(SELECT count(*) FROM FROI_IMP_MAP_CONVERSION FIMC WHERE FIMC.FROI_IMP_MAP_ID = FROI_IMP_MAP.FROI_IMP_MAP_ID) AS CONV_COUNT ");
                sql.Append("FROM FROI_IMP_MAP, FROI_IMP_MAP_FUNCTION, FROI_IMP_FUNCTION ");
                sql.Append("WHERE FROI_IMP_MAP.FROI_IMP_MAP_ID = FROI_IMP_MAP_FUNCTION.FROI_IMP_MAP_ID(+) ");
                sql.Append("AND FROI_IMP_MAP_FUNCTION.FROI_IMP_FUNCTION_ID = FROI_IMP_FUNCTION.FROI_IMP_FUNCTION_ID(+) ");
                sql.AppendFormat("AND FROI_IMP_MAP.FROI_FILE_DEF_ID = {0} ", _fileDefId);
                sql.Append("AND STARTPOS IS NOT NULL ORDER BY STARTPOS");
            }
            else if (_fileDefId == 57)
            {
                sql.Append("SELECT FROI_IMP_MAP.FROI_IMP_MAP_ID, ATTRIBUTE_NAME, STARTPOS, LENGTH, FUNCTION_NAME, LEGACY_FIELD_NAME, DEFAULT_VALUE,FROI_IMP_RECORD_ID,FROI_IMP_RECORD_TYPE,");
                sql.Append("(SELECT count(*) FROM FROI_IMP_MAP_CONVERSION FIMC WHERE FIMC.FROI_IMP_MAP_ID = FROI_IMP_MAP.FROI_IMP_MAP_ID) AS CONV_COUNT ");
                sql.Append("FROM FROI_IMP_MAP, FROI_IMP_MAP_FUNCTION, FROI_IMP_FUNCTION ");
                sql.Append("WHERE FROI_IMP_MAP.FROI_IMP_MAP_ID = FROI_IMP_MAP_FUNCTION.FROI_IMP_MAP_ID(+) ");
                sql.Append("AND FROI_IMP_MAP_FUNCTION.FROI_IMP_FUNCTION_ID = FROI_IMP_FUNCTION.FROI_IMP_FUNCTION_ID(+) ");
                sql.AppendFormat("AND FROI_IMP_MAP.FROI_FILE_DEF_ID = {0} ", _fileDefId);
                sql.Append("AND STARTPOS IS NOT NULL ORDER BY FROI_IMP_RECORD_ID, STARTPOS, FROI_IMP_MAP_ID");
            }
            else
            {
                sql.Append("SELECT FROI_IMP_MAP.FROI_IMP_MAP_ID, ATTRIBUTE_NAME, STARTPOS, LENGTH, FUNCTION_NAME, DEFAULT_VALUE,FROI_IMP_RECORD_ID,FROI_IMP_RECORD_TYPE,");
                sql.Append("(SELECT count(*) FROM FROI_IMP_MAP_CONVERSION FIMC WHERE FIMC.FROI_IMP_MAP_ID = FROI_IMP_MAP.FROI_IMP_MAP_ID) AS CONV_COUNT ");
                sql.Append("FROM FROI_IMP_MAP, FROI_IMP_MAP_FUNCTION, FROI_IMP_FUNCTION ");
                sql.Append("WHERE FROI_IMP_MAP.FROI_IMP_MAP_ID = FROI_IMP_MAP_FUNCTION.FROI_IMP_MAP_ID(+) ");
                sql.Append("AND FROI_IMP_MAP_FUNCTION.FROI_IMP_FUNCTION_ID = FROI_IMP_FUNCTION.FROI_IMP_FUNCTION_ID(+) ");
                sql.AppendFormat("AND FROI_IMP_MAP.FROI_FILE_DEF_ID = {0} ", _fileDefId);
                sql.Append("AND STARTPOS IS NOT NULL ORDER BY FROI_IMP_RECORD_ID, STARTPOS, FROI_IMP_MAP_ID");
            }
            return sql.ToString();
        }
    }
}
#region Header
/**************************************************************************
 * First Notice Systems
 * 529 Main Street
 * Boston, MA 02129
 * (617) 886 2600
 *
 * Proprietary Source Code -- Distribution restricted
 *
 * Copyright (c) 1993-2005 by First Notice Systems
 **************************************************************************/
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/SPParameters.cs 6     4/08/11 8:39a Gwynnj $ */
#endregion
using System.Data;
using System.Runtime.InteropServices;

namespace DbClassLibrary
{
    /// <summary>
    /// generic stored procedure parameter storage class
    /// </summary>
    [ComVisible(false)]
    public class SpParameters
    {
        private string _value;
        private readonly string _defaultValue;

        #region Constructor
        /// <summary>
        /// SpParameters constructor
        /// </summary>
        /// <returns>SpParameters object</returns>
        /// <remarks>iDir 0=INPUT,1=OUTPUT,2=INOUT</remarks>
        public SpParameters(ParameterDirection iDir, string name, string defaultValue, DbType databaseType)
        {
            Direction = iDir;
            Name = name;
            DataType = databaseType;
            _defaultValue = defaultValue;
            _value = string.Empty;
        }
        #endregion

        #region Name

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        #endregion

        #region Value
        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>The value.</value>
        public string Value
        {
            get
            {
                return (_value.Length > 0) 
                ? _value
                : _defaultValue ?? "";
            }
            set
            {
                _value = value ?? "";
            }
        }
        #endregion

        #region DataType

        /// <summary>
        /// Gets or sets the type of the data.
        /// </summary>
        public DbType DataType { get; set; }

        #endregion

        #region Direction

        /// <summary>
        /// Gets or sets the direction.
        /// </summary>
        public ParameterDirection Direction { get; set; }

        #endregion
    }
}
#region Log
/*
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/SPParameters.cs $
 * 
 * 6     4/08/11 8:39a Gwynnj
 * adapted for setting of null to values
 * 
 * 5     9/10/10 2:45p Gwynnj
 * minor reformatting and added ToUpper for web loads
 * 
 * 4     5/26/09 11:05a John.gwynn
 * Added interop definitions
 * 
 * 3     4/19/07 4:36p John.gwynn
 * Added COM Interop support and begun work on Callflow data access
 * 
 * 2     4/17/07 4:52p John.gwynn
 * Update from 1.1 version
 * 
 * 3     11/15/06 5:33p John.gwynn
 * Added or updated comments for NDoc documentation
 * 
 * 2     11/16/05 6:21p John.gwynn
 * Added AHS
 * 
 * 1     11/15/05 6:41p John.gwynn
 */
#endregion
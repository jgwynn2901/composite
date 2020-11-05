namespace DbClassLibrary
{
    ///<summary>
    ///</summary>
	[System.Runtime.InteropServices.ComVisible(false)]
	public sealed class EsuranceDriver : DriverExtended
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EsuranceDriver"/> class.
        /// </summary>
        public EsuranceDriver()
            : this(DbBaseClass.ESUP)
        { }

        ///<summary>
        ///</summary>
        ///<param name="instance"></param>
        public EsuranceDriver(string instance)
            : base(instance)
        { }
    }
}

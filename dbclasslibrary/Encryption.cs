using System;
using System.Data;

namespace DbClassLibrary
{
  public class Encryption : DbBaseClass
  {
    #region Constructor
		/// <summary>
    /// Initializes a new instance of the <see cref="Encryption"/> class.
		/// </summary>
		public Encryption() :this (String.Empty)
		{
		}
		/// <summary>
    /// Initializes a new instance of the <see cref="Encryption"/> class.
		/// </summary>
		/// <param name="instance"></param>
    public Encryption(string instance)
      : base(instance)
		{
			_name = "gen_encr.encrypt";
			Initialize();
		}
		#endregion
		#region Initialize
		/// <summary>
		/// Set up parameter definitions here
		/// </summary>
		/// <remarks>
		/// the definitions can be defined externally (configuration) 
		/// and iterated here for maximum flexibility
		/// </remarks>
		protected override sealed void Initialize()
		{
			///////////////////////////////////////////////////
			/////sender
			///////////////////////////////////////////////////
			AddParm(ParameterDirection.ReturnValue,
				"RETURN","", DbType.AnsiString);
			///////////////////////////////////////////////////
			/////recipient
			///////////////////////////////////////////////////
			AddParm(ParameterDirection.Input,
        "v_varchar", "", DbType.AnsiString);
    }
		#endregion
    #region Value
    /// <summary>
    /// message property
    /// </summary>
    public string Value
    {
      get
      {
        return GetValue("v_varchar");
      }
      set
      {
        SetValue("v_varchar", value);
      }
    }

    public string Encrypt
    {
      get
      {
        return GetValue("RETURN");
      }
    }
    #endregion
  }
}

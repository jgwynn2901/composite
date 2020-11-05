using System;
using System.Data;

namespace DbClassLibrary
{
  public class Decryption : DbBaseClass
  {
    #region Constructor
		/// <summary>
    /// Initializes a new instance of the <see cref="Decryption"/> class.
		/// </summary>
		public Decryption() :this (String.Empty)
		{
		}
		/// <summary>
    /// Initializes a new instance of the <see cref="Decryption"/> class.
		/// </summary>
		/// <param name="instance"></param>
    public Decryption(string instance)
      : base(instance)
		{
      _name = "gen_encr.decrypt";
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
        "v_raw", "", DbType.AnsiString);
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
        return GetValue("v_raw");
      }
      set
      {
        SetValue("v_raw", value);
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

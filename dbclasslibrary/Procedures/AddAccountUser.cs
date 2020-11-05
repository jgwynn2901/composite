using System;

namespace DbClassLibrary.Procedures
{
  public class AddAccountUser : DbBaseClass
  {
    // ReSharper disable InconsistentNaming
    private enum eParmList
    {
      StrAcctID = 0,
      StrUserID,
      StatusMsg,
      StatusNum
    };
    // ReSharper restore InconsistentNaming
    
    public AddAccountUser() : this(String.Empty) {}
		/// <summary>
    /// Initializes a new instance of the <see cref="SearchAhsNode"/> class.
		/// </summary>
		/// <param name="instance"></param>
    public AddAccountUser(string instance)
      : base(instance)
		{
      _name = "DBCLASSLIBRARY.AddAccountUser";
			Initialize();
		}

    protected override sealed void Initialize()
    {
      ///////////////////////////////////////////////////
      ///// StrAcctID
      ///////////////////////////////////////////////////
      AddParm(System.Data.ParameterDirection.Input,
        eParmList.StrAcctID.ToString(), "", System.Data.DbType.AnsiString);
      ///////////////////////////////////////////////////
      ///// StrUserID
      ///////////////////////////////////////////////////
      AddParm(System.Data.ParameterDirection.Input,
        eParmList.StrUserID.ToString(), "", System.Data.DbType.AnsiString);
      ///////////////////////////////////////////////////
      ///// StatusMsg
      ///////////////////////////////////////////////////
      AddParm(System.Data.ParameterDirection.Output,
        eParmList.StatusMsg.ToString(), "", System.Data.DbType.AnsiString);
      ///////////////////////////////////////////////////
      ///// StatusNum
      ///////////////////////////////////////////////////
      AddParm(System.Data.ParameterDirection.Output,
        eParmList.StatusNum.ToString(), "", System.Data.DbType.Int32);
    }

    public string AccountId
    {
      get { return GetValue(eParmList.StrAcctID.ToString()); }
      set { SetValue(eParmList.StrAcctID.ToString(), value); }
    }
    public string UserId
    {
      get { return GetValue(eParmList.StrUserID.ToString()); }
      set { SetValue(eParmList.StrUserID.ToString(), value); }
    }
    public string StatusMessage
    {
      get { return GetValue(eParmList.StatusMsg.ToString()); }
    }
    public string StatusNumber
    {
      get { return GetValue(eParmList.StatusNum.ToString()); }
    }
  }
}

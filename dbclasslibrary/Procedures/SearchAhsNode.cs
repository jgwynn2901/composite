using System;

namespace DbClassLibrary.Procedures
{
  public class SearchAhsNodeUp : SearchAhsNode
  {
    public SearchAhsNodeUp() : this(String.Empty) { }
    public SearchAhsNodeUp(string instance)
      : base(instance)
		{
      _name = "DBCLASSLIBRARY.SrchAHSNodesUpTreeSQL";
		}
  }
  public class SearchAhsNode : DbBaseClass
  {
    // ReSharper disable InconsistentNaming
    private enum eParmList
    {
      inAtAHSID = 0,
      inAHSID,
      inAHSName,
      inAddress1,
      inCity,
      inState,
      inZip,
      inLocationCode,
      inUserID,
      inSrchType,
      results
    };
    // ReSharper restore InconsistentNaming

    public SearchAhsNode() : this(String.Empty) {}
		/// <summary>
    /// Initializes a new instance of the <see cref="SearchAhsNode"/> class.
		/// </summary>
		/// <param name="instance"></param>
    public SearchAhsNode(string instance)
      : base(instance)
		{
      _name = "DBCLASSLIBRARY.SrchAHSNodesDownTreeSql";
			Initialize();
		}

    protected override sealed void Initialize()
    {
      ///////////////////////////////////////////////////
      ///// inAtAHSID
      ///////////////////////////////////////////////////
      AddParm(System.Data.ParameterDirection.Input,
        eParmList.inAtAHSID.ToString(), "", System.Data.DbType.Int32);
      ///////////////////////////////////////////////////
      ///// inAHSID
      ///////////////////////////////////////////////////
      AddParm(System.Data.ParameterDirection.Input,
        eParmList.inAHSID.ToString(), "", System.Data.DbType.Int32);
      ///////////////////////////////////////////////////
      ///// inAHSName
      ///////////////////////////////////////////////////
      AddParm(System.Data.ParameterDirection.Input,
        eParmList.inAHSName.ToString(), "", System.Data.DbType.AnsiString);
      ///////////////////////////////////////////////////
      ///// inAddress1
      ///////////////////////////////////////////////////
      AddParm(System.Data.ParameterDirection.Input,
        eParmList.inAddress1.ToString(), "", System.Data.DbType.AnsiString);
      ///////////////////////////////////////////////////
      ///// inCity
      ///////////////////////////////////////////////////
      AddParm(System.Data.ParameterDirection.Input,
        eParmList.inCity.ToString(),"",System.Data.DbType.AnsiString);
      ///////////////////////////////////////////////////
      ///// inState
      ///////////////////////////////////////////////////
      AddParm(System.Data.ParameterDirection.Input,
        eParmList.inState.ToString(), "", System.Data.DbType.AnsiString);
      ///////////////////////////////////////////////////
      ///// inZip
      ///////////////////////////////////////////////////
      AddParm(System.Data.ParameterDirection.Input,
        eParmList.inZip.ToString(), "", System.Data.DbType.AnsiString);
      ///////////////////////////////////////////////////
      ///// inLocationCode
      ///////////////////////////////////////////////////
      AddParm(System.Data.ParameterDirection.Input,
        eParmList.inLocationCode.ToString(), "", System.Data.DbType.AnsiString);
      ///////////////////////////////////////////////////
      ///// inUserID
      ///////////////////////////////////////////////////
      AddParm(System.Data.ParameterDirection.Input,
        eParmList.inUserID.ToString(), "", System.Data.DbType.Int32);
      ///////////////////////////////////////////////////
      ///// inSrchType
      ///////////////////////////////////////////////////
      AddParm(System.Data.ParameterDirection.Input,
        eParmList.inSrchType.ToString(), "", System.Data.DbType.Int32);
      ///////////////////////////////////////////////////
      ///// results
      ///////////////////////////////////////////////////
      AddParm(System.Data.ParameterDirection.Output,
        eParmList.results.ToString(), "", System.Data.DbType.AnsiString);
    }
    public string AtAhsId
    {
      get { return GetValue(eParmList.inAtAHSID.ToString()); }
      set { SetValue(eParmList.inAtAHSID.ToString(), value); }
    }
    public string InAhsId
    {
      get { return GetValue(eParmList.inAHSID.ToString()); }
      set { SetValue(eParmList.inAHSID.ToString(), value); }
    }
    public string InAhsName
    {
      get { return GetValue(eParmList.inAHSName.ToString()); }
      set { SetValue(eParmList.inAHSName.ToString(), value); }
    }
    public string InAddress1
    {
      get { return GetValue(eParmList.inAddress1.ToString()); }
      set { SetValue(eParmList.inAddress1.ToString(), value); }
    }
    public string InCity
    {
      get { return GetValue(eParmList.inCity.ToString()); }
      set { SetValue(eParmList.inCity.ToString(), value); }
    }
    public string InState
    {
      get { return GetValue(eParmList.inState.ToString()); }
      set { SetValue(eParmList.inState.ToString(), value); }
    }
    public string InZip
    {
      get { return GetValue(eParmList.inZip.ToString()); }
      set { SetValue(eParmList.inZip.ToString(), value); }
    }
    public string InLocationCode
    {
      get { return GetValue(eParmList.inLocationCode.ToString()); }
      set { SetValue(eParmList.inLocationCode.ToString(), value); }
    }
    public string InUserId
    {
      get { return GetValue(eParmList.inUserID.ToString()); }
      set { SetValue(eParmList.inUserID.ToString(), value); }
    }
    public string InSrchType
    {
      get { return GetValue(eParmList.inSrchType.ToString()); }
      set { SetValue(eParmList.inSrchType.ToString(), value); }
    }
    public string ResultSql
    {
      get { return GetValue(eParmList.results.ToString()); }
    }
  }
}

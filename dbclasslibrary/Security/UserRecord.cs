using System;

namespace DbClassLibrary.Security
{
  public class UserRecord : DbBaseClass
  {
// ReSharper disable InconsistentNaming
    private enum eParmList
    {
      inOperation,
      inUserId,
      inSiteId,
      inActive,
      inReuse,
      inLastName,
      inFirstName,
      inName,
      inPassword,
      inAddressLine1,
      inAddressLine2,
      inCity,
      inState,
      inZipCode,
      inPhoneWork,
      inPhoneWorkExtension,
      inFaxNumber,
      inEmailAddress,
      inCallerType,
      inCallerDepartment,
      inSupervisorName,
      inSupervisorPhoneWork,
      inSupervisorPhoneExtension,
      inActiveStartDate,
      inActiveEndDate,
      inPasswordExpirationDate,
      inNewUser,
      inInternetUser,
      inLockoutFlag
    }
    #region Constructor
    /// <summary>
    /// Initializes a new instance of the <see cref="Contact"/> class.
    /// </summary>
    public UserRecord() : this(String.Empty) { }

    /// <summary>
    /// Initializes a new instance of the <see cref="Contact"/> class.
    /// </summary>
    /// <param name="instance"></param>
    public UserRecord(string instance)
      : base(instance)
    {
      _name = "sp_manage_user";
      Initialize();
    }
    #endregion
    protected override sealed void Initialize()
    {
      ///////////////////////////////////////////////////
      //// inOperation
      ///////////////////////////////////////////////////
      AddParm(System.Data.ParameterDirection.Input,
              eParmList.inOperation.ToString(), "", System.Data.DbType.AnsiString);
      ///////////////////////////////////////////////////
      //// inUserId
      ///////////////////////////////////////////////////
      AddParm(System.Data.ParameterDirection.Input,
              eParmList.inUserId.ToString(), "", System.Data.DbType.AnsiString);
      ///////////////////////////////////////////////////
      //// inSiteId
      ///////////////////////////////////////////////////
      AddParm(System.Data.ParameterDirection.Input,
              eParmList.inSiteId.ToString(), "", System.Data.DbType.AnsiString);
      ///////////////////////////////////////////////////
      //// inActive
      ///////////////////////////////////////////////////
      AddParm(System.Data.ParameterDirection.Input,
              eParmList.inActive.ToString(), "", System.Data.DbType.AnsiString);
      ///////////////////////////////////////////////////
      //// inReuse
      ///////////////////////////////////////////////////
      AddParm(System.Data.ParameterDirection.Input,
              eParmList.inReuse.ToString(), "", System.Data.DbType.AnsiString);
      ///////////////////////////////////////////////////
      //// inLastName
      ///////////////////////////////////////////////////
      AddParm(System.Data.ParameterDirection.Input,
              eParmList.inLastName.ToString(), "", System.Data.DbType.AnsiString);
      ///////////////////////////////////////////////////
      //// inFirstName
      ///////////////////////////////////////////////////
      AddParm(System.Data.ParameterDirection.Input,
              eParmList.inFirstName.ToString(), "", System.Data.DbType.AnsiString);
      ///////////////////////////////////////////////////
      //// inName
      ///////////////////////////////////////////////////
      AddParm(System.Data.ParameterDirection.Input,
              eParmList.inName.ToString(), "", System.Data.DbType.AnsiString);
      ///////////////////////////////////////////////////
      //// inPassword
      ///////////////////////////////////////////////////
      AddParm(System.Data.ParameterDirection.Input,
              eParmList.inPassword.ToString(), "", System.Data.DbType.AnsiString);
      ///////////////////////////////////////////////////
      //// inAddressLine1
      ///////////////////////////////////////////////////
      AddParm(System.Data.ParameterDirection.Input,
              eParmList.inAddressLine1.ToString(), "", System.Data.DbType.AnsiString);
      ///////////////////////////////////////////////////
      //// inAddressLine2
      ///////////////////////////////////////////////////
      AddParm(System.Data.ParameterDirection.Input,
              eParmList.inAddressLine2.ToString(), "", System.Data.DbType.AnsiString);
      ///////////////////////////////////////////////////
      //// inCity
      ///////////////////////////////////////////////////
      AddParm(System.Data.ParameterDirection.Input,
              eParmList.inCity.ToString(), "", System.Data.DbType.AnsiString);
      ///////////////////////////////////////////////////
      //// inState
      ///////////////////////////////////////////////////
      AddParm(System.Data.ParameterDirection.Input,
              eParmList.inState.ToString(), "", System.Data.DbType.AnsiString);
      ///////////////////////////////////////////////////
      //// inZipCode
      ///////////////////////////////////////////////////
      AddParm(System.Data.ParameterDirection.Input,
              eParmList.inZipCode.ToString(), "", System.Data.DbType.AnsiString);
      ///////////////////////////////////////////////////
      //// inPhoneWork
      ///////////////////////////////////////////////////
      AddParm(System.Data.ParameterDirection.Input,
              eParmList.inPhoneWork.ToString(), "", System.Data.DbType.AnsiString);
      ///////////////////////////////////////////////////
      //// inPhoneWorkExtension
      ///////////////////////////////////////////////////
      AddParm(System.Data.ParameterDirection.Input,
              eParmList.inPhoneWorkExtension.ToString(), "", System.Data.DbType.AnsiString);
      ///////////////////////////////////////////////////
      //// inFaxNumber
      ///////////////////////////////////////////////////
      AddParm(System.Data.ParameterDirection.Input,
              eParmList.inFaxNumber.ToString(), "", System.Data.DbType.AnsiString);
      ///////////////////////////////////////////////////
      //// inEmailAddress
      ///////////////////////////////////////////////////
      AddParm(System.Data.ParameterDirection.Input,
              eParmList.inEmailAddress.ToString(), "", System.Data.DbType.AnsiString);
      ///////////////////////////////////////////////////
      //// inCallerType
      ///////////////////////////////////////////////////
      AddParm(System.Data.ParameterDirection.Input,
              eParmList.inCallerType.ToString(), "", System.Data.DbType.AnsiString);
      ///////////////////////////////////////////////////
      //// inCallerDepartment
      ///////////////////////////////////////////////////
      AddParm(System.Data.ParameterDirection.Input,
              eParmList.inCallerDepartment.ToString(), "", System.Data.DbType.AnsiString);
      ///////////////////////////////////////////////////
      //// inSupervisorName
      ///////////////////////////////////////////////////
      AddParm(System.Data.ParameterDirection.Input,
              eParmList.inSupervisorName.ToString(), "", System.Data.DbType.AnsiString);
      ///////////////////////////////////////////////////
      //// inSupervisorPhoneWork
      ///////////////////////////////////////////////////
      AddParm(System.Data.ParameterDirection.Input,
              eParmList.inSupervisorPhoneWork.ToString(), "", System.Data.DbType.AnsiString);
      ///////////////////////////////////////////////////
      //// inSupervisorPhoneExtension
      ///////////////////////////////////////////////////
      AddParm(System.Data.ParameterDirection.Input,
              eParmList.inSupervisorPhoneExtension.ToString(), "", System.Data.DbType.AnsiString);
      ///////////////////////////////////////////////////
      //// inActiveStartDate
      ///////////////////////////////////////////////////
      AddParm(System.Data.ParameterDirection.Input,
              eParmList.inActiveStartDate.ToString(), "", System.Data.DbType.AnsiString);
      ///////////////////////////////////////////////////
      //// inActiveEndDate
      ///////////////////////////////////////////////////
      AddParm(System.Data.ParameterDirection.Input,
              eParmList.inActiveEndDate.ToString(), "", System.Data.DbType.AnsiString);
      ///////////////////////////////////////////////////
      //// inPasswordExpirationDate
      ///////////////////////////////////////////////////
      AddParm(System.Data.ParameterDirection.Input,
              eParmList.inPasswordExpirationDate.ToString(), "", System.Data.DbType.AnsiString);
      ///////////////////////////////////////////////////
      //// inNewUser
      ///////////////////////////////////////////////////
      AddParm(System.Data.ParameterDirection.Input,
              eParmList.inNewUser.ToString(), "", System.Data.DbType.AnsiString);
      ///////////////////////////////////////////////////
      //// inInternetUser
      ///////////////////////////////////////////////////
      AddParm(System.Data.ParameterDirection.Input,
              eParmList.inInternetUser.ToString(), "", System.Data.DbType.AnsiString);
      ///////////////////////////////////////////////////
      //// inLockoutFlag
      ///////////////////////////////////////////////////
      AddParm(System.Data.ParameterDirection.Input,
              eParmList.inLockoutFlag.ToString(), "", System.Data.DbType.AnsiString);
    }

    public string Operation
    {
      get
      {
        return GetValue(eParmList.inOperation.ToString());
      }
      set
      {
        SetValue(eParmList.inOperation.ToString(), value);
      }
    }
    public string UserId
    {
      get
      {
        return GetValue(eParmList.inUserId.ToString());
      }
      set
      {
        SetValue(eParmList.inUserId.ToString(), value);
      }
    }
    public string SiteId
    {
      get
      {
        return GetValue(eParmList.inSiteId.ToString());
      }
      set
      {
        SetValue(eParmList.inSiteId.ToString(), value);
      }
    }
    public string ActiveFlag
    {
      get
      {
        return GetValue(eParmList.inActive.ToString());
      }
      set
      {
        SetValue(eParmList.inActive.ToString(), value);
      }
    }
    public string ReuseFlag
    {
      get
      {
        return GetValue(eParmList.inReuse.ToString());
      }
      set
      {
        SetValue(eParmList.inReuse.ToString(), value);
      }
    }
    public string LastName
    {
      get
      {
        return GetValue(eParmList.inLastName.ToString());
      }
      set
      {
        SetValue(eParmList.inLastName.ToString(), value);
      }
    }
    public string FirstName
    {
      get
      {
        return GetValue(eParmList.inFirstName.ToString());
      }
      set
      {
        SetValue(eParmList.inFirstName.ToString(), value);
      }
    }
    public string UserName
    {
      get
      {
        return GetValue(eParmList.inName.ToString());
      }
      set
      {
        SetValue(eParmList.inName.ToString(), value);
      }
    }

    public string Password
    {
      get
      {
        return GetValue(eParmList.inPassword.ToString());
      }
      set
      {
        SetValue(eParmList.inPassword.ToString(), value);
      }
    }
    public string AddressLine1
    {
      get
      {
        return GetValue(eParmList.inAddressLine1.ToString());
      }
      set
      {
        SetValue(eParmList.inAddressLine1.ToString(), value);
      }
    }
    public string AddressLine2
    {
      get
      {
        return GetValue(eParmList.inAddressLine2.ToString());
      }
      set
      {
        SetValue(eParmList.inAddressLine2.ToString(), value);
      }
    }
    public string City
    {
      get
      {
        return GetValue(eParmList.inCity.ToString());
      }
      set
      {
        SetValue(eParmList.inCity.ToString(), value);
      }
    }
    public string State
    {
      get
      {
        return GetValue(eParmList.inState.ToString());
      }
      set
      {
        SetValue(eParmList.inState.ToString(), value);
      }
    }
    public string ZipCode
    {
      get
      {
        return GetValue(eParmList.inZipCode.ToString());
      }
      set
      {
        SetValue(eParmList.inZipCode.ToString(), value);
      }
    }
    public string PhoneWork
    {
      get
      {
        return GetValue(eParmList.inPhoneWork.ToString());
      }
      set
      {
        SetValue(eParmList.inPhoneWork.ToString(), value);
      }
    }
    public string PhoneWorkExtension
    {
      get
      {
        return GetValue(eParmList.inPhoneWorkExtension.ToString());
      }
      set
      {
        SetValue(eParmList.inPhoneWorkExtension.ToString(), value);
      }
    }
    public string FaxNumber
    {
      get
      {
        return GetValue(eParmList.inFaxNumber.ToString());
      }
      set
      {
        SetValue(eParmList.inFaxNumber.ToString(), value);
      }
    }
    public string EmailAddress
    {
      get
      {
        return GetValue(eParmList.inEmailAddress.ToString());
      }
      set
      {
        SetValue(eParmList.inEmailAddress.ToString(), value);
      }
    }
    public string CallerType
    {
      get
      {
        return GetValue(eParmList.inCallerType.ToString());
      }
      set
      {
        SetValue(eParmList.inCallerType.ToString(), value);
      }
    }
    public string CallerDepartment
    {
      get
      {
        return GetValue(eParmList.inCallerDepartment.ToString());
      }
      set
      {
        SetValue(eParmList.inCallerDepartment.ToString(), value);
      }
    }
    public string SupervisorName
    {
      get
      {
        return GetValue(eParmList.inSupervisorName.ToString());
      }
      set
      {
        SetValue(eParmList.inSupervisorName.ToString(), value);
      }
    }
    public string SupervisorPhoneWork
    {
      get
      {
        return GetValue(eParmList.inSupervisorPhoneWork.ToString());
      }
      set
      {
        SetValue(eParmList.inSupervisorPhoneWork.ToString(), value);
      }
    }
    public string SupervisorPhoneExtension
    {
      get
      {
        return GetValue(eParmList.inSupervisorPhoneExtension.ToString());
      }
      set
      {
        SetValue(eParmList.inSupervisorPhoneExtension.ToString(), value);
      }
    }
    public string ActiveStartDate
    {
      get
      {
        return GetValue(eParmList.inActiveStartDate.ToString());
      }
      set
      {
        SetValue(eParmList.inActiveStartDate.ToString(), value);
      }
    }
    public string ActiveEndDate
    {
      get
      {
        return GetValue(eParmList.inActiveEndDate.ToString());
      }
      set
      {
        SetValue(eParmList.inActiveEndDate.ToString(), value);
      }
    }
    public string PasswordExpirationDate
    {
      get
      {
        return GetValue(eParmList.inPasswordExpirationDate.ToString());
      }
      set
      {
        SetValue(eParmList.inPasswordExpirationDate.ToString(), value);
      }
    }
    public string NewUserFlag
    {
      get
      {
        return GetValue(eParmList.inNewUser.ToString());
      }
      set
      {
        SetValue(eParmList.inNewUser.ToString(), value);
      }
    }
    public string InternetUserFlag
    {
      get
      {
        return GetValue(eParmList.inInternetUser.ToString());
      }
      set
      {
        SetValue(eParmList.inInternetUser.ToString(), value);
      }
    }
    public string LockoutFlag
    {
      get
      {
        return GetValue(eParmList.inLockoutFlag.ToString());
      }
      set
      {
        SetValue(eParmList.inLockoutFlag.ToString(), value);
      }
    }
  }
}

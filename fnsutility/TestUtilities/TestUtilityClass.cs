using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;
using FnsComposite;
using FnsComposite.CallObjects;
using FnsUtility;
using NUnit.Framework;
using NUnit.Framework.Internal;
using Test = NUnit.Framework;

namespace TestUtilities
{
  [TestFixture]
  public class TestUtilityClass
  {
    /// <summary>
    /// NUNIT Tests the XML transform.
    /// </summary>
    [Test, Ignore("Obsolete")]
    public void TestXmlTransform()
    {
      const string strSourceXml = @"C:\Documents and Settings\john.gwynn\My Documents\ISO\DF01C3B2-F3C3-47E8-BF95-000002055243.xml";
      const string strSourceXsl = @"C:\Documents and Settings\john.gwynn\My Documents\ISO\CS_Xml_Output.xsl";
      var strHtmlResults = XmlUtility.GetStringXslTransform(strSourceXml, strSourceXsl);
      if (strHtmlResults == null) throw new NotImplementedException();
      Test.Assert.IsTrue(strHtmlResults.Length > 0);
      Console.WriteLine(strHtmlResults);
    }
    /// <summary>
    /// NUNIT Tests the get db instance from registry.
    /// </summary>
    [Test]
    public void TestGetDbInstanceFromRegistry()
    {
      var strResults = GeneralUtility.InstanceFromRegistry;
      Test.Assert.IsTrue(strResults.Length > 0);
      Console.WriteLine(strResults);
      Console.WriteLine("IsSedgwick: {0}", GeneralUtility.IsSedgewick);

    }
    /// <summary>
    /// NUNIT Tests the mail trace listener.
    /// </summary>
    [Test]
    public void TestMailTraceListener()
    {
      var errorMessage = String.Format("Selective Claim Service Submit failed with the following exception:\r\n\r\n{0}",
                                          "This is a [TEST] error\r\n");

      using (var listener = new EmailTraceListener("DISPFAIL_EMAIL"))
      {
        listener.Write(String.Format("Instance: {0}, CallID: {1}, Source Machine {2}.\r\n",
            GeneralUtility.InstanceFromRegistry,
            "000000007",
            GeneralUtility.MachineName));
        listener.WriteLine(errorMessage);
        listener.Close();
      }
    }

    [Test]
    public void TestEmailAddress()
    {
      Test.Assert.IsTrue(GeneralUtility.IsValidEmail("john@test.com"));
      Test.Assert.IsFalse(GeneralUtility.IsValidEmail("UNK2"));
    }
    /// <summary>
    /// NUNIT Tests the vehicle lookup.
    /// </summary>
    [Test, Ignore("Obsolete")]
    public void TestVehicleLookup()
    {
      var results = VehicleLookup.DoLookup(14593754);
      Test.Assert.IsTrue(results.Length > 0, "VehicleLookup failed!");
      Console.WriteLine(results);
    }
    /// <summary>
    /// NUNIT Tests the pop DSN.
    /// </summary>
    [Test]
    public void TestPopDsn()
    {
      var config = new FnsConfigurationMgr();

      var originalInstance = GeneralUtility.InstanceFromRegistry;
      Test.Assert.IsNotEmpty(originalInstance, "Instance resolves to null");
      config.PushDns("SENP");
      string currentInstance = GeneralUtility.InstanceFromRegistry;
      Test.Assert.IsFalse(currentInstance.Equals(originalInstance),
                              String.Format("PushDsn failed, original {0} is equal to current {1}", originalInstance, currentInstance));
      config.PopDns();
      var finalInstance = GeneralUtility.InstanceFromRegistry;
      Test.Assert.IsTrue(originalInstance.Equals(finalInstance),
          String.Format("PushDsn failed, {0} is not equal to final {1}", originalInstance, finalInstance));
    }
    /// <summary>
    /// NUNIT Tests the send mercury email.
    /// </summary>
    [Test]
    public void TestSendMercuryEmail()
    {
      MailManager.SendTypeEmail("FnsUtilityTest@firstNotice.com", "This is the subject of a test!", "This is the body of the test!", "TEST");
    }

    /// <summary>
    /// NUNIT Tests the app settings.
    /// </summary>
    [Test]
    public void TestAppSettings()
    {
      var config = new FnsConfigurationMgr();

      Console.WriteLine("==========Default");
      for (var i = 0; i < config.AppSettings.Count; ++i)
      {
        Console.WriteLine(String.Format("NAME={0}\tVALUE={1}", config.AppSettings.GetKey(i), config.AppSettings[i]));
      }
      Console.WriteLine("==========Selective");
      var config2 = new FnsConfigurationMgr("SelectiveWebConnect.config");

      for (var i = 0; i < config2.AppSettings.Count; ++i)
      {
        Console.WriteLine(String.Format("NAME={0}\tVALUE={1}", config2.AppSettings.GetKey(i), config2.AppSettings[i]));
      }
      Test.Assert.IsNull(config2.AppSettings["UNKNOWN"], "Does Not returns NULLS!!!");
    }
    /// <summary>
    /// NUNIT Tests the XML encryption.
    /// </summary>
    [Test, Ignore("Obsolete")]
    public void TestXmlEncryption()
    {
      var testResponse = XmlUtility.LoadFileText(@"C:\Documents and Settings\john.gwynn\My Documents\CSAA_Response.xml");
      Test.Assert.IsTrue(testResponse.Length > 0, "could not load file");
      var results = XmlUtility.EncryptXmlFields(testResponse, "102", "PAU", "RESPONSE", false);
      Test.Assert.IsTrue(results.Length > 0, "Nothing was returned");

      Console.WriteLine(results);
      Console.WriteLine("********");
    }
    /// <summary>
    /// NUNIT Tests the XML decryption.
    /// </summary>
    [Test, Ignore("Obsolete")]
    public void TestXmlDecryption()
    {
      string testResponse = XmlUtility.LoadFileText(@"C:\Documents and Settings\john.gwynn\My Documents\CSAA_ResponseEncrypted.xml");
      Test.Assert.IsTrue(testResponse.Length > 0, "could not load file");
      string results = XmlUtility.EncryptXmlFields(testResponse, "102", "PAU", "RESPONSE", true);
      Test.Assert.IsTrue(results.Length > 0, "Nothing was returned");

      Console.WriteLine(results);
      Console.WriteLine("********");
    }
    /// <summary>
    /// NUNIT Tests the message queue.
    /// </summary>
    [Test, Ignore("Obsolete")]
    public void TestMessageQueue()
    {
      var queue = String.Format("FormatName:DIRECT=OS:{0}\\policy_ipm", GeneralUtility.MachineName);

      var loaderXml = XmlUtility.LoadFileText(@"C:\Documents and Settings\john.gwynn\My Documents\policyLoad.xml");
      Test.Assert.IsNotEmpty(loaderXml, "policy loader is empty!");

      var loader = new PolicyLoader(loaderXml);
      Test.Assert.IsNotEmpty(loader.Action, "Loader failed!");

      Console.WriteLine(String.Format("PolicyLoader.Action = {0}", loader.Action));
      Console.WriteLine(String.Format("PolicyLoader.ClientCode = {0}", loader.ClientCode));
      Console.WriteLine(String.Format("PolicyLoader.CreatTime = {0}", loader.CreatTime));
      Console.WriteLine(String.Format("PolicyLoader.FileName = {0}", loader.FileName));
      Console.WriteLine(String.Format("PolicyLoader.FileTranLogId = {0}", loader.FileTranLogId));
      Console.WriteLine(String.Format("PolicyLoader.Sequence = {0}", loader.Sequence));
      Console.WriteLine(String.Format("PolicyLoader.Status = {0}", loader.Status));
      Console.WriteLine("***Sending Message....");
      var message = loader.ToXml();

      Test.Assert.IsTrue(MessageQueue.SendMessage(queue, message, loader.Name), "send failed!");
      /*
      Console.WriteLine("***Retrieving Message....");
      string results = MessageQueue.GetNextMessage(queue);
      Test.Assert.IsTrue(results.Length > 0, "Nothing was returned");
      Test.Assert.IsTrue(message.Equals(results),"results don't compare...");
      Console.WriteLine(results);
      */
    }
    /// <summary>
    /// NUNIT Tests the policy loader.
    /// </summary>
    [Test, Ignore("Obsolete")]
    public void TestPolicyLoader()
    {
      const string queue = @"FormatName:DIRECT=OS:CHA1ND110\policy_ipm";
      var results = MessageQueue.GetNextMessage(queue);
      Test.Assert.IsNotEmpty(results, "No data returned!");
      Console.WriteLine(results);
    }
    /// <summary>
    /// Tests the get DSN from instance.
    /// </summary>
    [Test]
    public void TestGetDsnFromInstance()
    {
      string[] instances = { "CISGPP","FNSPP", "CISGBA", "CRAWQA", "SEDPP", "SEDP", "SEDBA", "CISG",
					"FNSQA", "FNSP", "ESUPP","ESUP","SELPP","SEDBA","CISGQA" };

      foreach (var instance in instances)
      {
        var result = GeneralUtility.GetDsnFromInstance(instance);
        Test.Assert.IsTrue(result.IndexOf("PWD=;", StringComparison.Ordinal) == -1, string.Format("DsnFromInstance({0}) failed!", instance));
        Console.WriteLine(result);
      }
    }
    /// <summary>
    /// Tests the error log delegate.
    /// </summary>
    [Test]
    public void TestErrorLogDelegate()
    {
      const string instance = "SEDBA";
      ErrorLog.LogErrorInstance(instance)("This is a test!", "CurriedLogEditor");

      var logger = ErrorLog.LogErrorInstance(instance);
      logger("This is another test!", "TestErrorLogDelegate");
    }
    /// <summary>
    /// Tests the calling method.
    /// </summary>
    [Test]
    public void TestCallingMethod()
    {
      var method = new CallingMethod();
      Console.WriteLine("\nFileName={0}", method.FileName);
      Console.WriteLine("FilePath={0}", method.FilePath);
      Console.WriteLine("LineNumber={0}", method.LineNumber);
      Console.WriteLine("MethodName={0}", method.MethodName);
      Console.WriteLine("MethodNameFull={0}", method.MethodNameFull);
      Console.WriteLine("MethodSignature={0}", method.MethodSignature);
      Console.WriteLine("MethodSignatureFull={0}", method.MethodSignatureFull);
      Console.WriteLine("Namespace={0}", method.Namespace);
      Console.WriteLine("ReturnName={0}", method.ReturnName);
      Console.WriteLine("MediaTypeNames.Text={0}", method.Text);
      Console.WriteLine("TypeName={0}", method.TypeName);
      Console.WriteLine("TypeNameFull={0}", method.TypeNameFull);

      ErrorLog.LogError("This is a unit test -ignore", method, "FNSBA");
    }
    /// <summary>
    /// Tests the encrypt decrypt.
    /// </summary>
    [Test]
    public void TestEncryptDecrypt()
    {
      const string symmProvider = "CallDataKey";
      const string test = "THIS IS A TEST!";
      var encryptTest = GeneralUtility.EncryptValue(symmProvider, test);
      Test.Assert.IsTrue(encryptTest != test, "Encryption Failed (check error log)");
      var decyptTest = GeneralUtility.DecryptValue(symmProvider, encryptTest);
      Test.Assert.IsTrue(decyptTest == test, "Decryption Failed (check error log)");
    }
    /// <summary>
    /// Tests the CSA encrypt decrypt.
    /// </summary>
    [Test]
    public void TestCsaEncryptDecrypt()
    {
      const string symmProvider = "CallDataKey";
      const string test = "THIS IS A TEST!";
      var encryptTest = GeneralUtility.EncryptValue(symmProvider, test);
      Test.Assert.IsNotEmpty(encryptTest, "Encryption Failed (check error log)");
      var decyptTest = GeneralUtility.DecryptValue(symmProvider, encryptTest);
      Test.Assert.IsNotEmpty(decyptTest, "Decryption Failed (check error log)");
      Test.Assert.IsFalse(test.Equals(encryptTest), "Results are equal!");
      Console.WriteLine("Value: {0} Encrypt: {1} Decrypt: {2}", test, encryptTest, decyptTest);
      Test.Assert.IsTrue(test.Equals(decyptTest), "results do not match!");
    }
    /// <summary>
    /// Tests the date formats.
    /// </summary>
    [Test]
    public void TestDateFormats()
    {
      const string lossDate = "02022008";

      Console.WriteLine(XmlUtility.FormatCallDateToSoap(lossDate));
      Console.WriteLine(XmlUtility.FormatCallDate(XmlUtility.FormatCallDateToSoap(lossDate), "DateTime"));
      Console.WriteLine(XmlUtility.FormatCallDate(XmlUtility.FormatCallDateToSoap(lossDate), "DateTimeZone"));
      Console.WriteLine(XmlUtility.FormatCallDate(XmlUtility.FormatCallDateToSoap(lossDate), "Date"));
      Console.WriteLine(Date.FormatCallDateString(lossDate));


    }
    /// <summary>
    /// Tests the execute service method.
    /// </summary>
    [Test]
    public void TestExecuteServiceMethod()
    {
      var call = new CallObject
      {
        SessionKey = "BJdRMaB+4lZMa8ClLdCGrejStSRXZ2kEacSTppLvwHLWpmBCFmtyX5ViO6DJBRgO"
      };

      call.SetValue("POLICY_ID", "2000000");
      call.SetValue("XPM_USER", "Acceptance55@lab.esurance.com");
      call.SetValue("USER_NAME", "ESUWEBUSER");
      string results = GeneralUtility.ExecuteMethod("EsuranceServices.ClaimService.ClaimService.GetPolicyXml", call.ToXml());
      Console.WriteLine(results);

    }
    /// <summary>
    /// Tests the convert date time string to time zone.
    /// </summary>
    [Test]
    public void TestConvertDateTimeStringToTimeZone()
    {
      var current = DateTime.Now;
      const string format = "u";

      var easternResults =
          TimeZoneInformation.ConvertDateTimeStringToTimeZone(format, current.ToString(CultureInfo.InvariantCulture), "US Eastern Standard Time");
      var pacificResults =
          TimeZoneInformation.ConvertDateTimeStringToTimeZone(format, current.ToString(CultureInfo.InvariantCulture), "Pacific Standard Time");
      var antlanticResults =
          TimeZoneInformation.ConvertDateTimeStringToTimeZone(format, current.ToString(CultureInfo.InvariantCulture), "Atlantic Standard Time");
      var centralResults =
          TimeZoneInformation.ConvertDateTimeStringToTimeZone(format, current.ToString(CultureInfo.InvariantCulture), "Central Standard Time");

      Console.WriteLine(antlanticResults);
      Console.WriteLine(easternResults);
      Console.WriteLine(centralResults);
      Console.WriteLine(pacificResults);

    }
    /// <summary>
    /// Tests the date.
    /// </summary>
    [Test]
    public void TestDate()
    {
      var date = new Date("03012009 3:00 AM");
      WriteDate(date);
      Console.WriteLine("FormatCallDateString(ToDateString) " + Date.FormatCallDateString(date.ToDateString()));
    }
    /// <summary>
    /// Tests the sysdate.
    /// </summary>
    [Test]
    public void TestSysdate()
    {
      string results = Date.GetSysdateAsString("ESUBA");
      Test.Assert.IsNotEmpty(results, "Something failed!");
      Console.WriteLine(results);

      Date date = Date.GetSysdate("FNSP");
      Test.Assert.IsNotNull(date, "date was null!");
      WriteDate(date);
    }

    /// <summary>
    /// Writes the date.
    /// </summary>
    /// <param name="date">The date.</param>
    private static void WriteDate(Date date)
    {
      Console.WriteLine("ToString: {0}", date);
      Console.WriteLine("ToDateString: {0}", date.ToDateString());
      Console.WriteLine("ToTimeString: {0}", date.ToTimeString());
      Console.WriteLine("using DateTime.ToString('s') {0}", date.DateTime.ToString("s"));
      Console.WriteLine("static ToDateString: {0}", Date.FormatToDateString(date.ToString()));
    }

    /// <summary>
    /// 
    /// </summary>
    [Test]
    public void TestMemory()
    {
      // Consumer of the NativeMethods class shown below

      var oMemoryInfo = new NativeMethods();

      Console.WriteLine("Memory Load: " + oMemoryInfo.MemoryLoad);
      Console.WriteLine("Memory is {0}tight!", oMemoryInfo.isMemoryTight() ? "" : "not ");
      Console.WriteLine("Process memory is {0}tight!", NativeMethods.IsProcessMemoryTight() ? "" : "not ");


    }

    /// <summary>
    /// Tests the loss date validation.
    /// </summary>
    [Test]
    public void TestLossDateValidation()
    {
      DateTime currentPlusTwoHours = DateTime.Now;
      int hour = currentPlusTwoHours.Hour;
      int minutes = currentPlusTwoHours.Minute;
      int seconds = currentPlusTwoHours.Second;

      string lossDate = string.Format("{0} {1}:{2}:{3}", currentPlusTwoHours.ToShortDateString(), hour, minutes, seconds);
      Console.WriteLine("Testing {0}", lossDate);
            Test.Assert.IsTrue(Date.ValidateLossDate(lossDate), "Expected valid returnd invalid!");

      lossDate = string.Format("{0} {1}:{2}:{3}", currentPlusTwoHours.ToShortDateString(), hour + 3, minutes, seconds);
      Console.WriteLine("Testing {0}", lossDate);
            Test.Assert.IsTrue(!Date.ValidateLossDate(lossDate), "Expected invalid returnd valid!");
    }

    /// <summary>
    /// Tests the HML encode.
    /// </summary>
    [Test]
    public void TestHmlEncode()
    {
      var results = GeneralUtility.HtmlEncodeChar('|');
      Console.WriteLine("{0}={1}", results, GeneralUtility.HtmlDecodeChar(results));
    }

    /// <summary>
    /// Tests the execute static method.
    /// </summary>
    [Test]
    public void TestExecuteStaticMethod()
    {
      var results = GeneralUtility.ExecuteMethod("DbClassLibrary.ActiveRecords.LocationCodes.GetFipsFromZip", "01880");
      Console.WriteLine(results);
    }

    /// <summary>
    /// Tests the get app config int.
    /// </summary>
    [Test]
    public void TestGetAppConfigInt()
    {
            Test.Assert.IsTrue(GeneralUtility.GetAppConfigValueInt("WebServiceTimeoutTest") == 50000);
            Test.Assert.IsTrue(GeneralUtility.GetAppConfigValueInt("InvalidValue") == null);
    }

    /// <summary>
    /// Tests the logger.
    /// </summary>
    [Test]
    public void TestLogger()
    {
      const int iterations = 20;
      Execute(TestErrorLog, iterations);
    }

    private static void Log(string logFrom)
    {
      ErrorLog.LogInfo("This is an info message", logFrom);
      ErrorLog.LogWarning("This is a warning message", logFrom);
      ErrorLog.LogError("This is an error message", logFrom);
    }

    // Declare a delegate type for processing a book:
#pragma warning disable 1591
    public delegate void VoidDelegate(int parm);
#pragma warning restore 1591


    private static void Execute(VoidDelegate method, int iterations)
    {
      var timer = new Stopwatch();
      timer.Start();
      if (method != null)
        method(iterations);
      timer.Stop();
      ErrorLog.DebugLog(string.Format("TestErrorLog called {0} times took {1}", iterations, timer.ElapsedMilliseconds), "PERFORMANCE");

    }
    private static void TestErrorLog(int iterations)
    {
      for (var i = 0; i < iterations; ++i)
      {
        Log("Performance");
      }
    }

    /// <summary>
    /// Tests the record set.
    /// </summary>
    [Test]
    public void TestRecordSet()
    {
      var fieldNames = new[]
			{
				"ACCNT_HRCY_STEP_ID",
				"CUSTOMER_NAME",
				"INSURED_NAME",
				"POLICY_NUMBER",
				"POLICY_URL",
				"EFFECTIVE_DATE",
				"EXPIRATION_DATE", 
				"POLICY_STATUS", 
				"RISK_LOCATION",
				"AGENCY_NAME" 
            };

      var records = XmlUtility.PrepareAdoRecordset(fieldNames, new List<List<Dictionary<string, string>>>());

            Test.Assert.IsNotNull(records);
      records.AddNew(Missing.Value, Missing.Value);
      var columnNameIndex = 0;
      // each attribute 
      records.Fields[fieldNames[columnNameIndex++]].Value = Client.Narragansett;
      records.Fields[fieldNames[columnNameIndex++]].Value = "FRED FLINTSTONE";
      records.Fields[fieldNames[columnNameIndex++]].Value = "FREDERICK B. FLINTSTONE";
      records.Fields[fieldNames[columnNameIndex++]].Value = "123456789";
      records.Fields[fieldNames[columnNameIndex++]].Value = "http://localhost/service";
      records.Fields[fieldNames[columnNameIndex++]].Value = DateTimeOffset.Now.ToString();
      records.Fields[fieldNames[columnNameIndex++]].Value = "12/12/2020";
      records.Fields[fieldNames[columnNameIndex++]].Value = "ACTIVE";
      records.Fields[fieldNames[columnNameIndex++]].Value = "BEDROCK GRANITE";
      records.Fields[fieldNames[columnNameIndex]].Value = "HANNA BARBERA";
      records.MoveFirst();

      var results = XmlUtility.GetXmlFromAdoRecordset(records);
            Test.Assert.IsNotEmpty(results);
      var recordCopy = XmlUtility.GetRecordsetFromXml(results);
      var resultsCopy = XmlUtility.GetXmlFromAdoRecordset(recordCopy);
            Test.Assert.IsTrue(resultsCopy == results);
      Console.WriteLine(resultsCopy);

    }

    /// <summary>
    /// Tests the file reader.
    /// </summary>
    [Test]
    public void TestFileReader()
    {
      using (var reader = new TextFileReader { FileName = "C:\\FnsData\\Test\\SEDCALLS.csv" })
      {
        var records = from r in reader.Records()
                      where !string.IsNullOrEmpty(r)
                      select r;

        foreach (var record in records)
          Console.WriteLine(record);
      }
    }

    /// <summary>
    /// Tests the CSV file reader.
    /// </summary>
    [Test]
    public void TestCsvFileReader()
    {
      const string routingClaimAttribute = "CLAIM:RTG_RETURNSET:CLAIM_NUMBER";

      using (var reader = new CsvFileReader { FileName = "C:\\FnsData\\Test\\SentryRoutingRules.csv" })
      {
        var records = reader.Records()
                      .Where(a => a.Length > 6 && a[1].Contains(routingClaimAttribute))
                      .Select(a => new { RuleId = a[0], RuleText = a[1] });

        var sql = new StringBuilder("select routing_plan_id from routing_plan where enablerule_id in (");
        var first = true;
        foreach (var record in records)
        {
          if (first)
            first = false;
          else
            sql.Append(",");
          sql.Append(record.RuleId);
        }
        sql.AppendLine(")");
        Console.WriteLine(sql);
      }
    }

    [Test]
    public void TestIssuesFileReader()
    {

      using (var reader = new CsvRecord { FileName = "C:\\Users\\gwynnj\\Documents\\openissues.csv" })
      {
        Console.WriteLine(reader.ToJson());
      }
    }

    [Test]
    public void TestClaimSubmissionLogger()
    {
      var logger = new ClaimSubmissionLogger();
      var rquid = GeneralUtility.GetRquId("1");
      logger.LogRequest("This is a request!", rquid, DbClassLibrary.DatabaseInstance.FNSBA);
      logger.LogResponse("This is a response!", rquid, DbClassLibrary.DatabaseInstance.FNSBA);
      Thread.Sleep(6000);
      Console.WriteLine("Request: {0} Complete!", rquid);
    }

    [Test]
    public void TestExecuteLookup()
    {
      const string method = "UnitTests.AffirmativeTest.ExecuteLookup";
      const string sql = "WHERE 1=1 AND LU_ENTITY = 'CLAIM:INSURED:VEHICLE:DRIVER' AND AND LU_NAME_FIRST = 'FRED' AND LU_NAME_LAST = 'FLINTSTONE'";
      Console.WriteLine(GeneralUtility.ExecuteMethod(method, sql));
    }

    [Test]
    public void TestJsonDataContract()
    {
      var lastModDate = DateTime.Now;
      var user = new User { Id = 12, Name = "FRED FLINTSTONE", LastModDate = lastModDate };

      var results = XmlUtility.SerializeJsonDataContract(user);
            Test.Assert.IsNotEmpty(results);
      Console.WriteLine(results);

      var serializedUser = XmlUtility.DeserializeJsonDataContract<User>(results);
            Test.Assert.IsNotNull(serializedUser);
            Test.Assert.IsTrue(serializedUser.Id == user.Id, "Id failed!");
            Test.Assert.IsTrue(serializedUser.Name == user.Name, "Name failed!");
            Test.Assert.IsTrue(serializedUser.LastModDate.ToString(CultureInfo.InvariantCulture) == user.LastModDate.ToString(CultureInfo.InvariantCulture), "LastModDate failed!");
    }

    [Test]
    public void TestHex()
    {
      const string ssn = "1A2EBCF35DDF53B6E008113CD5990BB0";
      const string val = "011223456";
      const string err = "1a30f";
      const string color = "0fffff";

            Test.Assert.IsFalse(GeneralUtility.IsNumeric(ssn));
            Test.Assert.IsTrue(GeneralUtility.IsHex(ssn));
            Test.Assert.IsTrue(GeneralUtility.IsEncryptRaw(ssn));
            Test.Assert.IsTrue(GeneralUtility.IsNumeric(val));
            Test.Assert.IsFalse(GeneralUtility.IsHex(val));
            Test.Assert.IsFalse(GeneralUtility.IsEncryptRaw(err));
            Test.Assert.IsTrue(GeneralUtility.IsHex(color));

    }
  }

  
  [DataContract]
  public class User
  {
    [DataMember]
    public int Id { get; set; }
    [DataMember]
    public string Name { get; set; }
    [DataMember]
    public DateTime LastModDate { get; set; }

  }
}

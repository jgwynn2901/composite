using System;
using System.Data;
using System.IO;
using System.Runtime.InteropServices;
using NUnit.Framework;
using System.Text;

namespace DbClassLibrary
{
    /// <summary>
    /// UNIT TEST Module.
    /// </summary>
    [TestFixture, ComVisible(false)]
    public class DbClassLibTest
    {
        /// <summary>
        /// UNIT TEST for ClaimSubmission.
        /// </summary>
        [Test, Ignore("Obsolete")]
        public void ClaimSubmission()
        {
            var submission = new ClaimSubmission("SELBA")
                                 {
                                     CallId = "1232",
                                     RqId = "517DF448-9963-4E92-B880-000000001232",
                                     ClaimNumber = "1234567",
                                     DateOfLoss = "02022006",
                                     PolicyNumber = "WC1234567",
                                     FileFormatCode = "WC",
                                     LossFileNumber = "12",
                                     ErrorCode = "999",
                                     ErrorText = "POLICY_VERIFY_ERROR_MSG",
                                     Status = "INPROC"
                                 };

            Assert.IsTrue(submission.Execute(), "Submission Failed check log!");
            Assert.IsTrue(Convert.ToInt32(submission.ClaimSubmissionId) > 0, "Something is wrong!");

        }
        /// <summary>
        /// UNIT TEST for UpdateClaimSubmissionStatus.
        /// </summary>
        [Test]
        public void TestClaimStatusUpdate()
        {
            var update = new UpdateClaimSubmissionStatus("SELBA")
                             {
                                 RqId = "517DF448-9863-4E92-B880-000000001232",
                                 Status = "PROCESSED"
                             };
            Assert.IsTrue(update.Execute(), "Update Failed!");

        }
        /// <summary>
        /// UNIT TEST for MandatoryFields.
        /// </summary>
        [Test]
        public void TestMandatoryFields()
        {
            var mandatory = new MandatoryFields("SELBA") { LobCd = "WOR" };

            var bResult = mandatory.Execute();

            if (!bResult)
            {
                Console.WriteLine(mandatory.LastError);
            }
            Assert.IsTrue(bResult);
            var results = mandatory.Results;
            Assert.IsTrue(results != null);
            var table = results.Tables[0];
            for (var i = 0; i <= table.Rows.Count - 1; i++)
            {
                Console.WriteLine("{0} {1} {2} {3}",
                    table.Rows[i]["NAME"],
                    results.Tables[0].Rows[i]["LOB_CD"],
                    results.Tables[0].Rows[i]["RULE1_TEXT"],
                    results.Tables[0].Rows[i]["RULE2_TEXT"]);
            }
        }
        /// <summary>
        /// UNIT TEST for QueueAssignments.
        /// </summary>
        [Test]
        public void TestQueueAssignments()
        {
            var queue = new QueueAssignments("SELBA");

            //queue.AttributeName = "CLAIM:ASSIGNED_TO_USERID_2";
            bool bResult = queue.Execute();

            if (!bResult)
            {
                Console.WriteLine(queue.LastError);
            }
            Assert.IsTrue(bResult);
            var results = queue.Results;
            Assert.IsTrue(results != null);
            var table = results.Tables[0];
            for (int i = 0; i <= table.Rows.Count - 1; i++)
            {
                Console.WriteLine("{0} {1} {2}",
                    table.Rows[i]["NAME"],
                    results.Tables[0].Rows[i]["DEFAULTVALUE"],
                    results.Tables[0].Rows[i]["RULE_TEXT"]);
            }
        }
        /// <summary>
        /// UNIT TEST for ClaimSubmissionLog.
        /// </summary>
        [Test, Ignore("Obsolete")]
        public void TestClaimSubmissionLog()
        {
            var claimLog = new ClaimSubmissionLog { RquId = "6FF9E354-9C4F-46FE-A162-000000005491", Instance = "SELP" };

            var s = File.OpenRead(@"C:\Fns2005\Test\esuPhase3Acord.xml");
            var r = new StreamReader(s);

            var results = claimLog.SetResponse(r.ReadToEnd());
            Assert.IsTrue(results > -1, "Insert failed!");
            Console.WriteLine("claimLog.SetResponse returned {0}", results);


        }
        /// <summary>
        /// UNIT TEST for ClaimSubmissionLog.
        /// </summary>
        [Test, Ignore("Obsolete")]
        public void TestClaimSubmissionLogData()
        {
            var claimLog = new ClaimSubmissionLog { RquId = "6FF9E354-9C4F-46FE-A162-000000005491", Instance = "SELP" };
            var results = claimLog.GetResponse();
            Assert.IsTrue(results.Length > 0, "Retrieve failed!");
            Console.WriteLine("claimLog.SetResponse returned {0}", results);
        }
        /// <summary>
        /// UNIT TEST for Provider.
        /// </summary>
        [Test, Ignore("Obsolete")]
        public void TestProviderLogic()
        {
            var provider = new Provider(DbBaseClass.FNSP) { Id = "63930", StatusCode = "W", State = "MA" };

            Assert.IsTrue(provider.Execute(), provider.LastError);
            Console.WriteLine("claimLog.SetResponse returned {0}", provider.ProviderId);
        }

        /// <summary>
        /// UNIT TEST for ResetProvider.
        /// </summary>
        [Test, Ignore("Obsolete")]
        public void TestProviderUnlock()
        {
            var provider = new ResetProvider { Id = "21003505520" };
            Assert.IsTrue(provider.Execute(), provider.LastError);
            Console.WriteLine("claimLog.SetResponse returned {0}", provider.ProviderId);
        }
        /// <summary>
        /// UNIT TEST for ClaimCsrId.
        /// </summary>
        [Test, Ignore("Obsolete")]
        public void TestClaimCsrId()
        {
            const string csrs = "AKINLS1 AKINLEYE, STEPHENSON ;WILKINS1 WILKINS, SUSAN ;ARAUJB1 ARAUJO, BARBARA ;BALDWP1 BALDWIN, PCLA, PATRICIA ;BROWNJ3 BROWN, JOY ;BULLOC1 BULLOCK, CASSANDRA ;COKERM1 COKER, MARY ;COLLIB1 COLLINS, BRIANNE ;DICKSJ1 DICKSON, JESSICA ;FRANKK1 FRANKLIN, KRYSTAL ;GREENS2 GREEN, SHUKRIYYAH ;GUADAA1 GUADAMUZ, ANGELA ;HENRIR1 HENRIQUEZ, IRENE ;INGRAR1 INGRAM, ROBERT ;KENDEB1 KENDUS, BRIAN ;LITTEM1 LITTELL, MELISSA ;MORGAJ1 MARTIN, JAMIE L. ;MITCHS1 MITCHELL, SAFONIA ;CSCAUTOQ QUEUE, AUTO_CLAIMS ;CSCPROP QUEUE, PROPERTY_CLAIMS ;SAFELITE QUEUE, SAFELITE_EDI ;RIOSRS1 RIOS, ROSA ;ROLANC1 ROLAND, CHEKESHA ;SPIERB1 SPIERS, BETTY ;SWERTL1 SWERTFEGER, LISBETH ;VOORHC1 VOORHEES, CHRISTINE ;WILLIJ4 WILLIAMS, JAMES F.";
            Assert.IsTrue(ClaimCsrId.ProcessDelimitedCsrString("12345678", csrs), "ProcessDelimitedCsrString failed!");
            Console.WriteLine("ProcessDelimitedCsrString returned true.");
        }

        /// <summary>
        /// UNIT TEST for CrawfordNcciCodes.
        /// </summary>
        [Test, Ignore("Obsolete")]
        public void TestCrawfordNcciCodes()
        {
            var codes = new CrawfordNcciCodes("CRAWP")
                            {
                                AhsId = "256899",
                                JobCode = "CDF",
                                LobCode = "SM005",
                                StateCode = "AZ",
                                NcciCode = "9014"
                            };

            Assert.IsTrue(codes.Execute(), codes.LastError);
            Console.WriteLine("CraNcciClassCodeId = {0}", codes.CraNcciClassCodeId);
        }

        /// <summary>
        /// UNIT TEST for FileTranLogRecord.
        /// </summary>
        [Test, Ignore("Obsolete")]
        public void TestFileTranLogRecord()
        {
            var fileTranLog = new FileTranLogRecord("CRAWP")
                                  {
                                      FileTranDefId = "221",
                                      FileName = @"F:\FNSNet\UIF_Convert\holding\CRA\holding\aramark_ncci_facility.csv",
                                      Server = "CHADTBD2",
                                      Status = "INPROC"
                                  };
            Assert.IsTrue(fileTranLog.Execute(), fileTranLog.LastError);
            Console.WriteLine("fileTranLogId = {0}", fileTranLog.FileTranLogId);
            Assert.IsTrue(fileTranLog.UpdateStatus("PROCESSED"), fileTranLog.LastError);
            Console.WriteLine("status updated...");
        }
        /// <summary>
        /// UNIT TEST for FileTranError.
        /// </summary>
        [Test, Ignore("Obsolete")]
        public void TestFileTranError()
        {
            var error = new FileTranError("CRAWP")
                            {
                                FileTranLogId = "-99",
                                AhsId = "81",
                                CancelDate = "12/12/2006",
                                PolicyNumber = "12345678",
                                EffectiveDate = "01/01/2005",
                                ExpirationDate = "01/01/2006",
                                ErrorCode = "212",
                                ErrorText = "This is a test error!",
                                EntityName = "Entity Name",
                                RecordData = "TEST!",
                                Type = "EXCEL",
                                Severity = "1"
                            };

            Assert.IsTrue(error.Execute(), error.LastError);
            Console.WriteLine("FileTranErrorId = {0}", error.FileTranErrorId);
        }
        /// <summary>
        /// Tests the get ahsid using policy data.
        /// </summary>
        [Test]
        public void TestGetAhsidUsingPolicyData()
        {
            var get = new GetPolicyIDFromPolicyData(DbBaseClass.FNSP) { Uploadkey = "ANI/05IAS00341/POL" };
            Assert.IsTrue(get.Execute(), get.LastError);
            var id = get.PolicyId;
            Console.WriteLine("The Policy ID is {0}", id);
        }

        /// <summary>
        /// Tests the name of the alternate.
        /// </summary>
        [Test]
        public void TestAlternateName()
        {
            var alt = new AlternateName(DbBaseClass.FNSP)
                          {
                              AHSID = "152",
                              FullName = "TESTING",
                              SequenceNumber = "00001",
                              FileTranLogId = "1234",
                              UploadKey = "ANI/25196361/TEST/ALT"
                          };

            alt.Execute();
            Console.WriteLine("Alternate Name ID: {0}", alt.AltNameId);
        }

        /// <summary>
        /// Tests the contact.
        /// </summary>
        [Test]
        public void TestContact()
        {
            var mycontact = new Contact(DbBaseClass.FNSP)
                                {
                                    Address1 = "95 Wells Ave",
                                    Address2 = "suite 300",
                                    City = "NEWTON",
                                    State = "MA",
                                    ContactType = "PRIMARY",
                                    Description = "",
                                    Email = "jennycheung@test.com",
                                    Enable_flg = "Y",
                                    FullName = "Jenny Cheung",
                                    AHSID = "152"
                                };

            mycontact.Execute();
            Console.WriteLine("My Contact is : {0}", mycontact.ContactId);
        }

        /// <summary>
        /// Tests the AN i_ location_ code.
        /// </summary>
        [Test]
        public void TestAniLocationCode()
        {
            var lc = new LocationCode(DbBaseClass.FNSP)
                         {
                             AccountNumber = "30118",
                             AhsId = "25196064",
                             CodingDesc1 = "Codi",
                             CodingValue1 = "001",
                             Upload_Key = "ANI3011825196064LOCATION"
                         };
            lc.Execute();
            Console.WriteLine("ANI LOcation Code ID is : {0}", lc.LocationCodeId);
        }

        /// <summary>
        /// Tests the update ANI location code.
        /// </summary>
        [Test, Ignore("Obsolete")]
        public void TestUpdateAniLocationCode()
        {
            var up = new UpdateANILocationCode(DbBaseClass.FNSP)
                         {
                             AccountNumber = "00338",
                             FileTranLogId = "340515",
                             UploadKey = "ANI/00338/ACCOUNT"
                         };
            if (up.Execute())
                Console.WriteLine("records deleted: {0}", up.RecordCount);
        }

        /// <summary>
        /// Tests the update ANI policy records.
        /// </summary>
        [Test, Ignore("Obsolete")]
        public void TestUpdateAniPolicyRecords()
        {
            var up = new UpdateANIPolicyRecords(DbBaseClass.FNSP) {AccountNumber = "00023", FileTranLogId = "339162"};
            if (up.Execute())
                Console.WriteLine("records deleted: {0}", up.RecordCount);
        }

        /// <summary>
        /// Tests the update ANI alt names records.
        /// </summary>
        [Test, Ignore("Obsolete")]
        public void TestUpdateAniAltNamesRecords()
        {
            var up = new UpdateANIAlternatInsuredNameRecords(DbBaseClass.FNSP)
                         {
                             UploadKey = "ANI/06BLU02977/POL",
                             FileTranLogId = "339496"
                         };

            Assert.IsTrue(up.Execute(), up.LastError);
            Console.WriteLine("records deleted: {0}", up.RecordCount);
        }
        /// <summary>
        /// Tests the clean sentry old location records.
        /// </summary>
        [Test, Ignore("Obsolete")]
        public void TestCleanSentryOldLocationRecords()
        {
            var old = new CleanOldLocationRecords("SENP") {FileTranLogId = "21703"};
            Assert.IsTrue(old.Execute(), old.LastError);
            Console.WriteLine("records deleted: {0}", old.RecordCount);
        }

        /// <summary>
        /// Tests the parameterized SQL.
        /// </summary>
        [Test]
        public void TestParameterizedSql()
        {
            using (var reader = GeneralUtility.ExecuteReader("select * from RULES where RULE_ID = :1",
                                                                          new object[] { -103 }))
            {
                Assert.IsNotNull(reader, "nothing returned!");
                ReadFromReader(reader);
            }

            // a typical example from branch assignment:
            const int esisAhsId = 202;
            const string instance = "FNSBA";
            const string lineOfBusiness = "CLI";

            var sql = new StringBuilder("SELECT * FROM CLAIMNUMBERASSIGNMENTRULE ");
            // parm :1 is int => NUMBER(10) =>DbType.Int32 N.B. strings do actually work OK but not recommended.
            sql.Append("WHERE USEDUP_FLG='N' AND CLAIMNUMBERASSIGNMENTRULE.ACCNT_HRCY_STEP_ID = :1 ");
            // parm :2 is string => VARCHAR => DbType.String N.B. no quotes required.
            sql.Append("AND (CLAIMNUMBERASSIGNMENTRULE.LOB_CD = :2 OR CLAIMNUMBERASSIGNMENTRULE.LOB_CD='*')");

            using (var reader = GeneralUtility.ExecuteReader(sql.ToString(), instance,
                new object[] { esisAhsId, lineOfBusiness }))
            {
                Assert.IsNotNull(reader, "nothing returned!");
                ReadFromReader(reader);
            }
        }

        private static void ReadFromReader(IDataReader reader)
        {
            while (reader.Read())
            {
                Console.WriteLine("=============================");
                for (var i = 0; i < reader.FieldCount; ++i)
                    Console.WriteLine("{0}={1}", reader.GetName(i), reader[i]);
            }
            Console.WriteLine("=============================");
        }

        /// <summary>
        /// Tests the zip code parser.
        /// </summary>
        [Test]
        public void TestZipCodeParser()
        {
            const string usa1 = "021270000";
            const string usa2 = "01800-0000";
            const string canada = "B1N1W7";
            const string reject = "0212-3345";

            string results;

            Assert.IsTrue(GeneralUtility.TryParseZipCode(usa1, out results));
            Console.WriteLine(results);

            Assert.IsTrue(GeneralUtility.TryParseZipCode(usa2, out results));
            Console.WriteLine(results);

            Assert.IsTrue(GeneralUtility.TryParseZipCode(canada, out results));
            Console.WriteLine(results);

            Assert.IsFalse(GeneralUtility.TryParseZipCode(reject, out results));
            Console.WriteLine(results);
        }
    }
}

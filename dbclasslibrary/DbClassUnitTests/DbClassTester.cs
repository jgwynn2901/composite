/**************************************************************************
* First Notice Systems
* 529 Main Street
* Boston, MA 02129
* (617) 886 2600
*
* Proprietary Source Code -- Distribution restricted
*
* Copyright (c) 2006 by First Notice Systems
**************************************************************************/
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/DbClassUnitTests/DbClassTester.cs 6     2/07/11 3:40p Gwynnj $ */

using System;
using System.Data;
using System.Runtime.InteropServices;
using System.Text;
using DbClassLibrary;
using DbClassLibrary.Opm;
using NUnit.Framework;

namespace DbClassUnitTests
{
    /// <summary>
    /// UNIT TEST Module.
    /// </summary>
    [TestFixture, ComVisible(false)]
    public class DbClassTester
    {
        [Test]
        public void TestFormattedSystemDate()
        {
            Console.WriteLine(GeneralUtility.GetFormattedSysdate("MM/DD/YYYY"));
        }
        /// <summary>
        /// UNIT TEST for ApplicationLog.
        /// </summary>
        [Test]
        public void TestApplicationLog()
        {
            var myLog = new ApplicationLog
            {
                Component = "DbClassLibrary",
                ErrorString = "This is a test entry",
                Server = "CHADTBD2",
                Severity = 1
            };

            Assert.IsTrue(myLog.Execute(), myLog.LastError);
            Assert.IsTrue(myLog.ApplicationLogID > -1);
        }

        [Test]
        public void TestEncryption()
        {
            var encrypt = new Encryption { CurrentDbInstance = DbBaseClass.FNSBA, Value = "This is a test" };
            Assert.IsTrue(encrypt.Execute(), encrypt.LastError);
            Assert.IsTrue(encrypt.Encrypt != "");
            Console.WriteLine(encrypt.Encrypt);
            var decrypt = new Decryption { CurrentDbInstance = DbBaseClass.FNSBA, Value = encrypt.Encrypt };
            Assert.IsTrue(decrypt.Execute(), decrypt.LastError);
            Assert.IsTrue(decrypt.Encrypt != "");
            Console.WriteLine(decrypt.Encrypt);

        }
        /// <summary>
        /// UNIT TEST for MercuryDestinations.
        /// </summary>
        [Test]
        public void TestMercuryDestinations()
        {
            var mercury = new MercuryDestinations { DestinationType = "CALLROUTING_EMAIL" };

            Assert.IsTrue(mercury.Execute(), mercury.LastError);

            var results = mercury.Results;
            Assert.IsTrue(results != null);
            var table = results.Tables[0];
            for (var i = 0; i <= table.Rows.Count - 1; i++)
            {
                Console.WriteLine("{0} {1}",
                  table.Rows[i][0],
                  results.Tables[0].Rows[i][1]);
            }
        }
        /// <summary>
        /// UNIT TEST for ClaimCsrId.
        /// </summary>
        [Test]
        public void TestSelectiveCsrId()
        {
            const string source = "AKINLS1 AKINLEYE, STEPHENSON ;ALKINS1 ALKINS, SUSAN ;ARAUJB1 ARAUJO, BARBARA ;BALDWP1 BALDWIN, PCLA, PATRICIA ;BROWNJ5 BROWN, JEWELL ;BROWNJ3 BROWN, JOY ;BROWNR2 BROWN, RONDA L. ;BULLOC1 BULLOCK, CASSANDRA ;CARPEM1 CARPENTER, MAURICE ;CHRISD1 CHRISTIAN, DAPHNIE ;COKERM1 COKER, MARY ;COLLIB1 COLLINS, BRIANNE ;DAHILE1 DAHILIA-DAVIS, ELLEN ;DICKSJ1 DICKSON, JESSICA ;ECKERA1 ECKERT, ALAN ;FRANKK1 FRANKLIN, KRYSTAL ;GREENS2 GREEN, SHUKRIYYAH ;GUADAA1 GUADAMUZ, ANGELA ;HENRIR1 HENRIQUEZ, IRENE ;INGRAR1 INGRAM, ROBERT ;KELSEJ1 KELSEY, JACQUELINE ;KENDEB1 KENDUS, BRIAN ;LITTEM1 LITTELL, MELISSA ;MORGAJ1 MARTIN, JAMIE L. ;MCKEER1 MCKEEVER, RENEE ;MITCHS1 MITCHELL, SAFONIA ;PRICEJ2 PRICE, JANET ;RIOSRS1 RIOS, ROSA ;ROLANC1 ROLAND, CHEKESHA ;SAFELITE SAFELITE_EDI ;SPIERB1 SPIERS, BETTY ;SWERTL1 SWERTFEGER, LISBETH ;VOORHC1 VOORHEES, CHRISTINE ;WILLIJ4 WILLIAMS, JAMES F.";
            Assert.IsTrue(ClaimCsrId.ProcessDelimitedCsrString("12345678", source), "ClaimCsrId.ProcessDelimitedCsrString Failed!");
        }

        /// <summary>
        /// UNIT TEST for VehicleCoverage.
        /// </summary>
        [Test, Ignore("Obsolete")]
        public void TestVehicleCoverage()
        {
            var coverage = new VehicleCoverage(DbBaseClass.FNSP);

            const string coverageType = "TEST1";

            coverage.FileTranLogId = "-102";
            coverage.CoverageType = coverageType;
            coverage.UploadKey = coverageType;
            coverage.Description = coverageType;
            coverage.VehicleID = "15709829";
            coverage.ActiveStartDate = "01/01/2006";
            coverage.ActiveEndDate = "01/01/2007";
            coverage.ReceivedStartDate = "01/01/2006";
            coverage.ReceivedEndDate = "01/01/2007";
            coverage.ActiveStartDate = "01/01/2006";
            coverage.ActiveEndDate = "01/01/2007";

            Assert.IsTrue(coverage.Execute(), coverage.LastError);

        }
        /// <summary>
        /// UNIT TEST for FileTranLogDef.
        /// </summary>
        [Test]
        public void TestFileTranDef()
        {
            var def = new FileTranLogDef("FNSBA") { AhsId = "202", Server = "OLYMPUS", Type = "IPM_LOAD" };

            Assert.IsTrue(def.Execute(), def.LastError);
            var results = def.Results;
            Assert.IsTrue(results != null);

            var table = results.Tables[0];
            for (var i = 0; i <= table.Rows.Count - 1; i++)
            {
                Console.WriteLine("{0}:{1}:{2}:{3}:{4}:{5}",
                  table.Rows[i][(int)FileTranLogDef.ResultList.FileTranLogDefId],
                  table.Rows[i][(int)FileTranLogDef.ResultList.Description],
                  table.Rows[i][(int)FileTranLogDef.ResultList.FileNamePattern],
                  table.Rows[i][(int)FileTranLogDef.ResultList.SourceLocation],
                  table.Rows[i][(int)FileTranLogDef.ResultList.Destination],
                  table.Rows[i][(int)FileTranLogDef.ResultList.ImportRecordTypeId]
                  );
            }
        }
        /// <summary>
        /// UNIT TEST the EncryptAttributeSet.
        /// </summary>
        [Test]
        public void TestEncryptAttributeSet()
        {
            var encryptAttributes = new EncryptAttributeSet("FNSBA") { AhsId = "102", LobCd = "PAU", EncryptType = "ACORD" };

            Assert.IsTrue(encryptAttributes.Execute(), encryptAttributes.LastError);
            Assert.IsTrue(encryptAttributes.Results != null);
            foreach (DataRow encryptRow in encryptAttributes)
                Console.WriteLine("{0}",
                    encryptRow[(int)EncryptAttributeSet.ResultList.AttributeName]);
        }
        /// <summary>
        /// UNIT TEST for LocationCityFromZip.
        /// </summary>
        [Test, Ignore("Obsolete")]
        public void TestLocationCityFromZip()
        {
            const string zip = "02127";
            var city = LocationCityFromZip.GetCityFromZip("FNSP", zip);
            Assert.IsNotEmpty(city, "GetCityFromZip failed");
            Console.WriteLine("City {0} returned for {1}", city, zip);
        }

        /// <summary>
        /// UNIT TEST for GetLOCATIONAHSID.
        /// </summary>
        [Test, Ignore("Obsolete")]
        public void TestGetLocationAhsid()
        {
            const string locationcode = "7-64128";
            var ahsid = GetAHSID.GetLOCATIONAHSID("CRAWP", locationcode);
            Assert.IsNotEmpty(ahsid, "GetAHSID failed");
            Console.WriteLine("AHSID {0} returned for {1}", ahsid, locationcode);
        }

        /// <summary>
        /// UNIT TEST for GetuserID.
        /// </summary>
        [Test, Ignore("Obsolete")]
        public void TestGetUserId()
        {
            const string username = "JENNYCH";
            var userid = GetuserIDfromUserName.GetUserID("CRAWP", username);
            Assert.IsNotEmpty(userid, "GetUserID failed");
            Console.WriteLine("UserID {0} returned for {1}", userid, username);
        }

        [Test]
        public void TestEscalationOutcomeAdd()
        {

            var escalationStep = new EscalationOutcomeStepAdd(DbBaseClass.SEDBA)
            {
                EscalationOutcomeId = "10474",
                UserId = "1232",
                EscalationOutcomeName = "Varies by PepsiCo Company and DivLoc",
                Description = "Unit Test record",
                PhoneNumber = "5082221234",
                Complete = "N"
            };

            Assert.IsTrue(escalationStep.Execute(), escalationStep.LastError);
            Console.WriteLine($"Escalation Outcome Step Id: {escalationStep.Result}");
        }
        [Test]
        public void TestEscalationOutcomeStep()
        {

            var escalationStep = new EscalationOutcomeStep(DbBaseClass.SEDBA)
            {
                EscalationOutcomeId = "10474",
                StepId = "443",
                UserId = "1232",
                EscalationOutcomeName = "George Jetson",
                Description = "Unit Test updated record",
                PhoneNumber = "5082221234",
                Complete = "Y"
            };

            Assert.IsTrue(escalationStep.Execute(), escalationStep.LastError);
            Console.WriteLine($"EscalationOutcomeStep results: {escalationStep.Result}");
        }

        /// <summary>
        /// UNIT TEST Tests the procedure definition.
        /// </summary>
        [Test]
        public void TestStoredProcedureDefinition()
        {
            var def = new ProcedureDefinition(DbBaseClass.SEDBA) { PackageName = "DBCLASSLIBRARY", ProcedureName = "AddEscalationOutcomeStep" };

            Assert.IsTrue(def.Execute(), def.LastError);

            foreach (ProcedureDefinition row in def)
            {
                Console.WriteLine("{0}\t{1} {2} {3}", row.Position, row.ArgumentName, row.DataType, row.InOut);
            }
        }
        /// <summary>
        /// UNIT TEST for LocationStateFromZip.
        /// </summary>
        [Test, Ignore("Obsolete")]
        public void TestLocationStateFromZip()
        {
            const string zip = "01880";
            var city = LocationStateFromZip.GetStateFromZip("FNSBA", zip);
            Assert.IsNotEmpty(city, "GetCityFromZip failed");
            Console.WriteLine("State {0} returned for {1}", city, zip);

        }
        /// <summary>
        /// UNIT TEST Tests the employee extension.
        /// </summary>
        [Test, Ignore("Obsolete")]
        public void TestEmployeeExtension()
        {
            var extension = new EmployeeExtension("CRAWP")
            {
                EmployeeId = "10",
                FileTranLogId = "-99",
                FieldName = "THIS IS A TEST",
                FieldValue = "HELLO WORLD!"
            };
            Assert.IsTrue(extension.Execute(), extension.LastError);
        }
        /// <summary>
        /// UNIT TEST Tests the ahs record.
        /// </summary>
        [Test]
        public void TestAhsRecord()
        {
            var record = new AhsRecord("SEDP") { UploadKey = "SED/195119510001/INSURED" };

            if (record.Execute())
                Console.WriteLine("AHS record not found");

            Assert.IsEmpty(record.LastError, record.LastError);
            Console.WriteLine("AHSID: {0}, NAME: {1}, LOCATION_CODE: {2} TYPE: {3} UPLOAD_KEY: {4}", record.AhsId, record.FullName, record.LocationCode, record.AhsType, record.UploadKey);

            var record2 = new AhsRecord(DbBaseClass.FNSP) { UploadKey = "ESS/598/3522349/LOCATION" };

            Assert.IsTrue(record2.Execute(), record2.LastError);
            Assert.IsEmpty(record2.LastError, record2.LastError);

            Console.WriteLine("AHSID: {0}, NAME: {1}, LOCATION_CODE: {2} TYPE: {3} UPLOAD_KEY: {4}", record2.AhsId, record2.FullName, record2.LocationCode, record2.AhsType, record2.UploadKey);
        }

        /// <summary>
        /// UNIT TEST Tests the table definition.
        /// </summary>
        [Test]
        public void GenerateTableDefinition()
        {
            var def = new TableDefinition(DbBaseClass.SEDP) { TableName = "CLAIMNUMBERASSIGNMENTRULE" };

            Assert.IsTrue(def.Execute(), def.LastError);

            foreach (TableDefinition row in def)
            {
                var response = new StringBuilder();
                response.AppendFormat("columns.Add(new Column(\"{0}\", string.Empty,\"{1}\"));",
                  row.ColumnName, row.DataType);
                //response.AppendFormat("ColumnNameMap.Add(\"{0}\",{1});\r\n", row.ColumnName, index++);
                Console.WriteLine(response);
            }
            Console.WriteLine();
            Console.WriteLine();
            def.Reset();

            foreach (TableDefinition row in def)
            {
                var response = new StringBuilder();
                response.AppendFormat("#region {0}\r\n", GeneralUtility.PascalCase(row.ColumnName));
                response.AppendLine("/// <summary>");
                response.AppendFormat("/// {0}\r\n", row.ColumnName);
                response.AppendLine("/// </summary>");
                response.AppendFormat("public string {0}\n\r{{\n\r\tget {{", GeneralUtility.PascalCase(row.ColumnName));
                response.AppendFormat(" return GetColumnValue(\"{0}\"); ", row.ColumnName);
                response.Append("}\r\n\tset {");
                response.AppendFormat(" SetColumnValue(\"{0}\",value); ", row.ColumnName);
                response.Append("}\r\n}\r\n#endregion\r\n");
                Console.WriteLine(response);
            }

        }
        /// <summary>
        /// UNIT TEST Tests the procedure definition.
        /// </summary>
        [Test]
        public void TestProcedureDefinition()
        {
            var def = new ProcedureDefinition(DbBaseClass.SEDBA) { PackageName = "DBCLASSLIBRARY", ProcedureName = "AddEscalationOutcomeStep" };

            Assert.IsTrue(def.Execute(), def.LastError);
            foreach (ProcedureDefinition row in def)
                Console.WriteLine("{0}\t{1} {2} {3}", row.Position, row.ArgumentName, row.DataType, row.InOut);
        }
        /// <summary>
        /// UNIT TEST Tests the specific destination.
        /// </summary>
        [Test]
        public void TestSpecificDestination()
        {
            var dest = new SpecificDestination("SEDP")
            {
                AhsId = "1",
                Lobcd = "WOR;CAU;CLI",
                NameFirst = "JOHN",
                NameLast = "KENNEDY",
                NameMid = "F",
                Nametitle = "Chief Cook and BottleWasher",
                Address1 = "12 Pennsylvania Avenue",
                Address2 = "Suite 600",
                City = "Brooklyn",
                State = "NY",
                Zip = "02129",
                Phone = "6178862064",
                UploadKey = "TEST/SPECIFIC"
            };

            Assert.IsTrue(dest.Execute(), dest.LastError);
            Console.WriteLine("Specific Destination ID: {0}", dest.SpecdestId);
        }
        /// <summary>
        /// UNIT TEST Tests the specific dest seq step.
        /// </summary>
        [Test]
        public void TestSpecificDestSeqStep()
        {
            var step = new SpecificDestSeqStep("SEDP")
            {
                DestinationString = "john_gwynn@firstnotice.com",
                AltDestString = "james_mcadams@firstnotice.com",
                SpecDestId = "1426",
                RetryCount = "1",
                RetryWaitTime = "180",
                TranTypeId = "7",
                Sequence = "1",
                FileTranLogId = "5569"
            };


            Assert.IsTrue(step.Execute(), step.LastError);
            Console.WriteLine($"Specific Destination Sequence Step ID: {step.SpecDestSeqStepId}");

        }

        [Test]
        public void TestClaimNumber()
        {
            var step = new ClaimAssignment
            {
                ClaimNumberAssignmentRuleId = "1",
                Maximum = "9999999"
            };
            const int len = 7;
            var format = $"D{len}";

            Assert.IsTrue(step.Execute(), step.LastError);
            Console.WriteLine($"ClaimAssignment Claim Number: {step.ClaimNumber.ToString(format)}");

        }
        /// <summary>
        /// UNIT TEST Tests the esis policy lookup.
        /// </summary>
        [Test]
        public void TestEsisPolicyLookup()
        {
            var policy = new EsisPolicyLookup { LobCd = "WOR", PolicyNumber = "C44344336", LocationCode = "1W02" };

            var results = policy.Execute();
            Assert.IsNotEmpty(results, policy.LastError);
            Console.WriteLine(results);
        }
        /// <summary>
        /// Tests the update X claim data.  ONE TIME test -throwaway
        /// </summary>
        [Test]
        public void TestUpdateXClaimData()
        {
            var claim = new UpdateXClaimData("FNSBA") { ClaimId = "146984", FieldName = "TEST_FIELD", FieldValue = "TEST_VALUE" };

            Assert.IsTrue(claim.Execute(), claim.LastError);
            Assert.IsTrue(claim.Result.Equals("1"), "Unexpected results!");
        }
        /// <summary>
        /// Tests the estar appraiser record.
        /// </summary>
        [Test, Ignore("Obsolete")]
        public void TestEstarAppraiserRecord()
        {
            var appraisers = new ActiveRecordSet { Instance = "ESUBA", Query = "select * from estar_appraiser" };

            Assert.IsTrue(appraisers.Execute(), appraisers.LastError);
            {
                foreach (ActiveRecord rec in appraisers)
                {
                    var index = 0;
                    foreach (var c in rec.Columns)
                        Console.WriteLine("COLUMN{0}: {1}, {2}", index++, c.Name, c.Value);
                }
            }
        }
        /// <summary>
        /// Tests the fraud language.
        /// </summary>
        [Test, Ignore("Obsolete")]
        public void TestFraudLanguage()
        {
            var results = FraudLanguage.GetFraudLanguageByStateCode("TX", "ESUBA");
            Assert.IsNotEmpty(results, "Failed!");
            Console.WriteLine(results);
        }
        /// <summary>
        /// Tests the create call routing record.
        /// </summary>
        [Test, Ignore("Obsolete")]
        public void TestCreateCallRoutingRecord()
        {
            var rec = new CallRecord { CallId = "1000046", Instance = "ESUBA" };

            Assert.IsTrue(rec.Execute(), rec.LastError);

            rec.Status = "COMPLETED-UNIT-TEST";
            Assert.IsTrue(CallRoutingRecord.CreateCallRoutingRecordFromCallRecord(rec), "Operation Failed!");
        }

        /// <summary>
        /// Tests the state of the zip from.
        /// </summary>
        [Test, Ignore("Obsolete")]
        public void TestZipFromState()
        {
            var zipCode = new GetZipFromCityState("ESUBA") { City = "SOUTH BOSTON", State = "MA" };
            Assert.IsTrue(zipCode.Execute(), zipCode.LastError);
            Console.WriteLine(zipCode.Zip);
        }

        [Test]
        public void TestInstanceFromRegistry()
        {
            var instance = DatabaseInstance.InstanceFromRegistry();
            Assert.IsNotEmpty(instance);
            Console.WriteLine(instance);
        }

        /// <summary>
        /// Tests the config setting.
        /// </summary>
        [Test, Ignore("Obsolete")]
        public void TestConfigSetting()
        {
            var results = ConfigSettings.GetConfigSetting("ESUQA", "aspnet_wp", "googlemaps.subgurim.net");
            Assert.IsNotEmpty(results, "googlemaps.subgurim.net is not defined - check DBClassLibrary");
            Console.WriteLine(results);
        }

        /// <summary>
        /// Tests the account hierarchy step.
        /// </summary>
        [Test]
        public void TestAccountHierarchyStep()
        {
            var ahs = new AccountHierarchyStep("SEDP")
            {
                Name = "TEST FOR JENNY",
                AhsType = "ACCOUNT",
                ClientNodeID = "18",
                Address1 = "95 WELLS AVE.",
                City = "NEWTON",
                Zip = "02459",
                UploadKey = "TEST FOR JENNY",
                SpecificDestination = "1001"
            };

            Assert.IsTrue(ahs.Execute(), ahs.LastError);
            Console.WriteLine(ahs.AHSID, ahs.SpecificDestination);

        }

        /// <summary>
        /// Tests the name of the get template.
        /// </summary>
        [Test]
        public void TestGetTemplateName()
        {
            var templates = new ActiveRecordSet { Instance = "FNSBA", Query = "SELECT FILE_NAME FROM OUTPUT_XMLTEMPLATE" };
            Assert.IsTrue(templates.Execute(), templates.LastError);
            foreach (ActiveRecord rec in templates)
                Console.WriteLine(rec.GetColumnValue("FILE_NAME"));
        }

        /// <summary>
        /// Tests the contact.
        /// </summary>
        [Test]
        public void TestContact()
        {
            var contact = new ContactActiveRecord { Instance = "FNSP", ContactId = "464463" };
            Assert.IsTrue(contact.Execute(), contact.LastError);
            Console.WriteLine("Contact: {0} Title: {1}", contact.ContactName, contact.Title);


        }

        /// <summary>
        /// Tests the contacts.
        /// </summary>
        [Test]
        public void TestContacts()
        {
            var contacts = ContactActiveRecordSet.GetContactsByAhsId("6036343", "FNSP");
            Assert.IsTrue(contacts.Count == 2, contacts.LastError);
            foreach (ContactActiveRecord contact in contacts)
                Console.WriteLine("Contact: {0} Title: {1}", contact.ContactName, contact.Title);
        }

        [Test]
        public void TestConfigurationConnectStrings()
        {
            var sedqa = GeneralUtility.GetConnectStringFromInstance("SEDQA");
            Assert.IsNotEmpty(sedqa);
            Assert.True(sedqa.IndexOf("Password=", StringComparison.CurrentCultureIgnoreCase) > -1);
            var connect = new ConnectString(sedqa);
            Assert.IsNotEmpty(connect.DataSource);
            Assert.IsNotEmpty(connect.User);
            Assert.IsNotEmpty(connect.Password);

            Console.WriteLine(connect.ToDisplayString());
        }

        [Test]
        public void TestReRouteCall()
        {
            var router = new ReRouteCall(DbBaseClass.SEDBA)
            {
                CallId = "26724"
            };

            Assert.IsTrue(router.Execute(), router.LastError);

        }

        [Test]
        public void TestExtendedRoutings()
        {
            var routings = new ExtendedRoutings();
            foreach (var routing in routings.Results())
            {
                Console.WriteLine(routing);
            }
        }
    }
}

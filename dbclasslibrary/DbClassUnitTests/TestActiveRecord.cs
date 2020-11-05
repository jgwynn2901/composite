#region Header
/**************************************************************************
* First Notice Systems
* 95 Wells Avenue
* Newton, MA 02459
* (617) 886-2600
*
* Proprietary Source Code -- Distribution restricted
*
* Copyright (c) 2007 by First Notice Systems
**************************************************************************/
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/DbClassUnitTests/TestActiveRecord.cs 8     2/09/11 2:20p Gwynnj $ */
#endregion
using System;
using System.IO;
using System.Linq;
using System.Text;
using DbClassLibrary;
using DbClassLibrary.Callflow;
using DbClassLibrary.FirstNotice;
using DbClassLibrary.Import;
using DbClassLibrary.Opm;
using NUnit.Framework;
using DbClassLibrary.Security;
using System.Runtime.InteropServices;
using DbClassLibrary.ActiveRecords;
using System.Collections.Generic;
using System.Diagnostics;
using CallRoutings = DbClassLibrary.CallRoutings;
using TransmissionOutcome = DbClassLibrary.Opm.TransmissionOutcome;
using TransmissionOutcomeStep = DbClassLibrary.Opm.TransmissionOutcomeStep;
using Users = DbClassLibrary.Security.Users;

//using Users = DbClassLibrary.Users;

namespace DbClassUnitTests
{
    public class ResultAttribute
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Caption { get; set; }
        public string Description { get; set; }
        public int Sequence { get; set; }
        public string EnabledRule { get; set; }
        public string Mask { get; set; }
        public string Type { get; set; }
        public int Width { get; set; }
        public int Xpos { get; set; }
        public int Ypos { get; set; }
    }
    public class ResultFrame
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Sequence { get; set; }
        public string EnabledRule { get; set; }
        public ResultAttribute[] Attributes { get; set; }
    }

    /// <summary>
    /// UNIT TEST CLASS for ActiveRecord based classes.
    /// </summary>
    [TestFixture, ComVisible(false)]
    public class TestActiveRecord
    {
        private const string UnexpectedValue = "Unexpected value returned!";
        /// <summary>
        /// UNIT TEST Tests the initialize.
        /// </summary>
        [Test]
        public void TestInitialize()
        {
            var ar = new ActiveRecord("ACCOUNT_HIERARCHY_STEP") { Instance = DbBaseClass.SEDP };
            ar.Initialize();
            var results = new StringBuilder();

            foreach (var col in ar.Columns)
            {
                results.AppendLine($"\"{col.Name}\",");
            }  
            Console.WriteLine(results.ToString());
       }

        /// <summary>
        /// UNIT TEST Tests the select.
        /// </summary>
        [Test]
        public void TestSelectAndExecute()
        {
            var ar = new ActiveRecord("FILE_TRANSMISSION_DEF") { Instance = DbBaseClass.FNSP };
            ar.Initialize();

            Assert.IsNotEmpty(ar.Select, "Select clause generation failed!");
            Console.WriteLine(ar.Select);
            ar.SetPrimaryKeyValue("53");
            Assert.IsNotEmpty(ar.Where, "Where clause generation failed!");
            Console.WriteLine(ar.Where);

            Assert.IsTrue(ar.Execute(), ar.LastError);

            var index = 0;
            foreach (Column c in ar.Columns)
            {
                Console.WriteLine("COLUMN{0}: {1}={2}", index++, c.Name, c.Value);
            }
        }
        /// <summary>
        /// UNIT TEST Tests the active record set.
        /// </summary>
        [Test]
        public void TestActiveRecordSet()
        {
            var records = new ActiveRecordSet("ACCOUNT_CALLFLOW")
            {
                Instance = DbBaseClass.FNSP,
                Query = "select * from ACCOUNT_CALLFLOW where ACCNT_HRCY_STEP_ID = 105 order by LOB_CD"
            };

            Assert.IsTrue(records.Execute(), records.LastError);

            foreach (ActiveRecord rec in records)
            {
                foreach (var c in rec.Columns)
                    Console.Write("{0} ", c.Value);
                Console.WriteLine();
            }
        }
        /// <summary>
        /// UNIT TEST Tests the address book.
        /// </summary>
        [Test]
        public void TestAddressBookRecord()
        {
            var record = new AddressBookRecord { Instance = DbBaseClass.FNSP, AddressBookEntryId = "4422" };

            Assert.IsTrue(record.Execute(), record.LastError);

            Console.WriteLine("CallflowId:{0} Name:{1} Description:{2}",
                              record.CallflowId, record.FieldName, record.Description);
        }

        /// <summary>
        /// Tests the clone.
        /// </summary>
        [Test]
        public void TestClone()
        {
            var record = new AddressBookRecord { Instance = DbBaseClass.FNSP, AddressBookEntryId = "4422" };

            Assert.IsTrue(record.Execute(), record.LastError);

            var clone = record.Clone() as AddressBookRecord;
            Assert.IsNotNull(clone, "Clone was null!");

            Console.WriteLine("CallflowId:{0} Name:{1} Description:{2}",
                clone.CallflowId, clone.FieldName, clone.Description);
        }

        /// <summary>
        /// Tests the address book array.
        /// </summary>
        [Test]
        public void TestAddressBookArray()
        {
            var records = new AddressBookRecordSet("944") { Instance = DbBaseClass.FNSP };

            Assert.IsTrue(records.Execute(), records.LastError);

            var count = records.Count;

            var arrayList = records.ToArray();

            Assert.IsTrue(arrayList.Count == count, "somethings not right!");

            foreach (AddressBookRecord rec in arrayList)
            {
                Console.WriteLine("{0} {1} {2}",
                                  rec.CallflowId, rec.FieldName, rec.Description);
            }
        }

        /// <summary>
        /// UNIT TEST the address book record set.
        /// </summary>
        [Test]
        public void TestAddressBookRecordSet()
        {
            var records = new AddressBookRecordSet("944") { Instance = DbBaseClass.FNSP };
            Assert.IsTrue(records.Execute(), records.LastError);

            foreach (AddressBookRecord rec in records)
            {
                Console.WriteLine("CallflowId:{0} Name:{1} Description:{2}",
                                  rec.CallflowId, rec.FieldName, rec.Description);
            }
        }

        /// <summary>
        /// Tests the account callfow record.
        /// </summary>
        [Test]
        public void TestAccountCallfowRecord()
        {
            var record = new DbClassLibrary.Callflow.AccountCallflow { Instance = DbBaseClass.FNSP, AccountcallflowId = "5623" };
            Assert.IsTrue(record.Execute(), record.LastError);
            // test expected results
            Assert.IsTrue(record.CallflowId.Equals(5329), UnexpectedValue);
            Assert.IsTrue(record.AccntHrcyStepId.Equals(325), UnexpectedValue);
            Assert.IsTrue(record.LobCd.Equals("WOR"), UnexpectedValue);

            Console.WriteLine("CallflowId:{0} AhsId:{1} LobCd:{2} ActiveStartDate:{3}",
                              record.CallflowId, record.AccntHrcyStepId, record.LobCd, record.ActiveStartDt);
        }
        /// <summary>
        /// Tests the account callfow record set.
        /// </summary>
        [Test, Ignore("Obsolete")]
        public void TestAccountCallfowRecordSet()
        {
            var records = new AccountCallflows { Instance = DbBaseClass.FNSP, AhsId = 6002984, LineOfBusiness = "WOR" };
            Assert.IsTrue(records.Execute(), records.LastError);

            foreach (DbClassLibrary.Callflow.AccountCallflow rec in records)
            {
                // test expected results
                Assert.IsTrue(rec.CallflowId.Equals(4262), UnexpectedValue);
                Assert.IsTrue(rec.AccntHrcyStepId.Equals(6002984), UnexpectedValue);
                Assert.IsTrue(rec.LobCd.Equals("WOR"), UnexpectedValue);

                Console.WriteLine(rec);
            }
        }
        /// <summary>
        /// Tests the transmission outcome record.
        /// </summary>
        [Test]
        public void TestTransmissionOutcomeRecord()
        {
            var record = new TransmissionOutcome { Instance = DbBaseClass.FNSP, TransmissionOutcomeId = "18526432" };
            Assert.IsTrue(record.Execute(), record.LastError);

            // test expected results
            Assert.IsTrue(record.CallId.Equals("14135072"), UnexpectedValue);
            Assert.IsTrue(record.Status.Equals("PROCESSED"), UnexpectedValue);
            Assert.IsTrue(record.RoutingPlanId.Equals("80477"), UnexpectedValue);

            Console.WriteLine("CallId:{0}\nStatus:{1}\nRoutingPlanId:{2}\nCreatedDate:{3}\nLastDestinationString:{4}",
                              record.CallId,
                              record.Status,
                              record.RoutingPlanId,
                              record.CreatedDate,
                              record.LastDestinationString);
        }
        /// <summary>
        /// Tests the transmission outcome step record.
        /// </summary>
        [Test]
        public void TestTransmissionOutcomeStepRecord()
        {
            var record = new TransmissionOutcomeStep { Instance = DbBaseClass.FNSP, XMissionStepId = "24584527" };
            Assert.IsTrue(record.Execute(), record.LastError);
            // test expected results
            Assert.IsTrue(record.TransmissionSeqStepId.Equals("80457"), UnexpectedValue);
            Assert.IsTrue(record.Status.Equals("PROCESSED"), UnexpectedValue);
            Assert.IsTrue(record.TransmissionOutcomeId.Equals("18526432"), UnexpectedValue);
            Assert.IsTrue(record.DestinationString.Equals("bclabaug@wm.com"), UnexpectedValue);
            Assert.IsTrue(record.ServerName.Equals("CHA0A201K"), UnexpectedValue);

            Console.WriteLine("TransmissionSeStepId:{0}\nTransmissionOutcomeId:{1}\nStatus:{2}\nTransmissionTypeId:{3}\nCreatedDate:{4}\nDestinationString:{5}\nServerName:{6}",
                              record.TransmissionSeqStepId,
                              record.TransmissionOutcomeId,
                              record.Status,
                              record.TransmissionTypeId,
                              record.CreatedDate,
                              record.DestinationString,
                              record.ServerName);
        }
        /// <summary>
        /// Tests the tran outcome record record set.
        /// </summary>
        [Test]
        public void TestTranOutcomeRecordRecordSet()
        {
            var records = new TranOutcomeRecordSet { Instance = "FNSBA", Status = "SPECIAL" };
            Assert.IsTrue(records.Execute(), records.LastError);

            foreach (TransmissionOutcome rec in records)
            {
                Console.WriteLine("CallId:{0}\nStatus:{1}\nRoutingPlanId:{2}\nCreatedDate:{3}\nLastDestinationString:{4}",
                                  rec.CallId,
                                  rec.Status,
                                  rec.RoutingPlanId,
                                  rec.CreatedDate,
                                  rec.LastDestinationString);
            }
        }
        /// <summary>
        /// Tests the tran outcome step record set.
        /// </summary>
        [Test]
        public void TestTranOutcomeStepRecordSet()
        {
            var records = new TranOutcomeStepRecordSet { Instance = "FNSBA", OutcomeId = "141468" };
            Assert.IsTrue(records.Execute(), records.LastError);
            Console.WriteLine("************************************");

            foreach (TransmissionOutcomeStep rec in records)
            {
                Console.WriteLine("TransmissionSeStepId:{0}\nTransmissionOutcomeId:{1}\nStatus:{2}\nTransmissionTypeId:{3}\nCreatedDate:{4}\nDestinationString:{5}\nServerName:{6}",
                                  rec.TransmissionSeqStepId,
                                  rec.TransmissionOutcomeId,
                                  rec.Status,
                                  rec.TransmissionTypeId,
                                  rec.CreatedDate,
                                  rec.DestinationString,
                                  rec.ServerName);
                Console.WriteLine("************************************");
            }
        }
        /// <summary>
        /// Tests the transmission seq step record.
        /// </summary>
        [Test]
        public void TestTransmissionSeqStepRecord()
        {
            var record = new TransmissionSequenceStep { Instance = DbBaseClass.FNSP, TransmissionSeqStepId = "80457" };
            Assert.IsTrue(record.Execute(), record.LastError);
            // test expected results
            Assert.IsTrue(record.RoutingPlanId.Equals("80477"), UnexpectedValue);
            Assert.IsTrue(record.Sequence.Equals("1"), UnexpectedValue);
            Assert.IsTrue(record.RetryCount.Equals("3"), UnexpectedValue);
            Assert.IsTrue(record.TransmissionTypeId.Equals("1"), UnexpectedValue);
            Assert.IsTrue(record.DestinationString.Equals("~SPECIFIC_DESTINATION:PHONE~"), UnexpectedValue);

            Console.WriteLine("RoutingPlanId:{0}\nSequence:{1}\nRetryCount:{2}\nTransmissionTypeId:{3}\nAltDestinationString:{4}\nDestinationString:{5}\nRetryWaitTime:{6}",
                              record.RoutingPlanId,
                              record.Sequence,
                              record.RetryCount,
                              record.TransmissionTypeId,
                              record.AltDestinationString,
                              record.DestinationString,
                              record.RetryWaitTime);
        }
        /// <summary>
        /// Tests the tran seq step record set.
        /// </summary>
        [Test]
        public void TestTranSeqStepRecordSet()
        {
            var records = new TranSequenceStepRecordSet { Instance = DbBaseClass.FNSP, RoutingPlanId = "25270", Sequence = "2" };
            Assert.IsTrue(records.Execute(), records.LastError);
            Console.WriteLine("************************************");

            foreach (TransmissionSequenceStep rec in records)
            {
                Console.WriteLine("RoutingPlanId:{0}\nSequence:{1}\nRetryCount:{2}\nTransmissionTypeId:{3}\nAltDestinationString:{4}\nDestinationString:{5}\nRetryWaitTime:{6}",
                                  rec.RoutingPlanId,
                                  rec.Sequence,
                                  rec.RetryCount,
                                  rec.TransmissionTypeId,
                                  rec.AltDestinationString,
                                  rec.DestinationString,
                                  rec.RetryWaitTime);
                Console.WriteLine("************************************");
            }
        }
        /// <summary>
        /// Tests the specific destination record.
        /// </summary>
        [Test]
        public void TestSpecificDestinationRecord()
        {
            var record = new SpecificDestinationRecord { Instance = DbBaseClass.FNSP, SpecificDestinationRecordId = "212403" };
            Assert.IsTrue(record.Execute(), record.LastError);
            // test expected results
            Assert.IsTrue(record.AccntHrcyStepId.Equals("62"), UnexpectedValue);
            Assert.IsTrue(record.NameFirst.Equals("CHARLOTTE"), UnexpectedValue);
            Assert.IsTrue(record.NameLast.Equals("MILLER"), UnexpectedValue);
            Assert.IsTrue(record.Address1.Equals("7915 E ROCKHILL"), UnexpectedValue);
            Assert.IsTrue(record.Zip.Equals("67208"), UnexpectedValue);
            Assert.IsEmpty(record.Title, UnexpectedValue);
            Assert.IsEmpty(record.Phone, UnexpectedValue);

            Console.WriteLine("AccntHrcyStepId:{0}\nNameFirst:{1}\nNameLast:{2}\nAddress1:{3}\nCity:{4}\nState:{5}\nZip:{6}\nTitle:{7}\nPhone:{8}",
                              record.AccntHrcyStepId,
                              record.NameFirst,
                              record.NameLast,
                              record.Address1,
                              record.City,
                              record.State,
                              record.Zip,
                              record.Title,
                              record.Phone);
        }
        /// <summary>
        /// Tests the spec dest seq step record.
        /// </summary>
        [Test]
        public void TestSpecDestSeqStepRecord()
        {
            var record = new SpecificDestSeqStepRecord { Instance = DbBaseClass.FNSP, SpecificDestnSeqStepId = "212403" };
            Assert.IsTrue(record.Execute(), record.LastError);
            // test expected results
            Assert.IsTrue(record.SpecificDestinationId.Equals("212403"), UnexpectedValue);
            Assert.IsTrue(record.Sequence.Equals("1"), UnexpectedValue);
            Assert.IsTrue(record.RetryCount.Equals("3"), UnexpectedValue);
            Assert.IsTrue(record.RetryWaitTime.Equals("180"), UnexpectedValue);
            Assert.IsTrue(record.DestinationString.Equals("\\\\NEWFIL01INGPR\\NEWPTR04OP"), UnexpectedValue);
            Assert.IsTrue(record.AltDestinationString.Equals("\\\\NEWFIL01INGPR\\NEWPTR01QA"), UnexpectedValue);

            Console.WriteLine("SpecificDestinationId:{0}\nSequence:{1}\nRetryCount:{2}\nRetryWaitTime:{3}\nDestinationString:{4}\nAltDestinationString:{5}",
                              record.SpecificDestinationId,
                              record.Sequence,
                              record.RetryCount,
                              record.RetryWaitTime,
                              record.DestinationString,
                              record.AltDestinationString);
        }
        /// <summary>
        /// Tests the spec dest seq step record set.
        /// </summary>
        [Test]
        public void TestSpecDestSeqStepRecordSet()
        {
            var records = new SpecificDestSeqStepRecordSet { Instance = DbBaseClass.FNSP, SpecificDestinationId = "212403" };
            Assert.IsTrue(records.Execute(), records.LastError);
            Console.WriteLine("************************************");

            foreach (SpecificDestSeqStepRecord record in records)
            {
                Console.WriteLine("SpecificDestinationId:{0}\nSequence:{1}\nRetryCount:{2}\nRetryWaitTime:{3}\nDestinationString:{4}\nAltDestinationString:{5}",
                                  record.SpecificDestinationId,
                                  record.Sequence,
                                  record.RetryCount,
                                  record.RetryWaitTime,
                                  record.DestinationString,
                                  record.AltDestinationString);
                Console.WriteLine("************************************");
            }
        }
        /// <summary>
        /// Tests the user record.
        /// </summary>
        [Test]
        public void TestUserRecord()
        {
            var record = new UserRecord { Instance = DbBaseClass.FNSP, UserId = 27342 };
            Assert.IsTrue(record.Execute(), record.LastError);
            Assert.IsTrue(record.UserName.Equals("JCHEUNG16"), "Unexpected results!");

            Console.WriteLine("UserId:{0} UserName:{1} First:{2} Last:{3}",
                              record.UserId, record.UserName, record.FirstName, record.LastName);
        }
        /// <summary>
        /// Tests the insert.
        /// </summary>
        [Test]
        public void TestInsert()
        {
            var record = new TransmissionOutcomeStep { Instance = "FNSBA" };
            record.XMissionStepId = Sequence.GetNextSequence(record.Name, record.Instance);
            record.TransmissionSeqStepId = "80449";
            record.Status = "TEST";
            record.TransmissionOutcomeId = "142114";
            record.DestinationString = "john_gwynn@firstnotice.com";
            record.ServerName = "CHA1ND110";
            record.TransmissionTypeId = "7";
            Assert.IsTrue(record.Insert(), record.LastError);
        }
        /// <summary>
        /// Tests the get next sequence.
        /// </summary>
        [Test]
        public void TestGetNextSequence()
        {
            var seq = new Sequence("TRANSMISSION_OUTCOME_STEP") { Instance = "FNSBA" };
            Assert.IsTrue(seq.Execute(), seq.LastError);
            Console.WriteLine("Next Sequence is {1}  for TABLE: {0}",
                              seq.Name, seq.NextValue);

        }
        /// <summary>
        /// Tests the copy attributes.
        /// </summary>
        [Test]
        public void TestCopyAttributes()
        {
            var records = new CopyAttributesRecordSet { Instance = "FNSBA", GroupName = "TEST" };
            Assert.IsTrue(records.Execute(), records.LastError);
            Console.WriteLine("************************************");

            foreach (CopyAttributesRecord record in records)
            {
                Console.WriteLine("Id:{0}\nGroupName:{1}\nAttribute:{2}\nDefault:{3}\nOverride:{4}",
                                  record.CopyAttributesId,
                                  record.GroupName,
                                  record.AttributeName,
                                  record.DefaultValue,
                                  record.Override);
                Console.WriteLine("************************************");
            }
        }
        /// <summary>
        /// Tests the auto make record.
        /// </summary>
        [Test, Ignore("Obsolete")]
        public void TestAutoMakeRecord()
        {
            var record = new AutoMakeRecord { Instance = "ESUP", MakeCode = "17" };
            Assert.IsTrue(record.Execute(), record.LastError);

            Console.WriteLine("Make Code: {0}, Description: {1}", record.MakeCode, record.MakeDescription);
        }
        /// <summary>
        /// Tests the auto model record.
        /// </summary>
        [Test, Ignore("Obsolete")]
        public void TestAutoModelRecord()
        {
            var record = new AutoModelRecord { Instance = "ESUP", AutoModelId = "5681" };
            Assert.IsTrue(record.Execute(), record.LastError);

            Console.WriteLine("Make Code: {0}, Model Code: {1}, Description: {2}",
                              record.MakeCode, record.ModelCode, record.ModelDescription);
        }
        /// <summary>
        /// Tests the auto make record set.
        /// </summary>
        [Test, Ignore("Obsolete")]
        public void TestAutoMakeRecordSet()
        {
            var records = new AutoMakeRecordSet { Instance = "ESUP" };
            Assert.IsTrue(records.Execute(), records.LastError);
            Console.WriteLine("************************************");
            foreach (AutoMakeRecord record in records)
            {
                Console.WriteLine("Make Code: {0}, Description: {1}", record.MakeCode, record.MakeDescription);
            }
            Console.WriteLine("************************************");
        }
        /// <summary>
        /// Tests the auto model record set.
        /// </summary>
        [Test, Ignore("Obsolete")]
        public void TestAutoModelRecordSet()
        {
            var records = new AutoModelRecordSet { Instance = "ESUP", MakeCode = "7" };
            Assert.IsTrue(records.Execute(), records.LastError);
            Console.WriteLine("************************************");
            foreach (AutoModelRecord record in records)
            {
                Console.WriteLine("Make Code: {0}, Model Code: {1}, Description: {2}",
                                  record.MakeCode, record.ModelCode, record.ModelDescription);
            }
            Console.WriteLine("************************************");
        }
        /// <summary>
        /// Tests to XML.
        /// </summary>
        [Test, Ignore("Obsolete")]
        public void TestToXml()
        {
            var records = new AutoMakeRecordSet { Instance = "ESUP" };
            Assert.IsTrue(records.Execute(), records.LastError);
            var results = records.ToXml();
            Assert.IsNotEmpty(results, "Empty results!");
            Console.WriteLine("****************************************");
            Console.WriteLine(results);
            Console.WriteLine("****************************************");
        }
        /// <summary>
        /// Tests the us states.
        /// </summary>
        [Test, Ignore("Obsolete")]
        public void TestUsStates()
        {
            var states = UsStateRecordSet.GetUsStates();
            Assert.IsTrue(states.Count >= 51);
            foreach (var s in states)
            {
                Console.WriteLine("{0} {1}", s.StateCode, s.StateName);
            }
        }
        /// <summary>
        /// Tests the rule record.
        /// </summary>
        [Test]
        public void TestRuleRecord()
        {
            var record = new RuleRecord { Instance = "SEDQA", RuleId = "-103" };
            Assert.IsTrue(record.Execute(), record.LastError);
            Assert.IsTrue(record.RuleText.Equals(RuleRecord.GetRuleTextForRuleId(record.RuleId, record.Instance)), "Something is wrong!");

            Console.WriteLine("Rule Text: {0}, Rule Type: {1}, Language Type Code: {2} Comment: {3} Created: {4}",
                              record.RuleText, record.RuleType, record.LanguageTypeCode, record.Comments, record.CreatedDate);
        }
        /// <summary>
        /// Tests the rule list.
        /// </summary>
        [Test]
        public void TestRuleList()
        {
            var records = RuleRecordSet.GetRuleSetByClientAndEvent("18", "CLOSE", "SEDBA");
            Assert.IsTrue(records.Count >= 1, "Problems!");
            foreach (var record in records)
            {
                Assert.IsTrue(record.RuleText.Equals(RuleRecord.GetRuleTextForRuleId(record.RuleId, record.Instance)),
                              "Something is wrong!");
                Console.WriteLine("Rule Text: {0}\r\n Rule Type: {1}, Language Type Code: {2} Comment: {3} Created: {4}",
                                  record.RuleText, record.RuleType, record.LanguageTypeCode, record.Comments, record.CreatedDate);
            }
        }
        /// <summary>
        /// Tests the insert call XML.
        /// </summary>
        [Test, Ignore("Obsolete")]
        public void TestInsertCallXml()
        {
            //Assert.IsTrue(CallXmlRecord.InsertCallXml("2", "<CALL><HELLO>Hello World</HELLO></CALL>", DbBaseClass.ESUBA),"Insert Failed!");
            var record = new CallXmlRecord();
            const string realCallData = "<CALL><ENTRY_POINT_ID>24</ENTRY_POINT_ID><CALL_END_DATE>07/11/2007</CALL_END_DATE><SERVER_NAME>172.27.6.59</SERVER_NAME><CALL_ID>1</CALL_ID><USER_ID>1231</USER_ID><ACCOUNT_TYPE_CD>I</ACCOUNT_TYPE_CD><INPUT_SYSTEM>FNS NET</INPUT_SYSTEM><LOCATION>1111</LOCATION><INTERNETUSER>N</INTERNETUSER><CLIENT_ID>24</CLIENT_ID><CALLER_INFO>D D at </CALLER_INFO><USER_NAME>DEVELOPER</USER_NAME><USERNAME>DEVELOPER</USERNAME><CARRIER_CODE>ESR</CARRIER_CODE><LOB_CD>PAU</LOB_CD><CALL_START_TIME>10:16:33 AM</CALL_START_TIME><CALL_START_DATE>07/11/2007</CALL_START_DATE><CALL_END_TIME>10:19:09 AM</CALL_END_TIME><CALL_STATUS>ABORTED</CALL_STATUS><CLAIM><LOSS_DATE>01012007</LOSS_DATE><LOSS_TIME>1111AM</LOSS_TIME><REPORTED_DT>07112007</REPORTED_DT></CLAIM><CALLER><NAME_FIRST>D</NAME_FIRST><NAME_LAST>D</NAME_LAST></CALLER></CALL>";
            Assert.IsTrue(CallXmlRecord.UpdateCallXml("1", realCallData, DbBaseClass.ESUBA), "Insert Failed!");
            record.CallId = "1";
            record.Instance = DbBaseClass.ESUBA;
            Assert.IsTrue(record.Execute(), record.LastError);
            Console.WriteLine(record.CallXml);
        }

        /// <summary>
        /// Tests the get call XML.
        /// </summary>
        [Test, Ignore("Obsolete")]
        public void TestGetCallXml()
        {
            var callXml = CallXmlRecord.GetCallXml("1008129", DbBaseClass.ESUBA);
            Assert.IsNotEmpty(callXml, "GetCallXml Failed!");
            Console.WriteLine(callXml);
        }

        /// <summary>
        /// Tests the ahs active record set.
        /// </summary>
        [Test]
        public void TestAhsActiveRecordSet()
        {
            var records = new AhsActiveRecordSet
            {
                Instance = DbBaseClass.FNSP,
                Query =
                                "Select * from AHS where client_node_id = 202 and type = 'RISK LOCATION' and FEIN = '362386411' "
            };
            Assert.IsTrue(records.Execute(), records.LastError);
            Console.WriteLine("************************************");

            foreach (var rec in records)
            {
                Console.WriteLine("AHSID:{0}\nNAME:{1}\nLOCATION CODE:{2}\nADDRESS1:{3}\nCITY:{4}\nSTATE:{5}",
                                  rec.AccntHrcyStepId,
                                  rec.FullName,
                                  rec.LocationCode,
                                  rec.Address1,
                                  rec.City,
                                  rec.State);
                Console.WriteLine("************************************");
            }
        }
        /// <summary>
        /// Tests the state fraud.
        /// </summary>
        [Test, Ignore("Obsolete")]
        public void TestStateFraud()
        {
            var results = StateFraud.GetScriptByStateCode("NY", DbBaseClass.ESUBA);
            Assert.IsNotEmpty(results, "Nothing returned!");
            Console.WriteLine(results);
        }
        /// <summary>
        /// Tests the anti steering.
        /// </summary>
        [Test, Ignore("Obsolete")]
        public void TestAntiSteering()
        {
            var results = StateAntiSteering.GetTextByStateCode("NY", DbBaseClass.ESUBA);
            Assert.IsNotEmpty(results, "Nothing returned!");
            results = StateAntiSteering.GetClosingTextByStateCode("CA", DbBaseClass.ESUBA);
            Assert.IsNotEmpty(results, "Nothing returned!");
            Assert.IsTrue(StateAntiSteering.StateSteeringAcknowledgment("NY", DbBaseClass.ESUBA), "NY Steering Ack is FALSE!");
            Assert.IsTrue(StateAntiSteering.StateClosingAcknowledgment("NC", DbBaseClass.ESUBA), "NC Closing Ack is FALSE!");
        }
        /// <summary>
        /// Inserts the new outcome for calls.
        /// </summary>
        [Test]
        [Ignore("Obsolete")]
        public void InsertNewOutcomeForCalls()
        {
            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (var sr = new StreamReader(@"c:\fns2005\bin\EsisCalls.csv"))
                {
                    // ReSharper disable RedundantAssignment
                    var line = sr.ReadLine();
                    // ReSharper restore RedundantAssignment
                    // Read and display lines from the file until the end of 
                    // the file is reached.
                    while ((line = sr.ReadLine()) != null)
                    {
                        var current = line.Split(",".ToCharArray());
                        if (current.Length >= 2)
                        {
                            InsertNewOutcome(current[0], current[1]);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        /// <summary>
        /// Tests the insert session data.
        /// </summary>
        [Test, Ignore("Obsolete")]
        public void TestInsertSessionData()
        {
            var data = new SessionData
            {
                Instance = DbBaseClass.ESUBA,
                SessionKey = "TEST",
                SessionName = "POLICY_ID",
                SessionValue = "111222333"
            };
            Assert.IsTrue(data.Insert(), data.LastError);

            var records = new SessionDataRecordSet("TEST") { Instance = DbBaseClass.ESUBA };
            Assert.IsTrue(records.Execute(), records.LastError);
            foreach (SessionData session in records)
                Console.WriteLine("{0}: {1}={2}", session.SessionKey, session.SessionName, session.SessionValue);
        }

        /// <summary>
        /// Tests the update session data.
        /// </summary>
        [Test, Ignore("Obsolete")]
        public void TestUpdateSessionData()
        {
            Assert.IsTrue(SessionData.UpdateSessionData("TEST", "POLICY_ID", "666777888"), "Something is wrong!");
        }

        /// <summary>
        /// Tests the call id from session.
        /// </summary>
        [Test, Ignore("Obsolete")]
        public void TestCallIdFromSession()
        {
            Assert.IsTrue(SessionKey.GetCallIdFromSession("12345678901234567890") == "1234567890");
        }

        /// <summary>
        /// Tests the insert session key.
        /// </summary>
        [Test, Ignore("Obsolete")]
        public void TestInsertSessionKey()
        {
            var key = new SessionKey("12345678901234567890") { Instance = DbBaseClass.ESUBA, CallId = "1234567890" };
            Assert.IsTrue(key.Insert(), key.LastError);

            var results = new SessionKey("1234567890");
            Assert.IsTrue(results.Execute(), results.LastError);
            Assert.IsTrue(results.CallId == "1234567890", "CallId failed!");
            Assert.IsTrue(results.Key == "12345678901234567890", "Key failed!");

            Assert.IsTrue(key.Delete(), key.LastError);

            var results2 = new SessionKey("1234567890");
            Assert.IsTrue(results2.Execute(), results.LastError);

        }

        /// <summary>
        /// 
        /// </summary>
        //[Test]
        //public void TestUsers()
        //{
        //  string userId = Users.GetUserIdFromUserName("IFTCO", "FNSBA");
        //  Assert.IsNotEmpty(userId, "Nothing returned!");
        //  Console.WriteLine(userId);
        //}

        /// <summary>
        /// Inserts the new outcome.
        /// </summary>
        /// <param name="callId">The call id.</param>
        /// <param name="routingPlanId">The routing plan id.</param>
        private static void InsertNewOutcome(string callId, string routingPlanId)
        {
            var outcome = new TransmissionOutcome
            {
                Instance = DbBaseClass.ESUBA,
                CallId = callId,
                RoutingPlanId = routingPlanId,
                Status = "INSERT"
            };

            Assert.IsTrue(outcome.Insert(), outcome.LastErrorText);
        }

        /// <summary>
        /// 
        /// </summary>
        [Test]
        public void TestCallFlow()
        {
            var frames = new FrameSet { Instance = "SEDBA", AhsId = 18, LineOfBusiness = "AL" };

            Assert.IsTrue(frames.Execute(), frames.LastError);
            foreach (var frame in frames)
            {
                Console.WriteLine("{0} {1} {2} {3} {4}", frame.FrameName, frame.FrameDecription, frame.Title, frame.Type, frame.Sequence);
                if (!frame.FrameName.Equals("CLAIM:INSURED:VEHICLE:INFORMATION")) continue;
                foreach (var a in frame.Attributes)
                    Console.WriteLine("    {0} {1} {2} {3} {4} {5} {6} {7} {8}",
                                      a.AttribName, a.Caption, a.InputType, a.Description, a.Sequence,
                                      a.Xpos, a.Ypos, a.Width, a.Height);
            }
        }

        [Test]
        public void TestCallflowResults()
        {
            var frames = new FrameSet { Instance = "SEDBA", AhsId = 18, LineOfBusiness = "AL" };
            foreach (var frame in frames.Results().Where(a => a.Sequence > 0).OrderBy(a => a.Sequence))
            {
                var result = new ResultFrame
                {
                    Id = frame.FrameId,
                    Name = frame.FrameName,
                    Title = frame.Title,
                    Sequence = frame.Sequence,
                    Attributes = frame.Attributes.Select(a => new ResultAttribute
                    {
                        Id = a.AttributeId,
                        Description = a.Description,
                        Caption = a.Caption,
                        EnabledRule = a.EnabledRuleText,
                        Sequence = a.Sequence,
                        Mask = a.EntryMask,
                        Type = a.Type,
                        Width = a.Width,
                        Xpos = a.Xpos,
                        Ypos = a.Ypos
                    }).ToArray()
                };

                Console.WriteLine("Frame {0}, Title {1}, Id {2} Attribute Count: {3}", result.Sequence, result.Title, result.Id, result.Attributes.Count());
            }

        }

        [Test]
        public void TestCallflowLinqResults()
        {
            var db = new Database();
            var query = from c in db.Callflowview
                        where c.AccntHrcyStepId == 18 && c.LobCode == "AL"
                        join x in db.Attributeview on c.FrameId equals x.FrameId
                        select new
                        {
                            Id = c.FrameId,
                            Name = c.FrameName,
                            Attribute = x.AttribName
                        };


            foreach (var item in query)
                ObjectDumper.Write(item);


        }
        /// <summary>
        /// Tests the name of the lu type from.
        /// </summary>
        [Test]
        public void TestLuTypeFromName()
        {
            var results = LookupCodes.GetLookupTypeIdByName("Call Types");
            Assert.IsTrue(results.Length > 0, "Nothing returned!");
            Console.WriteLine(results);
        }

        /// <summary>
        /// Tests the lookup codes.
        /// </summary>
        [Test, Ignore("Obsolete")]
        public void TestLookupCodes()
        {
            foreach (LookupCode c in LookupCodes.LookupByTypeName("NCCI Type of Injury"))
                Console.WriteLine("{0} {1} {2}", c.Code, c.LookupValue, c.Sequence);
        }

        /// <summary>
        /// Tests the lookup codes XML.
        /// </summary>
        [Test]
        public void TestLookupCodesXml()
        {
            var lookupId = int.Parse(LookupCodes.GetLookupTypeIdByName("NCCI Type of Injury"));
            var codes = LookupCodes.GetLookupCodesByTypeId(lookupId);

            foreach (LookupCode code in codes)
            {
                Console.WriteLine(code.ToXml());
                break;
            }

            var codesFromCache = LookupCodes.GetLookupCodesByTypeId(lookupId);
            Console.WriteLine(codesFromCache.ToXml());

        }

        /// <summary>
        /// Tests the user.
        /// </summary>
        [Test, Ignore("Obsolete")]
        public void TestUser()
        {
            var me = User.GetUser("DEVELOPER", "DEVELOPER", DbBaseClass.ESUBA);
            Assert.IsNotNull(me, "Nothing returned.");
            Assert.IsEmpty(me.LastError, me.LastError);
            Console.WriteLine("User {0} Account: {1} Permissions: {2}", me.UserName, me.Account.FullName, me.GroupPermissions);
            var permissions = new AccessListManager(me.GroupPermissions);
            Assert.IsTrue(permissions.CheckAccessType("FNSD_REPORTS", "ADD"), "Check failed for FNSD_REPORTS:ADD");
            Assert.IsFalse(permissions.CheckAccessType("SYSTEM MONITOR", "ADD"), "Check failed for SYSTEM MONITOR:ADD");
            Assert.IsTrue(permissions.CheckAccessType("END SESSION", "VIEW"), "Check failed for END SESSION:VIEW");
            Assert.IsFalse(permissions.CheckAccessType("END SESSION", "NONE"), "Check failed for END SESSION:NON");
        }

        /// <summary>
        /// Tests the account location.
        /// </summary>
        [Test]
        public void TestAccountLocation()
        {
            var records = new ActiveRecordSet
            {
                Instance = "FNSBA",
                Query = "SELECT location_ahsid as LOCATIONAHSID FROM Locations_user WHERE account_User_id = :user_id"
            };
            records.AddParameter("user_id", 3851);
            Assert.IsTrue(records.Execute(), records.LastError);
            records.MoveNext();
            Console.WriteLine(records[0]);

        }

        /// <summary>
        /// Tests the get sys date.
        /// </summary>
        [Test]
        public void TestGetSysDate()
        {
            string results = GeneralUtility.GetSysdateAsString();
            Assert.IsNotEmpty(results, "Nothing returned!");
            Console.WriteLine(results);
        }

        /// <summary>
        /// Tests the call data.
        /// </summary>
        [Test, Ignore("Obsolete")]
        public void TestCallData()
        {
            var callData = new CallData { Instance = "SEDBA", CallId = 4886 };
            Assert.IsTrue(callData.Execute(), callData.LastError);
            Assert.IsTrue(callData.Data.Length > 0, "Nothing returned!");

            var blobData = new CallDataB { Instance = callData.Instance, CallId = callData.CallId };

            Assert.IsTrue(blobData.Save(callData.Data.Length, callData.Data), blobData.LastError);

        }

        /// <summary>
        /// Tests the import types.
        /// </summary>
        [Test]
        public void TestImportTypes()
        {
            foreach (var t in ImportRecordType.GetRecordTypes("FNSBA"))
                Console.WriteLine("{0}- {1}", t.FroiImpRecordType, t.FroiImpRecordDecription);

        }
        /// <summary>
        /// Tests the froi map fields.
        /// </summary>
        [Test]
        public void TestFroiMapFields()
        {
            var fields = FroiImportField.GetImportFieldsByRecordType("EXCL", "FNSBA");
            foreach (FroiImportField t in fields)
            {
                Console.WriteLine("{0} {1}", t.AttributeName, t.StartPosition);
            }
        }

        /// <summary>
        /// Tests the froi map insert update delete.
        /// </summary>
        [Test, Ignore("Obsolete")]
        public void TestFroiMapInsertUpdateDelete()
        {
            var fieldCount = FroiImportField.GetImportFieldsByRecordType("TEST", "FNSBA").Count;
            var field = new FroiImportField
            {
                Instance = DbBaseClass.FNSBA,
                AttributeName = "AhsRecord.AhsId",
                DefaultValue = "202",
                FroiImpRecordId = 13,
                FroiFileDefId = 4,
                LegacyFieldName = "ACCNT_HRCY_STEP_ID",
                StartPosition = 3,
                Length = 0
            };

            Assert.IsTrue(field.Insert(), field.LastError);
            var fields = FroiImportField.GetImportFieldsByRecordType("TEST", "FNSBA");

            Assert.IsTrue(fields.Count == fieldCount + 1, "something is wrong!");

            foreach (FroiImportField t in fields)
            {
                Console.WriteLine("Deleteing: {0} {1}", t.Id, t.AttributeName);
                Assert.IsTrue(t.Delete(), t.LastError);
            }

            fields = FroiImportField.GetImportFieldsByRecordType("TEST", "FNSBA");
            Assert.IsTrue(fields.Count == 0, "something is wrong!");
        }

        /// <summary>
        /// Tests the employee.
        /// </summary>
        [Test]
        public void TestEmployee()
        {
            var employee = DbClassLibrary.ActiveRecords.Employee.GetEmployeeBySsn(DbBaseClass.SEDP, "020528833");
            Assert.IsEmpty(employee.LastError, employee.LastError);
            Console.WriteLine(employee);
            foreach (var key in employee.ExtensionAttributes.Keys)
                Console.WriteLine("{0}={1}", key, employee.ExtensionAttributes[key]);
        }

        [Test]
        public void TestGetEmployeeByClientNumberAndEmployeeCode()
        {
            var employee = DbClassLibrary.ActiveRecords.Employee.GetEmployeeByClientNumberAndEmployeeCode(DbBaseClass.SEDPP, "8735", "00128069");
            Assert.IsEmpty(employee.LastError, employee.LastError);
            Console.WriteLine(employee);
        }

        [Test]
        public void TestKrogerGetRiskLocationByAccountIdInsuredLocation()
        {
            var accountId = AhsActiveRecordSet.GetActiveAhsIdByTypeAndLocationCode("ACCOUNT", "1978"); // KROGER
            Assert.IsTrue(accountId == "20969");
            var locationId = AhsActiveRecordSet.GetRiskLocationByAccountIdInsuredLocation(accountId, "19780027", "R748");
            Assert.IsNotEmpty(locationId);
            Console.WriteLine(locationId);

        }

        /// <summary>
        /// Tests the employees.
        /// </summary>
        [Test]
        public void TestEmployees()
        {
            var employees = new Employees { Instance = DbBaseClass.FNSP, Query = "select * from employee where ssn = :ssn" };
            employees.AddParameter("ssn", "593720361");
            Assert.IsTrue(employees.Execute(), employees.LastError);
            foreach (var employee in employees)
            {
                Assert.IsTrue(employee.Ssn == "593720361");
                Assert.IsTrue(employee.ClientNumber == "211");
                Assert.IsTrue(employee.NameLast == "NAGY");
            }
        }

        /// <summary>
        /// Tests the location codes.
        /// </summary>
        [Test, Ignore("Obsolete")]
        public void TestLocationCodes()
        {
            ValidateLocationFromZip(LocationCodes.GetZipFromCityState("CHURCH STREET BOXES", "NY"));
            ValidateLocationFromZip("10249-0000");
            ValidateLocationFromZip("C1A4W5");
        }
        /// <summary>
        /// Tests the ahs records by upload key.
        /// </summary>
        [Test]
        public void TestAhsRecordsByUploadKey()
        {
            var comcast = new AhsActiveRecord { Instance = DbBaseClass.SEDP, AccntHrcyStepId = "2755143" };
            Assert.IsTrue(comcast.Execute());
            Console.WriteLine(comcast);
            Assert.IsNotNull(AhsActiveRecord.GetAhsActiveRecordByUploadKey(comcast.UploadKey, DbBaseClass.SEDP));
        }





        private static void ValidateLocationFromZip(string zipCode)
        {
            var location = LocationCodes.GetPrimaryLocationCodeForZip(zipCode);
            Assert.IsNotNull(location, "Nothing returned for " + zipCode);
            Assert.IsTrue(location.City == LocationCodes.GetCityFromZip(zipCode));
            Assert.IsTrue(location.State == LocationCodes.GetStateFromZip(zipCode));
            Assert.IsTrue(location.Fips == LocationCodes.GetFipsFromZip(zipCode));
            Assert.IsTrue(location.County == LocationCodes.GetCountyFromZip(zipCode));
            Assert.IsTrue(location.Country == LocationCodes.GetCountryFromZip(zipCode));
            Assert.IsTrue(location.Lat == LocationCodes.GetLatitudeFromZip(zipCode));
            Assert.IsTrue(location.Lon == LocationCodes.GetLongitudeFromZip(zipCode));
        }

        /// <summary>
        /// Tests the sedgwick employee with supervisor.
        /// </summary>
        [Test]
        public void TestSedgwickEmployeeWithSupervisor()
        {
            var employee = DbClassLibrary.ActiveRecords.Employee.GetEmployeeByClientNumberAndEmployeeCode("SEDP", "2548", "361129");
            Assert.IsTrue(employee.ExtensionAttributes.ContainsKey("CLAIM:EMPLOYEE:FULL_PART_TIME"), "failed!");
            Console.WriteLine("{0} {1}", employee.NameLast, employee.ExtensionAttributes["CLAIM:EMPLOYEE:FULL_PART_TIME"]);
        }

        /// <summary>
        /// Tests the sentry rules for estimator.
        /// </summary>
        [Test, Ignore("Obsolete")]
        public void TestSentryRulesForEstimator()
        {
            var rules = new RuleRecordSet { Instance = "SENP", Query = "select * from Rules" };
            Assert.IsTrue(rules.Execute(), rules.LastError);

            var results = from RuleRecord rule in rules
                          where rule.RuleText.Contains("setValue")
                          select new { rule.RuleId, rule.RuleText };

            foreach (var record in results)
                Console.WriteLine(record);
        }

        /// <summary>
        /// Tests the call routing queries.
        /// </summary>
        [Test]
        public void TestCallRoutingQueries()
        {
            var routings = new CallRoutings
            {
                Instance = DbBaseClass.FNSQA,
                Query = "select * from call_routing where routing_status = 'SPECIAL'"
            };
            Assert.IsTrue(routings.Execute(), routings.LastError);

            var routingIds = new Stack<string>();

            foreach (var routing in routings)
            {
                Console.WriteLine(routing);

                routingIds.Push(routing.CallRoutingId);
                var status = new ChangeCallRoutingStatus
                {
                    CurrentDbInstance = DbBaseClass.FNSQA,
                    CallRoutingId = routing.CallRoutingId,
                    OldStatus = routing.RoutingStatus,
                    NewStatus = "TEST",
                    ServerName = Environment.MachineName
                };

                Assert.IsTrue(status.Execute(), status.LastError);
                Assert.IsTrue(status.Result, "Lock failed!");
            }

            routings.Reset();
            routings.Execute();
            Assert.IsTrue(routings.Count == 0, "Something is wrong!");

            foreach (var id in routingIds)
                GeneralUtility.ExecuteNonQuery(
                  "update call_routing set routing_status = 'SPECIAL' where call_routing_id = " + id, DbBaseClass.FNSQA);
        }

        /// <summary>
        /// Tests the user results.
        /// </summary>
        //[Test]
        //public void TestUserResults()
        //{
        //  var users = new Users { Instance = "ESUBA", Query = "select * from users where user_id = :1" };
        //  users.AddParameter("1251");

        //  var results = from user in users.Results()
        //                select user;

        //  foreach (var u in results)
        //    Console.WriteLine(u);
        //}

        /// <summary>
        /// Tests the ahs timer results.
        /// </summary>
        [Test, Ignore("Obsolete")]
        public void TestAhsTimerResults()
        {
            var accounts = new AhsActiveRecordSet
            {
                Instance = "FNSP",
                Query = "select * from account_hierarchy_step where parent_node_id = :1 and type = 'ACCOUNT' and active_status = 'ACTIVE'"
            };

            accounts.AddParameter("202");


            var results = from account in accounts.Results()
                          orderby account.FullName
                          select new { account.AccntHrcyStepId, account.FullName, account.LocationCode };

            var timer = new Stopwatch();
            timer.Start();

            foreach (var record in results)
            {
                var ahsId = record.AccntHrcyStepId;

                var locations = new AhsActiveRecordSet
                {
                    Instance = "FNSP",
                    Query = "select * from account_hierarchy_step where type = 'RISK LOCATION' and active_status = 'ACTIVE' " +
                                            "start with accnt_hrcy_Step_id = " + ahsId + " connect by prior accnt_hrcy_step_id = parent_node_id"

                };

                var locationCount = (from r in locations.Results() select r).Count();

                Console.WriteLine("{0} {1} {2} Locations: {3}", record.AccntHrcyStepId, record.FullName,
                                  record.LocationCode, locationCount);
            }
            timer.Stop();
            Console.WriteLine(timer.ElapsedMilliseconds);
        }

        /// <summary>
        /// Tests the narragansett policy.
        /// </summary>
        //[Test]
        //public void TestNarragansettPolicy()
        //{
        //  var policies = DbClassLibrary.ActiveRecords.Policy.GetActivePolicies("444", "PPR", "3D20000025", "03/01/2010",
        //                                                        DbBaseClass.FNSP);
        //  foreach (var policy in policies)
        //  {
        //    Console.WriteLine(policy);
        //    if (policy.Agent != null)
        //      Console.WriteLine(policy.Agent);
        //    if (policy.RiskLocation == null) continue;
        //    Console.WriteLine(policy.RiskLocation);
        //    if (policy.RiskLocation.ParentNode != null)
        //      Console.WriteLine(policy.RiskLocation.ParentNode);
        //    foreach (var extension in policy.Extensions)
        //      Console.WriteLine(extension);
        //  }
        //}

        /// <summary>
        /// Tests the policy insureds.
        /// </summary>
        [Test]
        public void TestPolicyInsureds()
        {
            var policies = DbClassLibrary.ActiveRecords.Policy.GetActivePoliciesFromTree("27187503", "PPR", DbBaseClass.FNSP);
            foreach (var policy in policies)
            {
                Console.WriteLine(policy);
                if (policy.Agent != null)
                    Console.WriteLine(policy.Agent);
                if (policy.RiskLocation == null) continue;
                Console.WriteLine(policy.RiskLocation);
                if (policy.RiskLocation.ParentNode != null)
                    Console.WriteLine(policy.RiskLocation.ParentNode);
            }
        }

        /// <summary>
        /// Tests the config settings.
        /// </summary>
        [Test]
        public void TestConfigSettings()
        {
            var settings = new DbClassLibrary.ActiveRecords.ConfigSettings
            {
                Instance = DbBaseClass.ESUBA,
                Query = "select * from config_settings where KEY = :key"
            };
            settings.AddParameter("key", "UseNetworkCredentials");
            const string weakKey = "NUNIT";
            const string strongKey = "CHA1ND110.NUNIT";

            var listResults =
              settings.Results().Where(a => a.Application.ToUpper().Contains(weakKey)).ToList();

            var result = listResults
                          .Where(a => a.Application.ToUpper() == strongKey)
                          .Select(a => a.ConfigValue).FirstOrDefault() ??
                         listResults
                          .Where(a => a.Application.ToUpper() == weakKey)
                          .Select(a => a.ConfigValue).FirstOrDefault();

            Console.WriteLine(result);

        }

        [Test]
        public void TestCallRecords()
        {
            var records = new CallRecords
            {
                Instance = DbBaseClass.ESUP,
                Query =
                                "select c.* from call c, call_xml x where x.call_id = c.call_id and status = 'INPROC' order by 1"
            };
            foreach (CallRecord call in records.Results())
                Console.WriteLine(call);
        }

        [Test, Ignore("Obsolete")]
        public void TestSessionKeyDirty()
        {
            const string callId = "12345";
            const string sessionKey = "123456789011121313334";
            //Assert.IsTrue(SessionKey.InsertSessionKey(callId, sessionKey));
            var current = SessionKey.GetSession(sessionKey);
            Assert.IsNotNull(current);
            Assert.IsTrue(current.CallId == callId);
            Assert.IsFalse(SessionKey.IsDirty(current));
            Assert.IsTrue(current.Update());
            Assert.IsTrue(SessionKey.IsDirty(current));
        }

        [Test, Ignore("Obsolete")]
        public void TestHasCallXml()
        {
            Assert.IsTrue(CallXmlRecord.HasCallXml("1006341", DbBaseClass.ESUBA));
            Assert.IsFalse(CallXmlRecord.HasCallXml("1006345", DbBaseClass.ESUBA));
        }

        [Test]
        public void TestMiamidateClaims()
        {
            var claims = new MiamiDadeClaimArchives { ClaimantTaxId = "592012385" };
            foreach (var claim in claims.Results())
                Console.WriteLine(claim);
        }

        [Test]
        public void TestGreetings()
        {
            var records = new Greetings { Instance = DbBaseClass.SEDBA, ContractNumber = "8532" };
            //Assert.AreEqual(records.Results().Count(), 2);
            foreach (var record in records.Results())
                Console.WriteLine(record);
        }

        [Test]
        public void TestAllGreetings()
        {
            var records = new Greetings { Instance = DbBaseClass.SEDBA };
            Assert.IsTrue(records.Results().Count() >= 325);
        }

        [Test, Ignore("Obsolete")]
        public void TestLobCodes()
        {
            //var records = Greetings.GetLobCodes("2058", "2617");
            //Assert.IsNull(records, "Nothing returned.  Run only in SEDQA!");
            //Assert.IsTrue(records == "AL  - Auto Liability");
            //Console.WriteLine(records);
            //records = Greetings.GetLobCodes("1231", "6107");
            //Assert.IsTrue(records == "WC  - Workers Compensation");
            //Console.WriteLine(records);
        }

        [Test]
        public void TestServers()
        {
            var servers = new Servers { Filter = "INSTANCE = 'fnsp'", Order = "ROLE, SERVER_NAME" }.Results();
            foreach (var server in servers)
                Console.WriteLine(server);
        }

        [Test]
        public void TestDestinationStatus()
        {
            var destinations = new DestinationStatusRecords { DestinationString = "TEST%" }.Results().ToList();
            Assert.IsTrue(destinations.Count() == 1);
            foreach (var destination in destinations)
                Console.WriteLine(destination);
            var results = new DestinationStatusRecords { Query = "select * from DESTINATION_STATUS " }.Results().ToList();
            Assert.IsTrue(results.Count() == 1);
            foreach (var destination in results)
                Console.WriteLine(destination);
        }

        [Test, Ignore("Obsolete")]
        public void TestServerInsertUpdateDelete()
        {
            const string testInstance = "test";
            var test = new Server
            {
                ServerName = "new1nlmac",
                DatabaseInstance = testInstance,
                Role = "developer",
                IpAddress = "127.0.0.1",
                Uri = "http//new1nlmac/ClaimCapture",
                Description = "Developer Test"
            };
            Assert.IsTrue(test.Insert(), test.LastError);
            var current = new Servers { Filter = "INSTANCE='test'" }.Results().FirstOrDefault();
            Assert.IsNotNull(current, "current returned nothing!");
            Assert.IsTrue(current.ServerId > 0, "serverId not set!");
            current.Role = "Shoemaker";
            Assert.IsTrue(current.Update(), current.LastError);
            var updated = new Servers { Filter = string.Format("SERVER_ID={0}", current.ServerId) }.Results().FirstOrDefault();
            Assert.IsNotNull(updated, "updated returned nothing!");
            Assert.IsTrue(updated.Role == "Shoemaker", "update failed!");
            Assert.IsTrue(updated.Delete(), updated.LastError);

        }

        [Test]
        public void TestAccountTips()
        {
            var records = new AccountTips { AccountId = 9470, LobCd = "DS", Instance = DbBaseClass.SEDBA };
            foreach (var record in records.Results())
            {
                Console.WriteLine(record);
            }
        }

        [Test]
        public void TestEncryptLargeValue()
        {
            const string value = "I WAS CALLED TO THE FRONT TO REPSOND TO AN ASSOCIATE WHO HAD FAINTED. WHEN I GOT TO THE FRONT LORIE WAS SITTING IN A WHEEL CHAIR. I WAS TOLD BY BILL GREGORY, APA ASSOCIATE THAT SHE HAD FAINTED BUT WAS CAUGHT BEFORE SHE HIT THE FLOOR BY HIM AND A CUSTOMER WALKING BY. AS SHE FELL HER ARM HIT THE EDGE OF THE PODIUM CAUSING A MINOR CUT NEAR HER ELBOW ON HER RIGHT ARM. I BEGAN TO TALK TO HER AND NOTICED SHE WAS YAWNING AND TRYING TO CLOSE HER EYES. I KEPT TALKING TO HER TO KEEP HER AWAKE. SHE WAS ALERT TO MY QUESTIONS THE WHOLE TIME BUT CONINUED TO HAVE HER EYES CLOSED AND YAWNING. SHE THAN BEGAN TO SWEAT AND HAVE CRAMPS. I ASKED HER AGAIN IF SHE WAS ALRIGHT AND SHE EXPLAINED TO ME THAT SHE IS LACTOSE INTOLERANT AND THIS HAS HAPPENED BEFORE BUT NOT TO THE EXTENT OF HAVING CRAMPS AND FAINTING. SHE THEN EXPLAINED TO ME SHE IS ABLE TO HAVE SMALL AMOUNTS OF MILK AND CHEESE AND SHE HAD JUST ATE A SALAD THAT HAD CHEESE AND MAY HAVE BEEN TO MUCH. THOUGH THIS ALL MADE SENSE HER CONDITION WARRANTED";
            Console.WriteLine(GeneralUtility.EncryptValue(value));
        }

        [Test]
        public void TestRoutingPlans()
        {
            var records = RoutingPlans.LoadRoutingsForCall("2136219", "GL", "");

            foreach (var record in records.Results())
            {
                Console.WriteLine(record);
            }
        }

        [Test]
        public void TestOutcomeRecords()
        {
            var records = new TranOutcomeRecordSet { Query = "select * from TRANSMISSION_OUTCOME where CALL_ID = 6746029" };

            foreach (var record in records.Results())
            {
                Console.WriteLine(record);
            }
        }

        [Test]
        public void TestClaimLookups()
        {
            var records = new ClaimLookupSet { Instance = DbBaseClass.SEDBA, Query = "select * from CLAIM_LOOKUP where USER_ID = 2255 ORDER BY 1 DESC" };

            foreach (var record in records.Results())
            {
                Console.WriteLine(record);
            }
        }

        [Test]
        public void TestUsers()
        {
            var user = UserRecordSet.GetUserById(DbBaseClass.SEDBA, 2255);
            Assert.IsNotNull(user);
            Assert.IsTrue(user.UserName == "webclaim");
            Console.WriteLine(user);
        }

        [Test]
        public void TestUserExt()
        {
            var user = Users.FindById(2254);
            Assert.IsNotNull(user);
            Console.WriteLine(user);
            foreach (var extension in user.Extensions)
            {
                Console.WriteLine(extension);
            }
        }

        [Test]
        public void TestPolicyLookup()
        {
            var records = new PolicyLookupSet { Instance = DbBaseClass.SEDBA, Query = GenerateQuery("5201", "BUDGET INN", "003", "", "", "") };
            foreach (var record in records.Results())
            {
                Console.WriteLine(record);
            }
        }

        [Test]
        public void TestUserSession()
        {
            var session = new UserSession
            {
                SessionId = "589404464",
                SessionGuId = "929F302E-1E23-4747-9669-011316ED0414"
            };
            Assert.IsTrue(session.Insert(), session.LastError);
        }

        [Test]
        public void TestUserAuthentication()
        {
            var userAuth = UserAuthentications.CreateUserAuthentication(1232, "yggdrasil");
            Assert.IsNotNull(userAuth);
            Assert.IsTrue(UserAuthentications.VerifyUserAuthentication(userAuth.UserAuthId));
            var current = UserAuthentications.Find(userAuth.UserAuthId);
            Assert.IsNotNull(current);
            Console.WriteLine(current);
        }

        [Test]
        public void TestEscalationPlans()
        {
            var plans = EscalationPlans.FindByAccountLob(3991065, "WC").ToArray();
            Assert.IsTrue(plans.Any());
            foreach (var plan in plans)
            {
                Console.WriteLine(plan);
            }
        }

        private static string GenerateQuery(string account, string name, string unit, string address, string city, string state)
        {
            var addAnd = false;
            var query = new StringBuilder("select * from POLICY_VIEW WHERE ");
            if (!string.IsNullOrEmpty(account))
            {
                addAnd = true;
            }
            query.AppendFormat("ACCOUNT_NUMBER = '{0}' ", account);
            if (!string.IsNullOrEmpty(name))
            {
                if (!addAnd) addAnd = true;
                else query.Append("AND ");
                query.AppendFormat("(NAME LIKE '{0}%' OR DBA_NAME LIKE '{0}%') ", name);
            }
            if (!string.IsNullOrEmpty(unit))
            {
                if (!addAnd) addAnd = true;
                else query.Append("AND ");
                query.AppendFormat("LOCATION_CODE = '{0}' ", unit);
            }
            if (!string.IsNullOrEmpty(address))
            {
                if (!addAnd) addAnd = true;
                else query.Append("AND ");
                query.AppendFormat("ADDRESS_1 LIKE '{0}&' ", address);
            }
            if (!string.IsNullOrEmpty(city))
            {
                if (!addAnd) addAnd = true;
                else query.Append("AND ");
                query.AppendFormat("CITY LIKE '{0}&' ", city);
            }
            if (!string.IsNullOrEmpty(state))
            {
                if (addAnd) query.Append("AND ");
                query.AppendFormat("STATE ='{0}' ", state);
                return query.ToString();
            }
            return query.ToString();
        }
    }
}

#region Log
/*
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/DbClassUnitTests/TestActiveRecord.cs $
 * 
 * 8     2/09/11 2:20p Gwynnj
 * added suport for server insert, update and delete
 * 
 * 7     2/07/11 3:40p Gwynnj
 * Added server info
 * 
 * 6     1/19/11 2:12p Gwynnj
 * support for Miami Dade claims
 * 
 * 5     12/23/10 9:16a Gwynnj
 * support for SED greeting and LOB codes by user in SED_callstart
 * 
 * 4     5/18/10 1:13p Gwynnj
 * CallXmlRecord.HasCallXml for esurance Phase 3 calls
 * 
 * 3     5/12/10 4:25p Gwynnj
 * added sessionKey IsDirty for managing eSurance cache across severs in
 * event of updates from a new machine.
 * 
 * 2     5/11/10 7:39p Gwynnj
 * Added Date fields to the call Table (CallRecord class)
 * 
 * 1     4/30/10 3:35p Gwynnj
 * 
 * 14    4/28/10 5:59p Gwynnj
 * Added ActiveRecord.ConfigSetting and recordset class to reduce the need
 * for multiple db round trips.
 * 
 * 13    4/09/10 12:05p Gwynnj
 * Added Policy.GetActivePoliciesFromTree() given AhsId and LobCd will
 * walk (down) and return all policies
 * 
 * 12    4/07/10 4:49p Gwynnj
 * Added new classes (Policy, Agent) support for policy lookup for
 * Narragansett
 * 
 * 11    3/24/10 6:46p Gwynnj
 * CallRoutings has a default query all UNPROCESSED.
 * 
 * 10    3/12/10 3:41p Gwynnj
 * added Results() to get linq cheap
 * 
 * 9     2/23/10 2:53p Gwynnj
 * Added CallRouting support
 * 
 * 8     1/06/10 6:44p Gwynnj
 * Added ActiveRecord.Employee.GetEmployeeByClientNumberAndEmployeeCode
 * for SEDP employee supervisor fills.
 * 
 * 7     12/02/09 2:51p John.gwynn
 * Fixed bug where USer methods did not propagate the source Instance
 * 
 * 6     10/29/09 12:18p John.gwynn
 * added AhsActiveRecord.GetAhsActiveRecordByUploadKey
 * 
 * 5     10/29/09 11:15a John.gwynn
 * Added Employees and the ability to edit an employee
 * 
 * 4     10/15/09 1:15p John.gwynn
 * 
 * 3     10/12/09 5:42p John.gwynn
 * Added an ApplicationConfiguration class for the Instance default.
 * Added LocationCode ActiveRecords and also cacheing
 * 
 * 2     10/06/09 6:17p John.gwynn
 * Added ClaimSubmission for Selective and Employee for vb conversions
 * 
 * 1     9/25/09 2:47p John.gwynn
 * Moved sql and tests to their own folders
 * 
 * 41    9/25/09 2:37p John.gwynn
 * Added ActiveRecordSet<T> to achieve covariance with respect to the
 * IEnumerable<ActiveRecord> base implementation for articulating strongly
 * typed repositories.
 * 
 * 40    9/22/09 11:06a John.gwynn
 * Import Field updates
 * 
 * 39    9/15/09 8:03p John.gwynn
 * added support for dispay
 * 
 * 38    9/15/09 5:01p John.gwynn
 * Created Import folder and moved Froi classes for further refinement and
 * generalization.  Also resharper reformatting 
 * 
 * 
 * 
 * 
 * 
 * 
 * 37    7/07/09 6:18p John.gwynn
 * Implemented CALLDATA SAVE and LOAD for Interop also created CALL_DATAB
 * and added support for BLOB types in ActiveRecord.
 * 
 * 36    6/05/09 7:28p John.gwynn
 * added CallData with ActiveRecord support for LONG RAW (only call_data
 * parameter at this point)
 * 
 * 35    5/26/09 7:03p John.gwynn
 * Added deep cloning and ToArray, ToList support (ToArray is for interop
 * ToList is because we have no LINQ today)
 * 
 * 34    5/26/09 11:05a John.gwynn
 * Added interop definitions
 * 
 * 32    4/24/09 7:26a John.gwynn
 * 
 * 31    4/03/09 2:55p John.gwynn
 * minor updates
 * 
 * 30    4/02/09 6:53p John.gwynn
 * created Security folder for Users and user functions
 * 
 * 29    4/01/09 7:28p John.gwynn
 * added parameterized SQL to ActiveRecord and beefed up User class for
 * use in VbSecurity
 * 
 * 28    3/23/09 1:53p John.gwynn
 * added LU_CODE lookup support
 * 
 * 27    2/26/09 4:00p John.gwynn
 * 
 * 26    2/18/09 6:37p John.gwynn
 * added callflow frames
 * 
 * 25    1/20/09 6:05p John.gwynn
 * Added Users/USer ActiveRecords
 * 
 * 24    10/16/08 8:27p John.gwynn
 * Added delete to SessionKey
 * 
 * 23    9/30/08 8:56p John.gwynn
 * added InsertSessionKey
 * 
 * 22    9/30/08 8:04p John.gwynn
 * Added static insert & update for SessionData
 * 
 * 21    9/30/08 7:34p John.gwynn
 * Added SessionData and SessionKey tables for eSurance phase III
 * 
 * 20    8/25/08 5:39p John.gwynn
 * added CallXmlRecord.GetCallXml
 * 
 * 19    5/03/08 10:42a John.gwynn
 * added StateAntiSteering
 * 
 * 18    4/30/08 7:18p John.gwynn
 * 
 * 17    1/30/08 3:28p John.gwynn
 * Added StateFraud script for Esurance phase III
 * 
 * 16    12/04/07 5:30p John.gwynn
 * Added AhsActiveRecord and corresonding recordset , added CallRecord and
 * updates for CallXml (eSurance)
 * 
 * 15    12/03/07 2:09p John.gwynn
 * added CallXmlRecord for interface to CALL_XML table.  Insert and update
 * methods implemented.
 * 
 * 14    10/30/07 7:14p John.gwynn
 * ActiveRecordSet now sets instance on record instantiation.  Added
 * support for Evaluation of dynamic Business rules (see RuleRecordSet)
 * and added UsStates for eSurance dropdowns
 * 
 * 13    10/03/07 5:21p John.gwynn
 * Added ToXml to ActiveRecordSets
 * 
 * 12    10/01/07 12:08p John.gwynn
 * 
 * 11    9/27/07 8:57p John.gwynn
 * Added AutoMake and AutoModel Records
 * 
 * 10    8/27/07 12:10p John.gwynn
 * 
 * 9     6/27/07 6:12p John.gwynn
 * Added support for Insert (for OPM)
 * 
 * 8     6/26/07 2:38p John.gwynn
 * fixed a bug in the overridable Query property
 * 
 * 7     6/04/07 4:48p John.gwynn
 * Added Specific Destination and sequenceStep for OPM
 * 
 * 6     6/03/07 2:52p John.gwynn
 * added Transmissionxxx to ActiveRecordSet factory method and verified
 * unit tests
 * 
 * 5     6/03/07 2:09p John.gwynn
 * 
 * 4     4/23/07 6:23p John.gwynn
 * Added interop wrapper classes (work in progress)
 * 
 * 3     4/19/07 4:36p John.gwynn
 * Added COM Interop support and begun work on Callflow data access
 * 
 * 2     4/17/07 4:52p John.gwynn
 * Update from 1.1 version
 * 
 * 3     4/03/07 6:49p John.gwynn
 * ActiveRecordBase changed to ActiveRecord.  EsisPolicyLookup nullADODB
 * parms fixed.
 * 
 * 2     3/21/07 5:13p John.gwynn
 * Added support for ActiveRecordSet (IEnemerable (ActiveRecord) aggregate
 * to encapsulate general queries and form the base for strongly typed
 * collections
 */
#endregion

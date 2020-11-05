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
/* $Header: /SourceCode/Components/FNS2005/DbClassLibrary/DbClassUnitTests/TestOpm.cs 2     7/13/10 11:39a Gwynnj $ */
#endregion

using System;
using NUnit.Framework;

namespace DbClassLibrary.Opm
{
    /// <summary>
    /// NUNIT test fixture for OPM classes
    /// </summary>
    [TestFixture, System.Runtime.InteropServices.ComVisible(false)]
    public class TestOpm
    {
        private const string TestOutcomeId = "141775";
        private const string TestOutcomeStepId = "218353";
        private const string TestTranSeqStepId = "125940";
        private const string SpecialStatus = "SPECIAL";

        /// <summary>
        /// Tests the change trans outcome status.
        /// </summary>
        [Test, Ignore("Obsolete")]
        public void TestChangeTransOutcomeStatus()
        {
            var record = new TransmissionOutcome {Instance = DbBaseClass.FNSBA, TransmissionOutcomeId = TestOutcomeId};
            Assert.IsTrue(record.Execute(), record.LastError);

            var outcome = new ChangeTransOutcomeStatus(DbBaseClass.FNSBA)
                              {
                                  TransmissionId = record.TransmissionOutcomeId,
                                  OldStatus = record.Status,
                                  NewStatus = SpecialStatus
                              };
            Assert.IsFalse(outcome.OldStatus == outcome.NewStatus, "Reset source Status to test!");
            Assert.IsTrue(outcome.Execute(), outcome.LastError);

            var result = new TransmissionOutcome {Instance = DbBaseClass.FNSBA, TransmissionOutcomeId = TestOutcomeId};
            Assert.IsTrue(result.Execute(), result.LastError);
            Assert.IsTrue(SpecialStatus == result.Status, "Results were not set correctly!");

        }
        /// <summary>
        /// Tests the change trans outcome step status.
        /// </summary>
        [Test, Ignore("Obsolete")]
        public void TestChangeTransOutcomeStepStatus()
        {
            var record = new TransmissionOutcomeStep
                             {
                                 Instance = DbBaseClass.FNSBA,
                                 XMissionStepId = TestOutcomeStepId
                             };
            Assert.IsTrue(record.Execute(), record.LastError);

            var outcome = new ChangeTransOutcomeStepStatus(DbBaseClass.FNSBA)
                              {
                                  TransmissionStepId = record.XMissionStepId,
                                  OldStatus = record.Status,
                                  NewStatus = SpecialStatus
                              };
            Assert.IsFalse(outcome.OldStatus == outcome.NewStatus, "Reset source Status to test!");
            Assert.IsTrue(outcome.Execute(), outcome.LastError);

            var result = new TransmissionOutcomeStep
                             {
                                 Instance = DbBaseClass.FNSBA,
                                 XMissionStepId = TestOutcomeStepId
                             };
            Assert.IsTrue(result.Execute(), result.LastError);
            Assert.IsTrue(SpecialStatus == result.Status, "Results were not set correctly!");

        }
        /// <summary>
        /// Tests the update trans outcome step status.
        /// </summary>
        [Test, Ignore("Obsolete")]
        public void TestUpdateTransOutcomeStatus()
        {
            var record = new TransmissionOutcome {Instance = DbBaseClass.FNSBA, TransmissionOutcomeId = TestOutcomeId};
            Assert.IsTrue(record.Execute(), record.LastError);
            Assert.IsFalse(record.Status.Equals(SpecialStatus), "Unexpected STATUS result!");
            record.Status = SpecialStatus;
            record.LastErrorText = "MODIFIED BY TestUpdateTransOutcomeStatus";

            Assert.IsTrue(record.Update(), record.LastError);

            var result = new TransmissionOutcome {Instance = DbBaseClass.FNSBA, TransmissionOutcomeId = TestOutcomeId};
            Assert.IsTrue(result.Execute(), result.LastError);
            Assert.IsTrue(result.Status.Equals(SpecialStatus), "Results were not set correctly!");

            result.Status = "PROCESSED";
            Assert.IsTrue(result.Update(), record.LastError);
        }
        /// <summary>
        /// Tests the insert and update trans outcome step status.
        /// </summary>
        [Test]
        public void TestInsertAndUpdateTransOutcomeStepStatus()
        {
            var record = new TransmissionOutcomeStep
                             {
                                 Instance = DbBaseClass.FNSBA,
                                 TransmissionOutcomeId = TestOutcomeId,
                                 Status = SpecialStatus,
                                 DestinationString = "john_gwynn@firstnotice.com",
                                 TransmissionTypeId = "7",
                                 ServerName = "CHA1ND110",
                                 TransmissionSeqStepId = TestTranSeqStepId
                             };
            record.XMissionStepId = record.GetNextSequence();

            Assert.IsTrue(record.Insert(), record.LastError);
            Console.WriteLine("XmissionStepId = {0}", record.XMissionStepId);

            var result = new TransmissionOutcomeStep
                             {
                                 Instance = DbBaseClass.FNSBA,
                                 XMissionStepId = record.XMissionStepId
                             };
            Assert.IsTrue(result.Execute(), result.LastError);

            Assert.IsTrue(result.Status.Equals(SpecialStatus), "Results were not set correctly!");
            result.Status = "PROCESSED";
            result.ErrorText = "MODIFIED BY TestChangeTransOutcomeStatus";
            Assert.IsTrue(result.Update(), record.LastError);

            Assert.IsFalse(result.Status.Equals(SpecialStatus), "Unexpected STATUS result!");
        }
        /// <summary>
        /// Tests the unit of work.
        /// </summary>
        [Test]
        public void TestUnitOfWork()
        {
            var work = new UnitOfWork(DbBaseClass.FNSBA);

            var record = new TransmissionOutcomeStep
                             {
                                 TransmissionOutcomeId = TestOutcomeId,
                                 Status = SpecialStatus,
                                 DestinationString = "john_gwynn@firstnotice.com",
                                 TransmissionTypeId = "7",
                                 ServerName = "CHA1ND110",
                                 TransmissionSeqStepId = TestTranSeqStepId,
                                 Instance = DbBaseClass.FNSBA
                             };
            record.XMissionStepId = record.GetNextSequence();
            record.ErrorText = "Created from UnitOfWork!";
            work.RegisterInsert(record);

            var record2 = new TransmissionOutcomeStep
                              {
                                  TransmissionOutcomeId = TestOutcomeId,
                                  Status = SpecialStatus,
                                  DestinationString = "6178862064",
                                  TransmissionTypeId = "1",
                                  ServerName = "CHA1ND110",
                                  TransmissionSeqStepId = TestTranSeqStepId,
                                  Instance = DbBaseClass.FNSBA,
                                  XMissionStepId = record.GetNextSequence(),
                                  ErrorText = "Created from UnitOfWork!"
                              };

            work.RegisterInsert(record2);

            var outcomeRecord = new TransmissionOutcome
                                    {
                                        Instance = DbBaseClass.FNSBA,
                                        TransmissionOutcomeId = TestOutcomeId
                                    };
            Assert.IsTrue(outcomeRecord.Execute(), outcomeRecord.LastError);
            var newLastError = String.Format("{0}!", outcomeRecord.LastErrorText);
            outcomeRecord.LastErrorText = newLastError;
            work.RegisterUpdate(outcomeRecord);

            Assert.IsTrue(work.Commit(), work.LastError);

            var outcomeRecord2 = new TransmissionOutcome
                                     {
                                         Instance = DbBaseClass.FNSBA,
                                         TransmissionOutcomeId = TestOutcomeId
                                     };
            Assert.IsTrue(outcomeRecord2.Execute(), outcomeRecord.LastError);
            Assert.IsTrue(outcomeRecord.LastErrorText.Equals(newLastError), "Update seems to have failed!");

            Console.WriteLine("record 1 XmissionStepId = {0}", record.XMissionStepId);
            Console.WriteLine("record 2 XmissionStepId = {0}", record2.XMissionStepId);
        }
        /// <summary>
        /// Tests the unit of work rollback.
        /// </summary>
        [Test]
        public void TestUnitOfWorkRollback()
        {
            var work = new UnitOfWork(DbBaseClass.FNSBA);

            var record = new TransmissionOutcomeStep
                             {
                                 TransmissionOutcomeId = TestOutcomeId,
                                 Status = SpecialStatus,
                                 DestinationString = "john_gwynn@firstnotice.com",
                                 TransmissionTypeId = "7",
                                 ServerName = "CHA1ND110",
                                 TransmissionSeqStepId = TestTranSeqStepId,
                                 Instance = DbBaseClass.FNSBA
                             };
            record.XMissionStepId = record.GetNextSequence();
            record.ErrorText = "Created from UnitOfWork!";
            work.RegisterInsert(record);

            var record2 = new TransmissionOutcomeStep
                              {
                                  TransmissionOutcomeId = TestOutcomeId,
                                  Status = SpecialStatus,
                                  DestinationString = "6178862064",
                                  TransmissionTypeId = "1",
                                  ServerName = "CHA1ND110",
                                  TransmissionSeqStepId = TestTranSeqStepId,
                                  Instance = DbBaseClass.FNSBA,
                                  XMissionStepId = record.XMissionStepId,
                                  ErrorText = "Created from UnitOfWork!"
                              };

            work.RegisterInsert(record2);

            Assert.IsFalse(work.Commit(), work.LastError);
            Assert.IsNotEmpty(work.LastError, "No error message reported!");
            Console.WriteLine(work.LastError);

            work.Rollback();
            Assert.IsFalse(work.HasWork, "HasWork is incorrect!");
        }

        /// <summary>
        /// Tests the create transmission outcome.
        /// </summary>
        [Test, Ignore("Obsolete")]
        public void TestCreateTransmissionOutcome()
        {
            var outcome = new TransmissionOutcome
                              {
                                  Instance = "ESUBA",
                                  RoutingPlanId = "100055",
                                  Status = "UNPROCESSED",
                                  CallId = "1004608"
                              };
            Assert.IsTrue(outcome.Execute(), outcome.LastErrorText);
            //Assert.IsTrue(outcome.Insert(), outcome.LastErrorText);
        }

        /// <summary>
        /// Tests the HTML.
        /// </summary>
        [Test]
        public void TestHtml()
        {
           // var results = new ActiveRecordSet { Instance = DbBaseClass.SENQA, Query = "select * from claim_submission_log where created_dt > (sysdate - 1) order by 1 desc" };
            var results = new ActiveRecordSet { Instance = DbBaseClass.SENQA, Query = "select * from mercury order by 1 desc" };

            Assert.IsTrue(results.Execute());
            Console.WriteLine(results.ToXml());


        }

    }
}
#region Log
/*
 * $Log: /SourceCode/Components/FNS2005/DbClassLibrary/DbClassUnitTests/TestOpm.cs $
 * 
 * 2     7/13/10 11:39a Gwynnj
 * Removed ColumnMap and refactored to ColumnList class to manage
 * multi-key indexing
 * 
 * 1     4/30/10 3:35p Gwynnj
 * 
 * 8     5/26/09 11:07a John.gwynn
 * Added interop definitions
 * 
 * 7     4/02/09 6:53p John.gwynn
 * created Security folder for Users and user functions
 * 
 * 6     8/19/08 6:24p John.gwynn
 * added ability to retrieve record using RoutingPlanId and CallId combo 
 * 
 * 5     8/17/08 7:14p John.gwynn
 * added support for creating an Outcome record given a specific routing
 * plan and callId
 * 
 * 4     7/11/07 3:29p John.gwynn
 * 
 * 3     7/10/07 7:26p John.gwynn
 * Start of UnitOfWork generic implementation
 * 
 * 2     7/10/07 4:54p John.gwynn
 * added Interfaces folder, and interfaces for outcome and outcome step.
 * Added support for Insert and Update of active records and
 * GetNextSequence() method to retrieve a primary key prior to insert
 * 
 * 1     6/26/07 2:43p John.gwynn
 * added support for OPM
 */
#endregion


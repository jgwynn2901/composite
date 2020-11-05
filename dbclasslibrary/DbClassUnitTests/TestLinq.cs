using System;
using System.Linq;
using DbClassLibrary;
using DbClassLibrary.ActiveRecords;
using DbClassLibrary.FirstNotice;
using NUnit.Framework;


namespace DbClassUnitTests
{
	/// <summary>
	/// 
	/// </summary>
	[TestFixture]
	public class TestLinq
	{
		/// <summary>
        private const string UnexpectedValue = "Unexpected value returned!";

	    /// Tests the active record visitor.
		/// </summary>
		[Test]
		public void TestActiveRecordVisitor()
		{
			//const string lastName = "ROBINSON";
			//const string zip = "01970";
			const string ssn = "540046966";

			var db = new Sedgewick();

            var query = from c in db.Employee
                        where c.Ssn == ssn
                        join x in db.EmployeeExtension on c.EmployeeId equals x.EmployeeId
                        select new
                        {
                            Name = c.NameFirst + " " + c.NameLast,
                            Address = c.Address1,
                            c.City,
                            c.State,
                            PostalCode = c.Zip,
                            Extensions = x
                        };

            // TODO: it looks like DbLinq does not translate the SelectMany for joins 
            //       so the join systax must be used until I can fix it?  
            //var query = db.Employee
            //    .Where(c => c.Ssn == ssn)
            //    .SelectMany(c => db.EmployeeExtension.Where(x => c.EmployeeId == x.EmployeeId),
            //                (c,x) => new {
            //                                  Name = c.NameFirst + " " + c.NameLast,
            //                                  Address = c.Address1,
            //                                  c.City,
            //                                  c.State,
            //                                  PostalCode = c.Zip,
            //                                  Extensions = x
            //                              });
                       
            foreach (var item in query)
            {
                ObjectDumper.Write(item);
                ObjectDumper.Write(item.Extensions);
            }
		}

        [Test]
        public void TestAddressBookArray()
        {
            var db = new Production();
            var results = db.Addressbookentry
                .Where(a => a.CallflowId == 944)
                .OrderBy(a => a.Name);

            foreach (var rec in results)
                Console.WriteLine("{0} {1} {2}",
                        rec.CallflowId, rec.Name, rec.Description);

            Assert.IsTrue(results.Count() == 10);
        }

        [Test]
        public void TestAddressBookRecord()
        {
            var db = new Production();

            var record = db.Addressbookentry
                .Where(a => a.AddressBookEntryId == 4422)
                .FirstOrDefault();
            Assert.IsNotNull(record);

            Console.WriteLine("CallflowId:{0} Name:{1} Description:{2}",
                record.CallflowId, record.Name, record.Description);
        }

        [Test]
        public void TestTransmissionOutcomeRecord()
        {
            var db = new Production();

            var record = db.Transmissionoutcome
                .Where(a => a.TransmissionOutcomeId == 18526432)
                .FirstOrDefault();

            Assert.IsNotNull(record);

            //// test expected results
            Assert.IsTrue(record.CallId == 14135072, UnexpectedValue);
            Assert.IsTrue(record.Status.Equals("PROCESSED"), UnexpectedValue);
            Assert.IsTrue(record.RoutingPlanId == 80477, UnexpectedValue);

            Console.WriteLine("CallId:{0}\nStatus:{1}\nRoutingPlanId:{2}\nCreatedDate:{3}\nLastDestinationString:{4}",
                record.CallId,
                record.Status,
                record.RoutingPlanId,
                record.CreatedDate,
                record.LastDestinationString);
        }

		[Test]
		public void TestZipCodeSearch()
		{
			var db = new Production();

			var records = db.Locationcode.Where(a => a.City.StartsWith("BOSTON") && a.State != "MA")
				.OrderBy(a=>a.City)
				.ThenBy(a=>a.State)
				.ThenBy(a=>a.Zip);
			foreach (var record in records)
				Console.WriteLine("{0} {1} {2} {3} {4}", record.City, record.State, record.Zip,record.County, record.Country);

		}

        [Test]
        public void TestTransmissionOutcomeStepRecord()
        {
            var db = new Production();
            var record = db.Transmissionoutcomestep
                .Where(a => a.XMissionStepId == 24584527)
                .FirstOrDefault();

            Assert.IsNotNull(record);

            //// test expected results
            Assert.IsTrue(record.TransmissionSeqStepId == 80457, UnexpectedValue);
            Assert.IsTrue(record.Status.Equals("PROCESSED"), UnexpectedValue);
            Assert.IsTrue(record.TransmissionOutcomeId == 18526432, UnexpectedValue);
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

        [Test]
        public void TestTranOutcomeRecordRecordSet()
        {
            var db = new Database(DbBaseClass.FNSBA);
            var records = db.Transmissionoutcome.Where(a => a.Status == "SPECIAL");
 
            foreach (var rec in records)
                Console.WriteLine("CallId:{0}\nStatus:{1}\nRoutingPlanId:{2}\nCreatedDate:{3}\nLastDestinationString:{4}",
                                                        rec.CallId,
                                                        rec.Status,
                                                        rec.RoutingPlanId,
                                                        rec.CreatedDate,
                                                        rec.LastDestinationString);

            Assert.IsTrue(records.Count() > 0);
        }

        [Test]
        public void TestTranOutcomeStepRecordSet()
        {
            var db = new Database(DbBaseClass.FNSBA);
            var records = db.Transmissionoutcomestep.Where(a => a.TransmissionOutcomeId == 141468);
            Console.WriteLine("************************************");
            foreach (var rec in records)
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
            Assert.IsTrue(records.Count() == 1);
        }

        [Test]
        public void TestUserRecord()
        {
            var db = new Production();
            
            var record = (from u in db.Users
                         where u.UserId == 27342
                         select u).FirstOrDefault();

            Assert.IsNotNull(record);
            Assert.IsTrue(record.Name.Equals("JCHEUNG16"), UnexpectedValue);

            Console.WriteLine("UserId:{0} UserName:{1} First:{2} Last:{3}",
                record.UserId, record.Name, record.FirstName, record.LastName);
        }

		/// <summary>
		/// Tests the users.
		/// </summary>
		[Test]
		public void TestUsers()
		{
			//const string userId = "1251";
			var db = new Sedgewick();

			var query = (from u in db.Users
			             where u.Active == "Y"
			             select new { u.Name, u.UserId }).ToList();

			foreach (var item in query.OrderBy(c => c.Name))
				Console.WriteLine(item);

		}

		[Test]
		public void TestCallRecords()
		{
			var db = new Production();

			var records = db.Call
                .Where(c => c.Status == "INPROC")
                .OrderBy(c => c.CallId);

			foreach (var call in records)
				ObjectDumper.Write(call);
		}

		/// <summary>
		/// Tests the active record join.
		/// </summary>
		[Test]
		public void TestActiveRecordJoin()
		{
			var db = new Sedgewick();

			var query = from c in db.Employee
			            where c.Ssn == "540046966"
			            join x in db.EmployeeExtension on c.EmployeeId equals x.EmployeeId
			            select new
			                   	{
			                   		Name = c.NameFirst + " " + c.NameLast,
			                   		Atribute = x.FieldName,
			                   		Values = x
			                   	};

			
			foreach (var item in query)
				ObjectDumper.Write(item);
		}
		/// <summary>
		/// Tests the attributes.
		/// </summary>
		[Test]
		public void TestTableNameAttribute()
		{
			var results = TableDefinitionAttribute.ClassTableName(typeof (DbClassLibrary.ActiveRecords.Employee));
			Assert.IsNotEmpty(results);
			Assert.IsNull(TableDefinitionAttribute.ClassTableName(typeof(Employees)));
			Console.WriteLine(results);
			
		}

		/// <summary>
		/// Tests the field info.
		/// </summary>
		[Test]
		public void TestFieldInfo()
		{
			var hostType = typeof (DbClassLibrary.ActiveRecords.Employee);

			var results = from t in (from p in hostType.GetProperties() select p)
			              from a in t.GetCustomAttributes(true)
			              where a is FieldDefintionAttribute
			              select FieldDefintionAttribute.ClassFieldName(hostType, t.Name) ?? t.Name;

			foreach (var field in results)
				Console.WriteLine(field);

			Assert.IsTrue(typeof(ActiveRecord).IsAssignableFrom(hostType));

		}
		/// <summary>
		/// Tests the attributes.
		/// </summary>
		[Test]
		public void TestFieldNameAttribute()
		{
			var results = FieldDefintionAttribute.ClassFieldName(typeof(DbClassLibrary.ActiveRecords.Employee), "NameLast");
			Assert.IsNotEmpty(results);
			Assert.IsNull(FieldDefintionAttribute.ClassFieldName(typeof(DbClassLibrary.ActiveRecords.Employee), "Ssn"));
			Console.WriteLine(results);

		}

        [Test]
        public void TestCallDataProjection()
        {
            var db = new Database(DbBaseClass.FNSQA);
            var threshold = DateTime.Now - new TimeSpan(12,0,0);

            // N.B. we must retrieve the calls before we can use the Client property
            // hence the immediate ToList to pull set of calls before resolving 
            // the client AHS record.
            var results = (from c in db.Call
                        where c.CallStartTime > threshold
                        select c)
                        .ToList()
                        .Select(a => new
                                        {
                                            a.CallId,
                                            a.CallStartTime,
                                            Client = a.Client.Name,
                                            a.LobCode,
                                            a.Status
                                        }); 
 
            foreach (var call in results)
                Console.WriteLine(call);

        }

        [Test]
        public void TestPerformanceDataQuery()
        {
            var db = new Database(DbBaseClass.FNSBA);
            var results = db.Perfdata
                .Where(a => a.CallId == 203961)
                .OrderBy(a => a.PerfDataId)
                .Select(a => new
                {
                    a.Component, a.Method,
                    Frame = a.FrameName,
                    Start = a.StartTime,
                    End = a.EndTime,
                    Interval = a.EndTime - a.StartTime
                });

            foreach (var item in results.ToList().Where(a=>a.Interval > TimeSpan.Zero))
                Console.WriteLine(item);
        }
	}
}
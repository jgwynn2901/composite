using System;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Xml.Linq;
using DbClassLibrary;
using DbClassLibrary.Callflow;
using FnsComposite.CallObjects;
using FnsInterop;
using FnsUtility;
using NUnit.Framework;
using Assert=FnsUtility.Assert;
using GeneralUtility=FnsUtility.GeneralUtility;


namespace TestUtilities
{
	[Serializable]
	public class TestSerialize
	{
		public string Name { get; set; }
		public string Value { get; set; }
	}

    [TestFixture]
    public class TestEval
    {
        private CallObject _call;

        /// <summary>
        /// Inits this instance.
        /// </summary>
        [SetUp]
        public void Init()
        {
            _call = new CallObject();
            _call.Caller.NameFirst = "JOHN";
            _call.Caller.NameLast = "GWYNN";
            _call.Caller.PhoneHome = "5556667788";
            _call.Caller.Address.Address1 = "529 MAIN STREET";
            _call.Caller.Address.City = "CHARLESTOWN";
            _call.CallId = 12345;
            _call.LineOfBusiness = "PAU";
            _call.CarrierCode = "ESU";
            _call.Instance = "FNSBA";
            _call.ServerName = "CHA1ND110";
        }
        /// <summary>
        /// Tests the evalwith call object.
        /// </summary>
        [Test]
        public void TestEvalwithCallObject()
        {
            var code = new StringBuilder();

            code.AppendLine("if (_call.LineOfBusiness.Equals(\"PAU\")) {");
            code.AppendLine("\t\t_call.Claim.ClaimNumber = \"123456789\"; }");
            code.AppendLine("else {");
            code.AppendLine("\t\t_call.Claim.SetValue(\"ERRORSTRING\",\"LOB_CD NOT PAU\"); }");

            var eval = new Eval {Expression = code.ToString(), Parameter = _call.ToXml()};

            var results = eval.Execute();

            NUnit.Framework.Assert.IsEmpty(eval.LastError, eval.LastError);
            NUnit.Framework.Assert.IsNotEmpty(results, "Nothing returned!");

            Console.WriteLine(results);

        }
        /// <summary>
        /// Tests the evalwith empty call object.
        /// </summary>
        [Test]
        public void TestEvalwithEmptyCallObject()
        {
            var code = new StringBuilder();

            code.AppendLine("if (_call.LineOfBusiness.Equals(\"PAU\")) {");
            code.AppendLine("\t\t_call.Claim.ClaimNumber = \"123456789\"; }");
            code.AppendLine("else {");
            code.AppendLine("\t\t_call.Claim.SetValue(\"ERRORSTRING\",\"LOB_CD NOT PAU\"); }");

            var eval = new Eval {Expression = code.ToString()};
            //eval.Parameter = call.ToXml();

            var results = eval.Execute();

            NUnit.Framework.Assert.IsEmpty(eval.LastError, eval.LastError);
            NUnit.Framework.Assert.IsNotEmpty(results, "Nothing returned!");

            var resultCall = new CallObject();
            resultCall.LoadFromXml(results);
            NUnit.Framework.Assert.IsNotEmpty(resultCall.GetValue("LASTERROR"), "Expected error was not returned!");
            Console.WriteLine(resultCall.GetValue("LASTERROR"));

        }
        /// <summary>
        /// Tests the evalwith compilation errors.
        /// </summary>
        [Test]
        public void TestEvalwithCompilationErrors()
        {
            var code = new StringBuilder();

            code.AppendLine("if (_call.LineOfBusiness.Equals(\"PAU\")) {");
            code.AppendLine("\t\t_call1.Claim.ClaimNumber = \"123456789\"; }"); // typo here
            code.AppendLine("else {");
            code.AppendLine("\t\t_call.Claim.SetValue(\"ERRORSTRING\",\"LOB_CD NOT PAU\"); }");

            var eval = new Eval {Expression = code.ToString(), Parameter = _call.ToXml()};

            var results = eval.Execute();

            NUnit.Framework.Assert.IsNotEmpty(eval.LastError, eval.LastError);
            NUnit.Framework.Assert.IsEmpty(results, "Something returned!");

            Console.WriteLine(eval.LastError);

        }
        /// <summary>
        /// Tests the static evalwith call object.
        /// </summary>
        [Test]
        public void TestStaticEvalwithCallObject()
        {
            var code = new StringBuilder();

            code.AppendLine("if (_call.LineOfBusiness.Equals(\"PAU\")) {");
            code.AppendLine("\t\t_call.Claim.ClaimNumber = \"123456789\"; }");
            code.AppendLine("else {");
            code.AppendLine("\t\t_call.Claim.SetValue(\"ERRORSTRING\",\"LOB_CD NOT PAU\"); }");

            var results = Eval.EvaluateCallObject(_call.ToXml(), code.ToString());
            NUnit.Framework.Assert.IsNotEmpty(results, "Nothing returned!");

            Console.WriteLine(results);
        }
        /// <summary>
        /// Tests the static evalwith empty call object.
        /// </summary>
        [Test]
        public void TestStaticEvalwithEmptyCallObject()
        {
            var code = new StringBuilder();

            code.AppendLine("if (_call.LineOfBusiness.Equals(\"PAU\")) {");
            code.AppendLine("\t\t_call.Claim.ClaimNumber = \"123456789\"; }");
            code.AppendLine("else {");
            code.AppendLine("\t\t_call.Claim.SetValue(\"ERRORSTRING\",\"LOB_CD NOT PAU\"); }");

            var results = Eval.EvaluateCallObject(string.Empty, code.ToString());
            NUnit.Framework.Assert.IsNotEmpty(results, "Nothing returned!");

            var resultCall = new CallObject();
            resultCall.LoadFromXml(results);
            NUnit.Framework.Assert.IsNotEmpty(resultCall.GetValue("LASTERROR"), "Expected error was not returned!");
            Console.WriteLine(resultCall.GetValue("LASTERROR"));

        }
        /// <summary>
        /// Tests the sedgwick rule processor.
        /// </summary>
        [Test, Ignore("Obsolete")]
        public void TestSedgwickRuleProcessor()
        {
            const string asiDisabilityAttribute = "ASI:CTA_EMPLOYEE_BEGIN_DISABILITY_DT";
			using (var call = new CallWrapper())
			{
				call.LoadFromDSN("7679", GeneralUtility.GetDsnFromInstance(DbBaseClass.SEDBA));
				var myCall = new CallObject();
				myCall.LoadFromXml(call.GetXML());
				var originalDate = myCall.GetValue(asiDisabilityAttribute);
				//NUnit.Framework.Assert.IsTrue(originalDate.Length == 8, "Bad date format!");
				var records = RuleRecordSet.GetRuleSetByClientAndEvent("18", "CLOSE", "SEDBA");
				NUnit.Framework.Assert.IsTrue(records.Count >= 1, "Problems!");
				foreach (var record in records)
				{
					var results = Eval.EvaluateCallObject(myCall.ToXml(), record.RuleText);
					NUnit.Framework.Assert.IsNotEmpty(results, "Nothing returned!");

					var resultCall = new CallObject();
					resultCall.LoadFromXml(results);
					NUnit.Framework.Assert.IsNotEmpty(resultCall.GetValue(asiDisabilityAttribute), "Expected result was not returned!");
					NUnit.Framework.Assert.IsFalse(originalDate.Equals((resultCall.GetValue(asiDisabilityAttribute))),
					                               "dates are unchanged!");
					Console.WriteLine("Original: {0} Transformed: {1}", originalDate, resultCall.GetValue(asiDisabilityAttribute));
				}
			}
        }

		[Test]
		public void TestGetXmlObjectAsString()
		{
			var record = new TestSerialize { Name="Test Serializable", Value="If you see me it worked!" };
			var results = XmlUtility.GetXmlObjectAsString(record);
			Assert.IsNotEmpty(results,"Nothing returned!");
			Console.WriteLine(results);
			
		}

        /// <summary>
        /// 
        /// </summary>
        [Test]
        public void TestConnectString()
        {
            var connectionString = GeneralUtility.ConnectString;
            NUnit.Framework.Assert.IsNotEmpty(connectionString, "ConnectionString failed!");
            Console.WriteLine(connectionString);
        }

        /// <summary>
        /// 
        /// </summary>
        [Test]
        public void TestPasswordFromRegistry()
        {
            Console.WriteLine(GeneralUtility.PasswordFromRegistry);
            if (GeneralUtility.IsProduction)
                Console.WriteLine("This is a PRODUCTION machine!");
            else
                Console.WriteLine("This is NOT a PRODUCTION machine!");
        }

        /// <summary>
        /// Tests the target exception.
        /// </summary>
        [Test]
        public void TestTargetException()
        {
            try
            {
                try
                {
                    throw new TargetInvocationException("Test exception!", new ApplicationException("Something went wrong!"));
                }
                catch (TargetInvocationException ex)
                {
                    Console.WriteLine(ex.Message);
                    throw ex.InnerException;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        /// <summary>
        /// Tests the load binary file.
        /// </summary>
        [Test, Ignore("Obsolete")]
        public void TestLoadBinaryFile()
        {
            var results = FileUtility.LoadBinaryFile(@"C:\FnsData\CallData\CALL_289.DAT");
            NUnit.Framework.Assert.IsNotNull(results, "NULL returned!");
            NUnit.Framework.Assert.IsTrue(results.Length > 0, "Empty buffer!");

            var callData = new CallData { Instance = "FNSBA", CallId = 2738971, Data = results };
            NUnit.Framework.Assert.IsTrue(callData.Update(), callData.LastError);

        }
		[Test]
		public void TestProductionInstance()
		{
			Console.WriteLine("Your Production Instance is " + GeneralUtility.ProductionInstanceFromRegistry );
		}
		[Test, Ignore("Obsolete")]
		public void TestResponse()
		{
			var document = XDocument.Load(@"C:\Documents and Settings\john.gwynn\My Documents\results.xml");
			var claimNumber = (	from element in document.Descendants("Claim")
								from c in element.Descendants("Number")
								select c.Value).FirstOrDefault(); 
 		   Console.WriteLine(claimNumber);

		   var adjuster = document.Descendants("Adjuster").First();
			Console.WriteLine("Adjuster: {0} {1} Telephone: {2} {3}",
				adjuster.Descendants("FirstName").First().Value,
				adjuster.Descendants("LastName").First().Value,
				adjuster.Descendants("Phone").Descendants("Number").First().Value,
				adjuster.Descendants("Phone").Descendants("Extension").First().Value);
		}
    }
}

/**************************************************************************
* First Notice Systems
* 529 Main Street
* Boston, MA 02129
* (617) 886 2600
*
* Proprietary Source Code -- Distribution restricted
*
* Copyright (c) 1993-2006 by First Notice Systems
**************************************************************************/
/* $Header: /SourceCode/Components/FNS2005/FnsComposite/CompositeTests/CallTest.cs 2     9/21/10 6:30p Gwynnj $ */

using System;
using System.IO;
using System.Text.RegularExpressions;
using FnsComposite;
using FnsComposite.CallObjects;
using NUnit.Framework;

namespace CompositeTests
{
	/// <summary>
	/// Summary description for CallTest.
	/// </summary>
	[TestFixture, System.Runtime.InteropServices.ComVisible(false)]
	public class CallTest
	{
		/// <summary>
		/// Mies the dates logic.
		/// </summary>
		[Test, Ignore]
		public void TestDatesLogic()
		{
			var myCall = new CallObject();
			var strTestCall = LoadFileText(@"C:\Documents and Settings\gwynnj\My Documents\call.xml");
			Assert.IsTrue(strTestCall.Length > 0);
			myCall.LoadFromXml(strTestCall);

			var asiNode = myCall["ASI"] as Composite;
			if (asiNode == null) return;
			var reg = new Regex("_DT$");

			foreach(CompositeLeaf node in asiNode.GetEnumerator<CompositeLeaf>())
			{
				if (!reg.IsMatch(node.Name) || node.Value.Length <= 0) continue;
				var newDate = string.Format("{0}{1}{2}", node.Value.Substring(4, 4), node.Value.Substring(0, 2), node.Value.Substring(2, 2));
				var parseDate = string.Format("{0}/{1}/{2}", node.Value.Substring(0, 2), node.Value.Substring(2, 2), node.Value.Substring(4, 4));
				Console.WriteLine("Found Match: {0} Value: {1}", node.Name, node.Value);
				DateTime date;
				if (!DateTime.TryParse(parseDate, out date)) continue;
				node.Value = newDate;
				Console.WriteLine("Found Match: {0} Value: {1}", node.Name, node.Value);
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[Test,Ignore]
		public void TestAddress()
		{
			var call = new CallObject();
			var strTestCall = LoadFileText(@"C:\Documents and Settings\john.gwynn\My Documents\call.xml");
			Assert.IsTrue(strTestCall.Length > 0);
			call.LoadFromXml(strTestCall);

			Assert.IsNotEmpty(call.Claim.Insured.Address.Fips, "Insured Fips is missing!");

			Assert.IsNotEmpty(call.Claim.LossLocation.Address.Address1, "Loss location Address1 is missing!");
			Assert.IsNotEmpty(call.Claim.LossLocation.Address.City, "Loss location City is missing!");
			Assert.IsNotEmpty(call.Claim.LossLocation.Address.State, "Loss location State is missing!");

			call.Claim.Remove("LOSS_LOCATION");

			Assert.IsEmpty(call.Claim.LossLocation.Address.Address1, "Loss location Address1 is not empty!");
			Assert.IsEmpty(call.Claim.LossLocation.Address.City, "Loss location City s not empty!");
			Assert.IsEmpty(call.Claim.LossLocation.Address.State, "Loss location State s not empty!");

			call.Claim.LossLocation.Address.Address1 = "529 Main Street";
			call.Claim.LossLocation.Address.City = "Charlestown";
			call.Claim.LossLocation.Address.State = "MA";
			call.Claim.LossLocation.Address.Zip = "02129";

			Assert.IsNotEmpty(call.GetValue("CLAIM:LOSS_LOCATION:ADDRESS_LINE1"), "Loss location Address1 is missing!");
			Assert.IsNotEmpty(call.GetValue("CLAIM:LOSS_LOCATION:ADDRESS_CITY"), "Loss location City is missing!");
			Assert.IsNotEmpty(call.GetValue("CLAIM:LOSS_LOCATION:ADDRESS_STATE"), "Loss location State is missing!");
			Assert.IsNotEmpty(call.GetValue("CLAIM:LOSS_LOCATION:ADDRESS_ZIP"), "Loss location Zip is missing!");

			Console.WriteLine("{0}\n{1}, {2} {3}",
			                  call.Claim.LossLocation.Address.Address1,
			                  call.Claim.LossLocation.Address.City,
			                  call.Claim.LossLocation.Address.State,
			                  call.Claim.LossLocation.Address.Zip);
		}
		/// <summary>
		/// LoadFileText 
		/// </summary>
		/// <param name="strFileName">file to read</param>
		/// <returns>contents of file as string</returns>
		private static string LoadFileText(string strFileName)
		{
			string strReturn = "";
			StreamReader oStream = null;
			try
			{
				oStream = new StreamReader(strFileName);
				strReturn = oStream.ReadToEnd();
			}
			catch( Exception ex)
			{
				Console.WriteLine("LoadFileText(): ERROR on reading file: " + strFileName + ": " + ex.Message);
			}
			finally
			{
				if (oStream != null)
				{
					oStream.Close();
				}
			}
			return strReturn;	
		}

		/// <summary>
		/// Tests the node count.
		/// </summary>
		[Test]
		public void TestNodeCount()
		{
			var call = new CallObject {CallId = "12"};
			Assert.IsNotEmpty(call.GetValue("CALL_ID"));

			call.SetValue("CLAIM:VEHICLE[0]:VIN", "123456789");
			call.SetValue("CLAIM:VEHICLE[1]:VIN", "123456789");
			call.SetValue("CLAIM:VEHICLE[2]:VIN", "123456789");
			call.SetValue("CLAIM:VEHICLE[3]:VIN", "123456789");

			Assert.IsTrue(call.GetNodeCount("CLAIM:VEHICLE") == 4);
		}

		[Test]
		public void TestEntity()
		{
			var entity = new EntityBase("DRIVER")
			             	{
			             		NameFirst = "Fred",
			             		NameLast = "Flintstone",
			             		NameMid = "T",
			             		PhoneHome = "6178862064"
			             	};

			entity.Address.Address1 = "1234 Main Street";
			entity.Address.City = "Bedrock";
			entity.Address.State = "CO";
			entity.Address.Zip = "02129";

			Console.WriteLine(entity);

		}
	}
}

/*
 * $Log: /SourceCode/Components/FNS2005/FnsComposite/CompositeTests/CallTest.cs $
 * 
 * 2     9/21/10 6:30p Gwynnj
 * Created EntityBase to factor the IPerson interface
 * 
 * 1     7/13/10 2:08p Gwynnj
 * 
 * 10    1/12/10 5:13p Gwynnj
 * Added GetNodeCount for indexed elements
 * 
 * 9     5/19/09 1:57p John.gwynn
 * added JSON serialiation
 * 
 * 8     5/04/09 3:55p John.gwynn
 * removed FnsComposite.ICall (replaced with the Interop version in
 * FnsInterfaces)
 * 
 * 7     3/03/09 4:11p John.gwynn
 * 
 * 6     3/03/09 4:06p John.gwynn
 * fixed a weakness with Address derivative class
 * 
 * 5     1/02/08 4:07p John.gwynn
 * refactored the ICall class interface and implementation to the
 * FnsDomain assembly
 * 
 * 4     10/30/07 7:12p John.gwynn
 * Support for new Business Rule evaluator
 * 
 * 3     8/28/07 11:22a John.gwynn
 * modified the LoadFromXml to Copy [retain] elements that alread exist
 * (rather than overwriting them)
 * 
 * 2     4/17/07 3:41p John.gwynn
 * update current version synch to 1.1
 * 
 * 10    11/16/06 5:20p John.gwynn
 * Added NDoc comments and formatting
 * 
 * 9     9/08/06 2:04p John.gwynn
 * Build modifications [Unit tests]
 * 
 * 8     6/05/06 5:55p John.gwynn
 * added strong name and regExprExtractor
 * 
 * 7     6/03/06 4:50p John.gwynn
 * added RegexprExtractor and support for counting leaf nodes and strong
 * name file
 * 
 * 6     4/09/06 8:14p John.gwynn
 * FxCop and Resharper reformatting changes
 * 
 * 5     1/25/06 10:47a John.gwynn
 * fixed name problem
 * 
 * 4     1/24/06 9:44p John.gwynn
 * added AddressExtractor visitor
 * 
 * 3     1/18/06 2:45p John.gwynn
 * handle Xml special characters in data
 * 
 * 2     1/17/06 4:09p John.gwynn
 * SetTypedValue support for XML as call values 
 * 
 * 1     1/15/06 12:07a John.gwynn
 */

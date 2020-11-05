using System;

namespace FnsUtility
{
	[CLSCompliant(false)]
	public abstract class PolicyService<T, TResponse, TDetailResponse> : BaseService<T> where T : IDisposable, new()
	{
		protected abstract void PopulateRecordsFromSearch(ADODB.Recordset records, TResponse response);
		protected abstract void PopulateRecordsFromDetail(ADODB.Recordset records, TDetailResponse response);


		public string PrepareAdoResultsFromSearch(TResponse response)
		{
			var records = XmlUtility.CreateRecordSet(FieldNames);
			PopulateRecordsFromSearch(records, response);
			return XmlUtility.GetXmlFromAdoRecordset(records);
		}

		public string PrepareAdoResultsFromDetail(TDetailResponse response)
		{
			var records = XmlUtility.CreateRecordSet(FieldNames);
			PopulateRecordsFromDetail(records, response);
			return XmlUtility.GetXmlFromAdoRecordset(records);
		}
	}
}

#region Header
/**************************************************************************
* Innovation First Notice 
* 95 Wells Avenue
* Newton, MA 02459
* (617) 886-2600
*
* Proprietary Source Code -- Distribution restricted
*
* Copyright (c) 2009 by Innovation First Notice 
**************************************************************************/
/* $Header: /SourceCode/Components/FNS2005/FnsInterfaces/ICallFlow.cs 1     4/28/09 10:47a John.gwynn $ */
#endregion


namespace FnsInterfaces
{
	public interface ICallflow
	{
		int m_lAcctHierID {  get; set; }
		int m_lCallflowID { get; set; }
		string m_bstrFrameListing { get; set; }
		string m_bstrLOB { get; set; }
		string m_bstrValidRule { get; set; }
		int m_lValidRuleId { get; set; }
		string m_bstrFNSClientCode { get; set; }
		string m_bstrCallflow_Type { get; set; }
		
		object Load( string bstrAcctHierID,  string bstrLOB,  object pIDispatchEval);
		object GetNextFrame( object pIDispatchEval);
		object GetPreviousFrame( object pIDispatchEval);
		object GetCurrentFrame();
		string IsEOF();
		string IsBOF();
		
		object GetFrameByID( int iFrameID,  int bModifyFlow);
		void Reset();
		
		object LoadCallStart( string bstrAHSID,  string bstrLOB,  object pIDispatchEval);
		int m_bBOF { get;  set; }
		int m_bEOF { get;  set; }
		
		object GetLastFrame( object pIDispatchEval);
		
		object GetFirstFrame( object pIDispatchEval);
		void RebuildFrameListing( object pIDispatchEval);
		string GetABEList();
		
		object GetFrameByName( string bstrName);
		
		object IterateFrames( object pIDispatchEval);
		void ResetIterateIndex();
		
		object GetAttribFrameByID( int iFrameID);
		string GetABEDescriptions();
		string get_m_bstrLastUpdateTime();
		void put_m_bstrLastUpdateTime();
		
		object GetFrameByNameSettable( string bstrName,  int bModifyFlow);
		object LoadCallflowByType( string bstrAHSID,  string bstrLOB,  string bstrCallflow_Type,  object pIDispatchEval);
		object LoadCallStartByType( string bstrAHSID,  string bstrLOB,  string bstrCallflow_Type,  object pIDispatchEval);
		object GetFrameByNameA( string bstrName);
	}
}
#region History
/*
 * $History: ICallFlow.cs $
 * 
 * *****************  Version 1  *****************
 * User: John.gwynn   Date: 4/28/09    Time: 10:47a
 * Created in $/SourceCode/Components/FNS2005/FnsInterfaces
 * added ICall and callflow interface definitions
 */
#endregion
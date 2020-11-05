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
/* $Header: /SourceCode/Components/FNS2005/FnsInterfaces/ICall.cs 2     5/04/09 6:56p John.gwynn $ */
#endregion

namespace FnsInterfaces
{
	public interface ICall
	{
		#region Properties

		string bstrCarrierCode { get; set; }
		string bstrLOB {  get; set; }
		int lCallId {  get; set; }
		string m_bstrUserID { get; set; }
		int lAccntHierID { get; set; }
		string HTMLTree { get; }
		int m_lCarrierID { get; set; }
		string m_bstrAttribInError { get; }
		string ErrorText { get; set; }
		string BadFrameId { get; set; }
		int m_lEntryId { get; set; }
		string bstrLocation { get; set; }
		
		#endregion

		string GetValue(string Name);
		void SetValue(string Name,  string Value);
		int Load(int lCallId);
		int LoadFromFile(string bstrFileName);
		void Save();
		int Route();
		int Escalate();
		int FlatSave();
		int FinalSave();
		int CanClose();
		int InitialSave();
		int InitialSaveNoCallflow();
		int IncrementalSave();
		int Abandon();
		int Abort();
		int LoadFromDSN(string bstrCallID, string bstrDSN);
		int FinalSaveRoute(int lCallRoutingID, out string pMessage);
		int Pend();
		int FlatDelete();

		string GetXML();
		void LoadFromXML(string bstrXML);

		void OnEvent(string bstrEvent);
		void OnAsynchEvent(string bstrEvent);

		#region Callflow

		object LoadCallStart();
		object LoadCallflow(string bstrAcctHierID, string bstrLOB);
		object LoadCallStartByType(string bstrAHSID, string bstrLOB, string bstrCallflowTypeCode);
		object LoadCallflowByType(string bstrAHSID, string bstrLOB, string bstrCallflowTypeCode,  int bSetAsCurrentFrame);
		object GetCallflowFrameByName(string bstrFrameName,  int bSetAsCurrentFrame);
		object GetFirstFrame();
		object GetNextFrame();
		object GetPreviousFrame();
		object GetCurrentFrame();
		object GetFrameByID( int iFrameID);
		object GetCallflowFrameByID(int iFrameID);
		object GetFrameByName(string bstrName);
		void ResetCallflow();
		string GetFrameListing();
		string IsEOF();
		string IsBOF();
		void ReleaseFlowLists();
		void LoadCallFlows();
		void ReloadFlowInList( int lCallflowID, string bstrCallStartFlag);
		string InsertIndexesInAttrib(string bstrAttribName, string bstrPrefix);
		void ClearAttributes(string bstrObjectName);
		string GetAttributeList();

		#endregion

		#region Evaluator

		string EvalString(string bstrStatement);
		int EvalBool( int lRuleId);
		int EvalAction( int lRuleId);
		int ExecuteAction(string bstrRuleText);
		int ExecuteScript(string scriptType, string scriptCode);

		#endregion

		#region Spelling

		int CheckSpelling();
		int AddWordToDictionary(string bstrWord);
		int IgnoreMisspelledWord();
		void IgnoreAllMisspelledWords();
		string GetCachedCallflowList();
		string GetSpellErrorFrameTitle();
		string GetSpellErrorFieldCaption();
		string GetSpellErrorHTML();
		string GetSpellErrorWord();
		string GetSpellErrorSuggestions();
		int NextSpellError();
		int PreviousSpellError();
		int ReplaceSpellError( string bstrSuggestion);
		int CloseDictionaries();
		string GetSpellErrorFrameID();

		#endregion

		string GetStringData();
		string GetSerializedCallData();
		void DeleteObject(string Name);
		int GetObjectCount(string Name);
		string GetABEList();
		int IsObject(string bstrName);
		void CleanUp();
		string GetTree(string bstrObjectName);
		void NewCallFromOld();
		void CheckPersistence();
		void CleanupDBConns();
		string GetABEDescriptions();
		int InTree( int lAccountID);
		string GetAHSIDByClientCode( string bstrClientCode);

		void CopyObjectTo( string bstrBranchName,  string bstrTargetRoot);
		void MoveObjectTo( string bstrBranchName,  string bstrTargetRoot);
		
		void SetTypedValue( string bstrName,  string bstrValue,  string bstrType);
		void InitFrameStatuses();
		void DeleteArray( string bstrName);
		void ResetDsn();
	}
}
#region History
/*
 * $History: ICall.cs $
 * 
 * *****************  Version 2  *****************
 * User: John.gwynn   Date: 5/04/09    Time: 6:56p
 * Updated in $/SourceCode/Components/FNS2005/FnsInterfaces
 * Refactored ICall interface
 * 
 * *****************  Version 1  *****************
 * User: John.gwynn   Date: 4/28/09    Time: 10:47a
 * Created in $/SourceCode/Components/FNS2005/FnsInterfaces
 * added ICall and callflow interface definitions
 */
#endregion
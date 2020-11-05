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
/* $Header: /SourceCode/Components/FNS2005/FnsInterfaces/IFrameObj.cs 1     4/28/09 10:47a John.gwynn $ */
#endregion


namespace FnsInterfaces
{
	public interface IFrameObj
	{
		string m_bstrEnabledRuleID { get;  set; } 
		string m_bstrValidRuleID { get;  set; } 
		string m_bstrFrameTitle { get;  set; } 
		string m_bstrModalFlag { get;  set; } 
		string m_bstrFrameID { get;  set; } 
		string m_bstrSequence { get;  set; } 
		string m_bstrCallflowName { get;  set; } 
		string m_bstrCallflowID { get;  set; } 
		string m_bstrActionID { get;  set; } 
		void LoadFields();
		object GetNextField();
		void ResetFieldIndex();
		string m_bstrAccountCallflowID { get;  set; } 
		string m_bstrCallTypeID { get;  set; } 
		string m_bstrCatFlg { get;  set; } 
		string m_bstrHelpString { get;  set; } 
		string m_bstrFrameDesc { get;  set; } 
		string m_bstrCallflowDesc { get;  set; } 
		object GetFieldByID(string bstrFieldID);
		string m_bstrFrameName { get;  set; } 
		string m_bstrIsEnabled { get;  set; } 
		string m_bstrIsValid { get;  set; } 
		string m_bstrAttributePrefix { get;  set; } 
		string m_bstrType { get;  set; } 
		string m_bstrSQLSelect { get;  set; } 
		string m_bstrSQLFrom { get;  set; } 
		string m_bstrSQLWhere { get;  set; } 
		string m_bstrSQLOrderBy { get;  set; } 
		string m_bstrMaxPageResultRows { get;  set; } 
		string m_bstrOneRowAutoSelectFlg { get;  set; } 
		string m_bstrFrameState { get;  set; } 
		string m_bstrEnabledRuleText { get;  set; } 
		string m_bstrValidRuleText { get;  set; } 
		string m_bstrActionText { get;  set; } 
		string m_bstrEntryActionID { get;  set; } 
		string m_bstrEntryActionText { get;  set; } 
		string m_bstrBackgroundStyle { get;  set; } 
	}
}

#region History
/*
 * $History: IFrameObj.cs $
 * 
 * *****************  Version 1  *****************
 * User: John.gwynn   Date: 4/28/09    Time: 10:47a
 * Created in $/SourceCode/Components/FNS2005/FnsInterfaces
 * added ICall and callflow interface definitions
 */
#endregion
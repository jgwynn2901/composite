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
/* $Header: /SourceCode/Components/FNS2005/FnsInterfaces/IFieldObj.cs 1     4/28/09 10:47a John.gwynn $ */
#endregion


namespace FnsInterfaces
{
	public interface IFieldObj
	{
		string m_bstrAttributeID { get;  set; } 
		string m_bstrAttributeName { get;  set; } 
		string m_bstrEntrymask { get;  set; } 
		string m_bstrDescription { get;  set; } 
		string m_bstrValidValueFieldFlg { get;  set; } 
		string m_bstrDefaultValue { get;  set; } 
		string m_bstrFrameID { get;  set; } 
		string m_bstrActionID { get;  set; } 
		string m_bstrXPos { get;  set; } 
		string m_bstrYPos { get;  set; } 
		string m_bstrSpellCheckFlg { get;  set; } 
		string m_bstrTextLength { get;  set; } 
		string m_bstrEnabledRuleID { get;  set; } 
		string m_bstrValidRuleID { get;  set; } 
		string m_bstrLUTypeID { get;  set; } 
		string m_bstrHeight { get;  set; } 
		string m_bstrWidth { get;  set; } 
		string m_bstrHelpString { get;  set; } 
		string m_bstrInputType { get;  set; } 
		string m_bstrPersistRuleID { get;  set; } 
		string m_bstrUnknownValue { get;  set; } 
		string m_bstrAttribFrameID { get;  set; } 
		string m_bstrSequence { get;  set; } 
		string m_bstrCaption { get;  set; } 
		string m_bstrValidRuleText { get;  set; } 
		string m_bstrEnabledRuleText { get;  set; } 
		string m_bstrType { get;  set; } 
		string m_bstrMandatoryFlg { get;  set; } 
		string m_bstrLUColumnName { get;  set; } 
		string m_bstrLUDisplayFlg { get;  set; } 
		string m_bstrLUStorageFlg { get;  set; } 
		string m_bstrLUStorageName { get;  set; } 
		void LoadLUValues();
		string m_bstrLUValues { get;  set; } 
		string m_bstrActionText { get;  set; } 
		string m_bstrFieldState { get;  set; } 
		string m_bstrPersistRuleText { get;  set; } 
		string m_bstrVisibleRuleText { get;  set; } 
		string m_bstrAttrInstanceID { get;  set; } 
		void CheckOverrides( string bstrFieldList);
		string m_bstrLUCriteriaFlg { get;  set; } 
		string m_bstrVisibleRuleID { get;  set; } 
		string m_bstrClientOverride { get;  set; } 
		string GetOverRideList( ref string pbstrProperty);
		string m_bstrReapplyOverrideFlag { get;  set; } 
	}
}
#region History
/*
 * $History: IFieldObj.cs $
 * 
 * *****************  Version 1  *****************
 * User: John.gwynn   Date: 4/28/09    Time: 10:47a
 * Created in $/SourceCode/Components/FNS2005/FnsInterfaces
 * added ICall and callflow interface definitions
 */
#endregion
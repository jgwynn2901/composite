using System.Runtime.InteropServices;
namespace DbClassLibrary.Callflow
{
	/// <summary>
	/// Interface to Callflow attribute class
	/// </summary>
	[Guid("FCB9F29A-2293-430f-B013-1B65A1DCA576")]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)] 
	public interface IAttribute
	{
		/// <summary>
		/// Gets or sets the action id.
		/// </summary>
		/// <value>The action id.</value>
		string ActionId { get; set; }
		/// <summary>
		/// Gets or sets the action text.
		/// </summary>
		/// <value>The action text.</value>
		string ActionText { get; set; }
		/// <summary>
		/// Gets or sets the ao action text.
		/// </summary>
		/// <value>The ao action text.</value>
		string AoActionText { get; set; }
		/// <summary>
		/// Gets or sets the ao caption.
		/// </summary>
		/// <value>The ao caption.</value>
		string AoCaption { get; set; }
		/// <summary>
		/// Gets or sets the ao default value.
		/// </summary>
		/// <value>The ao default value.</value>
		string AoDefaultValue { get; set; }
		/// <summary>
		/// Gets or sets the ao description.
		/// </summary>
		/// <value>The ao description.</value>
		string AoDescription { get; set; }
		/// <summary>
		/// Gets or sets the ao enabled rule text.
		/// </summary>
		/// <value>The ao enabled rule text.</value>
		string AoEnabledRuleText { get; set; }
		/// <summary>
		/// Gets or sets the ao entry mask.
		/// </summary>
		/// <value>The ao entry mask.</value>
		string AoEntryMask { get; set; }
		/// <summary>
		/// Gets or sets the ao help string.
		/// </summary>
		/// <value>The ao help string.</value>
		string AoHelpString { get; set; }
		/// <summary>
		/// Gets or sets the type of the ao input.
		/// </summary>
		/// <value>The type of the ao input.</value>
		string AoInputType { get; set; }
		/// <summary>
		/// Gets or sets the ao lu type id.
		/// </summary>
		/// <value>The ao lu type id.</value>
		int AoLuTypeId { get; set; }
		/// <summary>
		/// Gets or sets the ao persist rule text.
		/// </summary>
		/// <value>The ao persist rule text.</value>
		string AoPersistRuleText { get; set; }
		/// <summary>
		/// Gets or sets the ao sequence.
		/// </summary>
		/// <value>The ao sequence.</value>
		int AoSequence { get; set; }
		/// <summary>
		/// Gets or sets the ao spell check flag.
		/// </summary>
		/// <value>The ao spell check flag.</value>
		string AoSpellCheckFlag { get; set; }
		/// <summary>
		/// Gets or sets the length of the ao text.
		/// </summary>
		/// <value>The length of the ao text.</value>
		int AoTextLength { get; set; }
		/// <summary>
		/// Gets or sets the ao unknown value.
		/// </summary>
		/// <value>The ao unknown value.</value>
		string AoUnknownValue { get; set; }
		/// <summary>
		/// Gets or sets the ao val id rule text.
		/// </summary>
		/// <value>The ao val id rule text.</value>
		string AoValIdRuleText { get; set; }
		/// <summary>
		/// Gets or sets the ao valid value field FLG.
		/// </summary>
		/// <value>The ao valid value field FLG.</value>
		string AoValidValueFieldFlg { get; set; }
		/// <summary>
		/// Gets or sets the name of the attrib.
		/// </summary>
		/// <value>The name of the attrib.</value>
		string AttribName { get; set; }
		/// <summary>
		/// Gets or sets the attributeframe id.
		/// </summary>
		/// <value>The attributeframe id.</value>
		int AttributeframeId { get; set; }
		/// <summary>
		/// Gets or sets the attribute id.
		/// </summary>
		/// <value>The attribute id.</value>
		int AttributeId { get; set; }
		/// <summary>
		/// Gets or sets the attr instance id.
		/// </summary>
		/// <value>The attr instance id.</value>
		string AttrInstanceId { get; set; }
		/// <summary>
		/// Gets or sets the caption.
		/// </summary>
		/// <value>The caption.</value>
		string Caption { get; set; }
		/// <summary>
		/// Gets or sets the default value.
		/// </summary>
		/// <value>The default value.</value>
		string DefaultValue { get; set; }
		/// <summary>
		/// Gets or sets the description.
		/// </summary>
		/// <value>The description.</value>
		string Description { get; set; }
		/// <summary>
		/// Gets or sets the enabled rule id.
		/// </summary>
		/// <value>The enabled rule id.</value>
		int EnabledRuleId { get; set; }
		/// <summary>
		/// Gets or sets the enabled rule text.
		/// </summary>
		/// <value>The enabled rule text.</value>
		string EnabledRuleText { get; set; }
		/// <summary>
		/// Gets or sets the entry mask.
		/// </summary>
		/// <value>The entry mask.</value>
		string EntryMask { get; set; }
		/// <summary>
		/// Gets or sets the frame id.
		/// </summary>
		/// <value>The frame id.</value>
		string FrameId { get; set; }
		/// <summary>
		/// Gets or sets the height.
		/// </summary>
		/// <value>The height.</value>
		int Height { get; set; }
		/// <summary>
		/// Gets or sets the help string.
		/// </summary>
		/// <value>The help string.</value>
		string HelpString { get; set; }
		/// <summary>
		/// Gets or sets the type of the input.
		/// </summary>
		/// <value>The type of the input.</value>
		string InputType { get; set; }
		/// <summary>
		/// Gets or sets the name of the lu column.
		/// </summary>
		/// <value>The name of the lu column.</value>
		string LuColumnName { get; set; }
		/// <summary>
		/// Gets or sets the lucriteria FLG.
		/// </summary>
		/// <value>The lucriteria FLG.</value>
		string LucriteriaFlg { get; set; }
		/// <summary>
		/// Gets or sets the lu display FLG.
		/// </summary>
		/// <value>The lu display FLG.</value>
		string LuDisplayFlg { get; set; }
		/// <summary>
		/// Gets or sets the lu storage FLG.
		/// </summary>
		/// <value>The lu storage FLG.</value>
		string LuStorageFlg { get; set; }
		/// <summary>
		/// Gets or sets the name of the lu storage.
		/// </summary>
		/// <value>The name of the lu storage.</value>
		string LuStorageName { get; set; }
		/// <summary>
		/// Gets or sets the lu type id.
		/// </summary>
		/// <value>The lu type id.</value>
		int LuTypeId { get; set; }
		/// <summary>
		/// Gets or sets the mandatory FLG.
		/// </summary>
		/// <value>The mandatory FLG.</value>
		string MandatoryFlg { get; set; }
		/// <summary>
		/// Gets or sets the override rule text.
		/// </summary>
		/// <value>The override rule text.</value>
		string OverrideRuleText { get; set; }
		/// <summary>
		/// Gets or sets the persist rule id.
		/// </summary>
		/// <value>The persist rule id.</value>
		string PersistRuleId { get; set; }
		/// <summary>
		/// Gets or sets the persist rule text.
		/// </summary>
		/// <value>The persist rule text.</value>
		string PersistRuleText { get; set; }
		/// <summary>
		/// Gets or sets the name of the property.
		/// </summary>
		/// <value>The name of the property.</value>
		string PropertyName { get; set; }
		/// <summary>
		/// Gets or sets the reapply override flag.
		/// </summary>
		/// <value>The reapply override flag.</value>
		string ReapplyOverrideFlag { get; set; }
		/// <summary>
		/// Gets or sets the sequence.
		/// </summary>
		/// <value>The sequence.</value>
		int Sequence { get; set; }
		/// <summary>
		/// Gets or sets the spell check flag.
		/// </summary>
		/// <value>The spell check flag.</value>
		string SpellCheckFlag { get; set; }
		/// <summary>
		/// Gets or sets the length of the text.
		/// </summary>
		/// <value>The length of the text.</value>
		string TextLength { get; set; }
		/// <summary>
		/// Gets or sets the type.
		/// </summary>
		/// <value>The type.</value>
		string Type { get; set; }
		/// <summary>
		/// Gets or sets the unknown value.
		/// </summary>
		/// <value>The unknown value.</value>
		string UnknownValue { get; set; }
		/// <summary>
		/// Gets or sets the valid rule id.
		/// </summary>
		/// <value>The valid rule id.</value>
		int ValidRuleId { get; set; }
		/// <summary>
		/// Gets or sets the valid rule text.
		/// </summary>
		/// <value>The valid rule text.</value>
		string ValidRuleText { get; set; }
		/// <summary>
		/// Gets or sets the val id value field flag.
		/// </summary>
		/// <value>The val id value field flag.</value>
		string ValIdValueFieldFlag { get; set; }
		/// <summary>
		/// Gets or sets the value.
		/// </summary>
		/// <value>The value.</value>
		string Value { get; set; }
		/// <summary>
		/// Gets or sets the visible rule id.
		/// </summary>
		/// <value>The visible rule id.</value>
		int VisibleRuleId { get; set; }
		/// <summary>
		/// Gets or sets the visible rule text.
		/// </summary>
		/// <value>The visible rule text.</value>
		string VisibleRuleText { get; set; }
		/// <summary>
		/// Gets or sets the width.
		/// </summary>
		/// <value>The width.</value>
		int Width { get; set; }
		/// <summary>
		/// Gets or sets the xpos.
		/// </summary>
		/// <value>The xpos.</value>
		int Xpos { get; set; }
		/// <summary>
		/// Gets or sets the ypos.
		/// </summary>
		/// <value>The ypos.</value>
		int Ypos { get; set; }
	}
}

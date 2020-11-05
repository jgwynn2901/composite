using System.Runtime.InteropServices;
namespace DbClassLibrary.Callflow
{
	/// <summary>
	/// Callflow Frame interface
	/// </summary>
	[Guid("E0571CD3-DD06-40c8-84BA-6D5A776A7440")]
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
	public interface IFrame
	{
		/// <summary>
		/// Gets or sets the accnt hrcy step id.
		/// </summary>
		/// <value>The accnt hrcy step id.</value>
		string AccntHrcyStepId { get; set; }
		/// <summary>
		/// Gets or sets the accountcallflow id.
		/// </summary>
		/// <value>The accountcallflow id.</value>
		string AccountcallflowId { get; set; }
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
		/// Gets or sets the active end date.
		/// </summary>
		/// <value>The active end date.</value>
		string ActiveEndDate { get; set; }
		/// <summary>
		/// Gets or sets the active start date.
		/// </summary>
		/// <value>The active start date.</value>
		string ActiveStartDate { get; set; }
		/// <summary>
		/// Gets or sets the attribute prefix.
		/// </summary>
		/// <value>The attribute prefix.</value>
		string AttributePrefix { get; set; }
		/// <summary>
		/// Gets the list of attributes.
		/// </summary>
		/// <value>The frame attributes.</value>
		[ComVisible(false)]
		System.Collections.Generic.IEnumerable<Attribute> Attributes { get; }
		/// <summary>
		/// Gets or sets the background style.
		/// </summary>
		/// <value>The background style.</value>
		string BackgroundStyle { get; set; }
		/// <summary>
		/// Gets or sets the callflow decription.
		/// </summary>
		/// <value>The callflow decription.</value>
		string CallflowDecription { get; set; }
		/// <summary>
		/// Gets or sets the callflow id.
		/// </summary>
		/// <value>The callflow id.</value>
		int CallflowId { get; set; }
		/// <summary>
		/// Gets or sets the name of the callflow.
		/// </summary>
		/// <value>The name of the callflow.</value>
		string CallflowName { get; set; }
		/// <summary>
		/// Gets or sets the type of the callflow.
		/// </summary>
		/// <value>The type of the callflow.</value>
		string CallflowType { get; set; }
		/// <summary>
		/// Gets or sets the callflowvalidrule id.
		/// </summary>
		/// <value>The callflowvalidrule id.</value>
		string CallflowvalidruleId { get; set; }
		/// <summary>
		/// Gets or sets the callflow valid rule text.
		/// </summary>
		/// <value>The callflow valid rule text.</value>
		string CallflowValidRuleText { get; set; }
		/// <summary>
		/// Gets or sets the call start flag.
		/// </summary>
		/// <value>The call start flag.</value>
		string CallStartFlag { get; set; }
		/// <summary>
		/// Gets or sets the calltype id.
		/// </summary>
		/// <value>The calltype id.</value>
		string CalltypeId { get; set; }
		/// <summary>
		/// Gets or sets the cat flag.
		/// </summary>
		/// <value>The cat flag.</value>
		string CatFlag { get; set; }
		/// <summary>
		/// Gets or sets the enabled if rule text.
		/// </summary>
		/// <value>The enabled if rule text.</value>
		string EnabledIfRuleText { get; set; }
		/// <summary>
		/// Gets or sets the enabled rule id.
		/// </summary>
		/// <value>The enabled rule id.</value>
		string EnabledRuleId { get; set; }
		/// <summary>
		/// Gets or sets the entry action id.
		/// </summary>
		/// <value>The entry action id.</value>
		string EntryActionId { get; set; }
		/// <summary>
		/// Gets or sets the entry action text.
		/// </summary>
		/// <value>The entry action text.</value>
		string EntryActionText { get; set; }
		/// <summary>
		/// Gets or sets the FNS client code.
		/// </summary>
		/// <value>The FNS client code.</value>
		string FnsClientCode { get; set; }
		/// <summary>
		/// Gets or sets the frame decription.
		/// </summary>
		/// <value>The frame decription.</value>
		string FrameDecription { get; set; }
		/// <summary>
		/// Gets or sets the frame id.
		/// </summary>
		/// <value>The frame id.</value>
		int FrameId { get; set; }
		/// <summary>
		/// Gets or sets the name of the frame.
		/// </summary>
		/// <value>The name of the frame.</value>
		string FrameName { get; set; }
		/// <summary>
		/// Gets or sets the helpstring.
		/// </summary>
		/// <value>The helpstring.</value>
		string Helpstring { get; set; }
		/// <summary>
		/// Gets or sets the lob code.
		/// </summary>
		/// <value>The lob code.</value>
		string LobCode { get; set; }
		/// <summary>
		/// Gets or sets the max page result rows.
		/// </summary>
		/// <value>The max page result rows.</value>
		string MaxPageResultRows { get; set; }
		/// <summary>
		/// Gets or sets the modal flag.
		/// </summary>
		/// <value>The modal flag.</value>
		string ModalFlag { get; set; }
		/// <summary>
		/// Gets or sets the one row auto select flag.
		/// </summary>
		/// <value>The one row auto select flag.</value>
		string OneRowAutoSelectFlag { get; set; }
		/// <summary>
		/// Gets or sets the sequence.
		/// </summary>
		/// <value>The sequence.</value>
		int Sequence { get; set; }
		/// <summary>
		/// Gets or sets the sqlfrom.
		/// </summary>
		/// <value>The sqlfrom.</value>
		string Sqlfrom { get; set; }
		/// <summary>
		/// Gets or sets the sqlorderby.
		/// </summary>
		/// <value>The sqlorderby.</value>
		string Sqlorderby { get; set; }
		/// <summary>
		/// Gets or sets the sqlselect.
		/// </summary>
		/// <value>The sqlselect.</value>
		string Sqlselect { get; set; }
		/// <summary>
		/// Gets or sets the sqlwhere.
		/// </summary>
		/// <value>The sqlwhere.</value>
		string Sqlwhere { get; set; }
		/// <summary>
		/// Gets or sets the title.
		/// </summary>
		/// <value>The title.</value>
		string Title { get; set; }
		/// <summary>
		/// Gets or sets the type.
		/// </summary>
		/// <value>The type.</value>
		string Type { get; set; }
		/// <summary>
		/// Gets or sets the valid if rule text.
		/// </summary>
		/// <value>The valid if rule text.</value>
		string ValidIfRuleText { get; set; }
		/// <summary>
		/// Gets or sets the valid rule id.
		/// </summary>
		/// <value>The valid rule id.</value>
		string ValidRuleId { get; set; }

        /// <summary>
        /// serialize to json.
        /// </summary>
        /// <returns></returns>
	    string ToJson();
	}
}

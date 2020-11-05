using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.InteropServices;
using System.Text;
using Newtonsoft.Json;

namespace DbClassLibrary.Callflow
{
	/// <summary>
	/// encapsulates attribute_view elements
	/// </summary>
	[ClassInterface(ClassInterfaceType.None)]
	public class Frame : ActiveRecord, IFrame
	{
		private List<Attribute> _lazyAttributes;

		#region Constructors
		/// <summary>
		/// Initializes a new instance of the <see cref="Frame"/> class.
		/// </summary>
		public Frame()
			: base("CALLFLOW_VIEW")
		{
			columns.Add(new Column("FNS_CLIENT_CD", String.Empty, "CHAR"));
			columns.Add(new Column("ACCNT_HRCY_STEP_ID", String.Empty, "NUMBER"));
			columns.Add(new Column("LOB_CD", String.Empty, "CHAR"));
			columns.Add(new Column("CALLFLOW_TYPE", String.Empty, "VARCHAR2"));
			columns.Add(new Column("ACCOUNTCALLFLOW_ID", String.Empty, "NUMBER"));
			columns.Add(new Column("CALL_START_FLG", String.Empty, "CHAR"));
			columns.Add(new Column("CALLFLOWVALIDRULE_ID", String.Empty, "NUMBER"));
			columns.Add(new Column("CALLFLOW_ID", String.Empty, "NUMBER"));
			columns.Add(new Column("CALLTYPE_ID", String.Empty, "NUMBER"));
			columns.Add(new Column("CALLFLOW_NAME", String.Empty, "VARCHAR2"));
			columns.Add(new Column("CAT_FLG", String.Empty, "CHAR"));
			columns.Add(new Column("CALLFLOW_DESC", String.Empty, "VARCHAR2"));
			columns.Add(new Column("FRAME_ID", String.Empty, "NUMBER"));
			primaryKeyIndex = 12;
			columns.Add(new Column("SEQUENCE", String.Empty, "NUMBER"));
			columns.Add(new Column("FRAME_NAME", String.Empty, "VARCHAR2"));
			columns.Add(new Column("ENABLEDRULE_ID", String.Empty, "NUMBER"));
			columns.Add(new Column("VALIDRULE_ID", String.Empty, "NUMBER"));
			columns.Add(new Column("TITLE", String.Empty, "VARCHAR2"));
			columns.Add(new Column("MODAL_FLG", String.Empty, "VARCHAR2"));
			columns.Add(new Column("FRAME_DESC", String.Empty, "VARCHAR2"));
			columns.Add(new Column("ACTION_ID", String.Empty, "NUMBER"));
			columns.Add(new Column("HELPSTRING", String.Empty, "VARCHAR2"));
			columns.Add(new Column("ATTRIBUTE_PREFIX", String.Empty, "VARCHAR2"));
			columns.Add(new Column("TYPE", String.Empty, "VARCHAR2"));
			columns.Add(new Column("SQLSELECT", String.Empty, "VARCHAR2"));
			columns.Add(new Column("SQLFROM", String.Empty, "VARCHAR2"));
			columns.Add(new Column("SQLWHERE", String.Empty, "VARCHAR2"));
			columns.Add(new Column("SQLORDERBY", String.Empty, "VARCHAR2"));
			columns.Add(new Column("MAXPAGERESULTROWS", String.Empty, "NUMBER"));
			columns.Add(new Column("ONEROWAUTOSELECT_FLG", String.Empty, "VARCHAR2"));
			columns.Add(new Column("ENTRY_ACTION_ID", String.Empty, "NUMBER"));
			columns.Add(new Column("BACKGROUNDSTYLE", String.Empty, "VARCHAR2"));
			columns.Add(new Column("ENABLEDIF_RULE_TEXT", String.Empty, "VARCHAR2"));
			columns.Add(new Column("VALIDIF_RULE_TEXT", String.Empty, "VARCHAR2"));
			columns.Add(new Column("ACTION_TEXT", String.Empty, "VARCHAR2"));
			columns.Add(new Column("ENTRY_ACTION_TEXT", String.Empty, "VARCHAR2"));
			columns.Add(new Column("CALLFLOWVALIDRULE_TEXT", String.Empty, "VARCHAR2"));
			columns.Add(new Column("ACTIVE_START_DT", String.Empty, "DATE"));
			columns.Add(new Column("ACTIVE_END_DT", String.Empty, "DATE"));
		    _serialize = AttributesToJson;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="Frame"/> class.
		/// </summary>
		/// <param name="reader">The source data reader.</param>
		public Frame(IDataReader reader)
			: base(reader, "CALLFLOW_VIEW")
		{
            _serialize = AttributesToJson;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="Frame"/> class.
		/// This constructor is required for typesafe cloning.
		/// </summary>
		/// <param name="source">The source.</param>
		public Frame(ActiveRecord source)
			: base(source)
		{
            _serialize = AttributesToJson;
		}

		#endregion

		#region Properties

		/// <summary>
		/// frame level attribute set
		/// </summary>
		public new IEnumerable<Attribute> Attributes
		{
			get
			{
				lock (this)
				{
					if (_lazyAttributes == null)
						GetAttributes();
				}
	
				return _lazyAttributes;
			}
		}

		private void GetAttributes()
		{
			if (null != _lazyAttributes) return;
			_lazyAttributes = new List<Attribute>();
			var attributes = new AttributeSet { Instance = Instance, FrameId = FrameId };
			if (!attributes.Execute())
				lastErrorMessage = attributes.LastError;
			else
				foreach (Attribute attribute in attributes )
					_lazyAttributes.Add(attribute);
		}

		#region FnsClientCode
		/// <summary>
		/// FNS_CLIENT_CD
		/// </summary>
		public string FnsClientCode
		{
			get { return GetColumnValue("FNS_CLIENT_CD"); }
			set { SetColumnValue("FNS_CLIENT_CD", value); }
		}
		#endregion

		#region AccntHrcyStepId
		/// <summary>
		/// ACCNT_HRCY_STEP_ID
		/// </summary>
		public string AccntHrcyStepId
		{
			get
			{
				return GetColumnValue("ACCNT_HRCY_STEP_ID");
			}
			set
			{
				SetColumnValue("ACCNT_HRCY_STEP_ID", value);
			}
		}
		#endregion

		#region LobCode
		/// <summary>
		/// LOB_CD
		/// </summary>
		public string LobCode
		{
			get
			{
				return GetColumnValue("LOB_CD");
			}
			set
			{
				SetColumnValue("LOB_CD", value);
			}
		}
		#endregion

		#region CallflowType
		/// <summary>
		/// CALLFLOW_TYPE
		/// </summary>
		public string CallflowType
		{
			get
			{
				return GetColumnValue("CALLFLOW_TYPE");
			}
			set
			{
				SetColumnValue("CALLFLOW_TYPE", value);
			}
		}
		#endregion

		#region AccountcallflowId
		/// <summary>
		/// ACCOUNTCALLFLOW_ID
		/// </summary>
		public string AccountcallflowId
		{
			get
			{
				return GetColumnValue("ACCOUNTCALLFLOW_ID");
			}
			set
			{
				SetColumnValue("ACCOUNTCALLFLOW_ID", value);
			}
		}
		#endregion

		#region CallStartFlag
		/// <summary>
		/// CALL_START_FLG
		/// </summary>
		public string CallStartFlag
		{
			get
			{
				return GetColumnValue("CALL_START_FLG");
			}
			set
			{
				SetColumnValue("CALL_START_FLG", value);
			}
		}
		#endregion

		#region CallflowvalidruleId
		/// <summary>
		/// CALLFLOWVALIDRULE_ID
		/// </summary>
		public string CallflowvalidruleId
		{
			get
			{
				return GetColumnValue("CALLFLOWVALIDRULE_ID");
			}
			set
			{
				SetColumnValue("CALLFLOWVALIDRULE_ID", value);
			}
		}
		#endregion

		#region CallflowId
		/// <summary>
		/// CALLFLOW_ID
		/// </summary>
		public int CallflowId
		{
			get
			{
				return GetColumnValueAsInt("CALLFLOW_ID") ?? 0;
			}
			set
			{
				SetColumnValue("CALLFLOW_ID", value.ToString());
			}
		}
		#endregion

		#region CalltypeId
		/// <summary>
		/// CALLTYPE_ID
		/// </summary>
		public string CalltypeId
		{
			get
			{
				return GetColumnValue("CALLTYPE_ID");
			}
			set
			{
				SetColumnValue("CALLTYPE_ID", value);
			}
		}
		#endregion

		#region CallflowName
		/// <summary>
		/// CALLFLOW_NAME
		/// </summary>
		public string CallflowName
		{
			get
			{
				return GetColumnValue("CALLFLOW_NAME");
			}
			set
			{
				SetColumnValue("CALLFLOW_NAME", value);
			}
		}
		#endregion

		#region CatFlag
		/// <summary>
		/// CAT_FLG
		/// </summary>
		public string CatFlag
		{
			get
			{
				return GetColumnValue("CAT_FLG");
			}
			set
			{
				SetColumnValue("CAT_FLG", value);
			}
		}
		#endregion

		#region CallflowDecription
		/// <summary>
		/// CALLFLOW_DESC
		/// </summary>
		public string CallflowDecription
		{
			get
			{
				return GetColumnValue("CALLFLOW_DESC");
			}
			set
			{
				SetColumnValue("CALLFLOW_DESC", value);
			}
		}
		#endregion

		#region FrameId
		/// <summary>
		/// FRAME_ID
		/// </summary>
		public int FrameId
		{
			get
			{
				return GetColumnValueAsInt("FRAME_ID") ?? 0;
			}
			set
			{
				SetColumnValue("FRAME_ID", value.ToString());
			}
		}
		#endregion

		#region Sequence
		/// <summary>
		/// SEQUENCE
		/// </summary>
		public int Sequence
		{
			get
			{
				return GetColumnValueAsInt("SEQUENCE") ?? 0;
			}
			set
			{
				SetColumnValue("SEQUENCE", value.ToString());
			}
		}
		#endregion

		#region FrameName
		/// <summary>
		/// FRAME_NAME
		/// </summary>
		public string FrameName
		{
			get
			{
				return GetColumnValue("FRAME_NAME");
			}
			set
			{
				SetColumnValue("FRAME_NAME", value);
			}
		}
		#endregion

		#region EnabledRuleId
		/// <summary>
		/// ENABLEDRULE_ID
		/// </summary>
		public string EnabledRuleId
		{
			get
			{
				return GetColumnValue("ENABLEDRULE_ID");
			}
			set
			{
				SetColumnValue("ENABLEDRULE_ID", value);
			}
		}
		#endregion

		#region ValidRuleId
		/// <summary>
		/// VALIDRULE_ID
		/// </summary>
		public string ValidRuleId
		{
			get
			{
				return GetColumnValue("VALIDRULE_ID");
			}
			set
			{
				SetColumnValue("VALIDRULE_ID", value);
			}
		}
		#endregion

		#region Title
		/// <summary>
		/// TITLE
		/// </summary>
		public string Title
		{
			get
			{
				return GetColumnValue("TITLE");
			}
			set
			{
				SetColumnValue("TITLE", value);
			}
		}
		#endregion

		#region ModalFlag
		/// <summary>
		/// MODAL_FLG
		/// </summary>
		public string ModalFlag
		{
			get
			{
				return GetColumnValue("MODAL_FLG");
			}
			set
			{
				SetColumnValue("MODAL_FLG", value);
			}
		}
		#endregion

		#region FrameDecription
		/// <summary>
		/// FRAME_DESC
		/// </summary>
		public string FrameDecription
		{
			get
			{
				return GetColumnValue("FRAME_DESC");
			}
			set
			{
				SetColumnValue("FRAME_DESC", value);
			}
		}
		#endregion

		#region ActionId
		/// <summary>
		/// ACTION_ID
		/// </summary>
		public string ActionId
		{
			get
			{
				return GetColumnValue("ACTION_ID");
			}
			set
			{
				SetColumnValue("ACTION_ID", value);
			}
		}
		#endregion

		#region Helpstring
		/// <summary>
		/// HELPSTRING
		/// </summary>
		public string Helpstring
		{
			get
			{
				return GetColumnValue("HELPSTRING");
			}
			set
			{
				SetColumnValue("HELPSTRING", value);
			}
		}
		#endregion

		#region AttributePrefix
		/// <summary>
		/// ATTRIBUTE_PREFIX
		/// </summary>
		public string AttributePrefix
		{
			get
			{
				return GetColumnValue("ATTRIBUTE_PREFIX");
			}
			set
			{
				SetColumnValue("ATTRIBUTE_PREFIX", value);
			}
		}
		#endregion

		#region Type
		/// <summary>
		/// TYPE
		/// </summary>
		public string Type
		{
			get
			{
				return GetColumnValue("TYPE");
			}
			set
			{
				SetColumnValue("TYPE", value);
			}
		}
		#endregion

		#region Sqlselect
		/// <summary>
		/// SQLSELECT
		/// </summary>
		public string Sqlselect
		{
			get
			{
				return GetColumnValue("SQLSELECT");
			}
			set
			{
				SetColumnValue("SQLSELECT", value);
			}
		}
		#endregion

		#region Sqlfrom
		/// <summary>
		/// SQLFROM
		/// </summary>
		public string Sqlfrom
		{
			get
			{
				return GetColumnValue("SQLFROM");
			}
			set
			{
				SetColumnValue("SQLFROM", value);
			}
		}
		#endregion

		#region Sqlwhere
		/// <summary>
		/// SQLWHERE
		/// </summary>
		public string Sqlwhere
		{
			get
			{
				return GetColumnValue("SQLWHERE");
			}
			set
			{
				SetColumnValue("SQLWHERE", value);
			}
		}
		#endregion

		#region Sqlorderby
		/// <summary>
		/// SQLORDERBY
		/// </summary>
		public string Sqlorderby
		{
			get
			{
				return GetColumnValue("SQLORDERBY");
			}
			set
			{
				SetColumnValue("SQLORDERBY", value);
			}
		}
		#endregion

		#region MaxPageResultRows
		/// <summary>
		/// MAXPAGERESULTROWS
		/// </summary>
		public string MaxPageResultRows
		{
			get
			{
				return GetColumnValue("MAXPAGERESULTROWS");
			}
			set
			{
				SetColumnValue("MAXPAGERESULTROWS", value);
			}
		}
		#endregion

		#region OneRowAutoSelectFlag
		/// <summary>
		/// ONEROWAUTOSELECT_FLG
		/// </summary>
		public string OneRowAutoSelectFlag
		{
			get
			{
				return GetColumnValue("ONEROWAUTOSELECT_FLG");
			}
			set
			{
				SetColumnValue("ONEROWAUTOSELECT_FLG", value);
			}
		}
		#endregion

		#region EntryActionId
		/// <summary>
		/// ENTRY_ACTION_ID
		/// </summary>
		public string EntryActionId
		{
			get
			{
				return GetColumnValue("ENTRY_ACTION_ID");
			}
			set
			{
				SetColumnValue("ENTRY_ACTION_ID", value);
			}
		}
		#endregion

		#region BackgroundStyle
		/// <summary>
		/// BACKGROUNDSTYLE
		/// </summary>
		public string BackgroundStyle
		{
			get
			{
				return GetColumnValue("BACKGROUNDSTYLE");
			}
			set
			{
				SetColumnValue("BACKGROUNDSTYLE", value);
			}
		}
		#endregion

		#region EnabledIfRuleText
		/// <summary>
		/// ENABLEDIF_RULE_TEXT
		/// </summary>
		public string EnabledIfRuleText
		{
			get
			{
				return GetColumnValue("ENABLEDIF_RULE_TEXT");
			}
			set
			{
				SetColumnValue("ENABLEDIF_RULE_TEXT", value);
			}
		}
		#endregion

		#region ValidIfRuleText
		/// <summary>
		/// VALIDIF_RULE_TEXT
		/// </summary>
		public string ValidIfRuleText
		{
			get
			{
				return GetColumnValue("VALIDIF_RULE_TEXT");
			}
			set
			{
				SetColumnValue("VALIDIF_RULE_TEXT", value);
			}
		}
		#endregion

		#region ActionText
		/// <summary>
		/// ACTION_TEXT
		/// </summary>
		public string ActionText
		{
			get
			{
				return GetColumnValue("ACTION_TEXT");
			}
			set
			{
				SetColumnValue("ACTION_TEXT", value);
			}
		}
		#endregion

		#region EntryActionText
		/// <summary>
		/// ENTRY_ACTION_TEXT
		/// </summary>
		public string EntryActionText
		{
			get
			{
				return GetColumnValue("ENTRY_ACTION_TEXT");
			}
			set
			{
				SetColumnValue("ENTRY_ACTION_TEXT", value);
			}
		}
		#endregion

		#region CallflowValidRuleText
		/// <summary>
		/// CALLFLOWVALIDRULE_TEXT
		/// </summary>
		public string CallflowValidRuleText
		{
			get
			{
				return GetColumnValue("CALLFLOWVALIDRULE_TEXT");
			}
			set
			{
				SetColumnValue("CALLFLOWVALIDRULE_TEXT", value);
			}
		}
		#endregion

		#region ActiveStartDate
		/// <summary>
		/// ACTIVE_START_DT
		/// </summary>
		public string ActiveStartDate
		{
			get
			{
				return GetColumnValue("ACTIVE_START_DT");
			}
			set
			{
				SetColumnValue("ACTIVE_START_DT", value);
			}
		}
		#endregion

		#region ActiveEndDate
		/// <summary>
		/// ACTIVE_END_DT
		/// </summary>
		public string ActiveEndDate
		{
			get
			{
				return GetColumnValue("ACTIVE_END_DT");
			}
			set
			{
				SetColumnValue("ACTIVE_END_DT", value);
			}
		}
		#endregion

		#endregion

		/// <summary>
		/// Compares to.
		/// </summary>
		public bool CompareTo(Frame source)
		{
			var results = true;

			try
			{
				var messages = new StringBuilder();
				for (var i = 0; i < columns.Count; ++i)
					if (!columns[i].CompareTo(source.columns[i]))
					{
						messages.AppendLine(string.Format("FrameID:{0} {1} {2}:{3}={4} {5}:{6}={7}",
															  FrameId, FrameName, Instance,
															  columns[i].Name, columns[i].Value,
															  source.Instance, source.columns[i].Name,
															  source.columns[i].Value));
						results = false;
					}

				if (source != null)
				{
					GetAttributes();
					source.GetAttributes();
					for (var i = 0; i < _lazyAttributes.Count; ++i)
					{
						if (_lazyAttributes[i].CompareTo(source._lazyAttributes[i])) continue;
						messages.AppendLine(string.Format("FrameID:{0}:{1} {2}",
						                                  FrameId, FrameName,
						                                  _lazyAttributes[i].LastError));
						results = false;
					}
				}

				lastErrorMessage = messages.ToString();
			}
			catch (Exception ex)
			{
				lastErrorMessage = ex.Message;
				results = false;
			}
			return results;
		}

        private void AttributesToJson(JsonWriter jsonWriter)
        {
            //jsonWriter.WritePropertyName("Attributes");
            //jsonWriter.WriteStartArray();
            //foreach (var attribute in Attributes)
            //{
            //    jsonWriter.WriteStartObject();
            //    attribute.ToJsonArray(jsonWriter);
            //    jsonWriter.WriteEndObject();
            //}
            //jsonWriter.WriteEndArray();
        }
	}
}

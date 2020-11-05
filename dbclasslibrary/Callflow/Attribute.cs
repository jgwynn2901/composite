using System;
using System.Data;
using System.Globalization;
using System.Runtime.InteropServices;

namespace DbClassLibrary.Callflow
{
	/// <summary>
	/// encapsulates attribute_view elements
	/// </summary>
	[ClassInterface(ClassInterfaceType.None)]
	public class Attribute : ActiveRecord, IAttribute
	{
		private string _value = "";

		#region Constructors
		/// <summary>
		/// Initializes a new instance of the <see cref="Attribute"/> class.
		/// </summary>
		public Attribute()
			: base("ATTRIBUTE_VIEW")
		{
			columns.Add(new Column("ATTRIBUTE_ID", String.Empty, "NUMBER"));
			columns.Add(new Column("ATTRIB_NAME", String.Empty, "VARCHAR2"));
			columns.Add(new Column("LU_TYPE_ID", String.Empty, "NUMBER"));
			columns.Add(new Column("CAPTION", String.Empty, "VARCHAR2"));
			columns.Add(new Column("INPUTTYPE", String.Empty, "VARCHAR2"));
			columns.Add(new Column("ENTRYMASK", String.Empty, "VARCHAR2"));
			columns.Add(new Column("VALIDVALUEFIELD_FLG", String.Empty, "VARCHAR2"));
			columns.Add(new Column("DEFAULTVALUE", String.Empty, "VARCHAR2"));
			columns.Add(new Column("UNKNOWNVALUE", String.Empty, "VARCHAR2"));
			columns.Add(new Column("TEXTLENGTH", String.Empty, "NUMBER"));
			columns.Add(new Column("ENABLEDRULE_ID", String.Empty, "NUMBER"));
			columns.Add(new Column("VALIDRULE_ID", String.Empty, "NUMBER"));
			columns.Add(new Column("PERSISTRULE_ID", String.Empty, "NUMBER"));
			columns.Add(new Column("ACTION_ID", String.Empty, "NUMBER"));
			columns.Add(new Column("VISIBLERULE_ID", String.Empty, "NUMBER"));
			columns.Add(new Column("ENABLED_RULE_TEXT", String.Empty, "VARCHAR2"));
			columns.Add(new Column("VALID_RULE_TEXT", String.Empty, "VARCHAR2"));
			columns.Add(new Column("PERSIST_RULE_TEXT", String.Empty, "VARCHAR2"));
			columns.Add(new Column("ACTION_TEXT", String.Empty, "VARCHAR2"));
			columns.Add(new Column("VISIBLE_RULE_TEXT", String.Empty, "VARCHAR2"));
			columns.Add(new Column("SPELLCHECK_FLG", String.Empty, "VARCHAR2"));
			columns.Add(new Column("HELPSTRING", String.Empty, "VARCHAR2"));
			columns.Add(new Column("DESCRIPTION", String.Empty, "VARCHAR2"));
			columns.Add(new Column("ATTR_INSTANCE_ID", String.Empty, "NUMBER"));
			columns.Add(new Column("FRAME_ID", String.Empty, "NUMBER"));
			columns.Add(new Column("ATTRIBUTEFRAME_ID", String.Empty, "NUMBER"));
			columns.Add(new Column("XPOS", String.Empty, "NUMBER"));
			columns.Add(new Column("YPOS", String.Empty, "NUMBER"));
			columns.Add(new Column("WIDTH", String.Empty, "NUMBER"));
			columns.Add(new Column("HEIGHT", String.Empty, "NUMBER"));
			columns.Add(new Column("SEQUENCE", String.Empty, "NUMBER"));
			columns.Add(new Column("TYPE", String.Empty, "VARCHAR2"));
			columns.Add(new Column("MANDATORY_FLG", String.Empty, "CHAR"));
			columns.Add(new Column("LUCOLUMN_NAME", String.Empty, "VARCHAR2"));
			columns.Add(new Column("LUDISPLAY_FLG", String.Empty, "CHAR"));
			columns.Add(new Column("LUSTORAGE_FLG", String.Empty, "CHAR"));
			columns.Add(new Column("LUSTORAGE_NAME", String.Empty, "VARCHAR2"));
			columns.Add(new Column("LUCRITERIA_FLG", String.Empty, "CHAR"));
			columns.Add(new Column("PROPERTY_NAME", String.Empty, "VARCHAR2"));
			columns.Add(new Column("AO_SEQUENCE", String.Empty, "NUMBER"));
			columns.Add(new Column("AO_LU_TYPE_ID", String.Empty, "NUMBER"));
			columns.Add(new Column("AO_ENTRYMASK", String.Empty, "VARCHAR2"));
			columns.Add(new Column("AO_CAPTION", String.Empty, "VARCHAR2"));
			columns.Add(new Column("AO_INPUTTYPE", String.Empty, "VARCHAR2"));
			columns.Add(new Column("AO_DESCRIPTION", String.Empty, "VARCHAR2"));
			columns.Add(new Column("AO_VALIDVALUEFIELD_FLG", String.Empty, "CHAR"));
			columns.Add(new Column("AO_TEXTLENGTH", String.Empty, "NUMBER"));
			columns.Add(new Column("AO_UNKNOWNVALUE", String.Empty, "VARCHAR2"));
			columns.Add(new Column("AO_DEFAULTVALUE", String.Empty, "VARCHAR2"));
			columns.Add(new Column("AO_SPELLCHECK_FLG", String.Empty, "CHAR"));
			columns.Add(new Column("AO_HELPSTRING", String.Empty, "VARCHAR2"));
			columns.Add(new Column("AO_ENABLED_RULE_TEXT", String.Empty, "VARCHAR2"));
			columns.Add(new Column("AO_VALID_RULE_TEXT", String.Empty, "VARCHAR2"));
			columns.Add(new Column("AO_ACTION_TEXT", String.Empty, "VARCHAR2"));
			columns.Add(new Column("AO_PERSIST_RULE_TEXT", String.Empty, "VARCHAR2"));
			columns.Add(new Column("OVERRIDE_RULE_TEXT", String.Empty, "VARCHAR2"));
			columns.Add(new Column("REAPPLYOVERRIDE_FLG", String.Empty, "CHAR"));
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="Attribute"/> class.
		/// </summary>
		/// <param name="reader">The source data reader.</param>
		public Attribute(IDataReader reader)
			: base(reader, "ATTRIBUTE_VIEW")
		{}

		/// <summary>
		/// Initializes a new instance of the <see cref="Attribute"/> class.
		/// This constructor is required for typesafe cloning.
		/// </summary>
		/// <param name="source">The source.</param>
		public Attribute(ActiveRecord source)
			: base(source)
		{ }

		#endregion

		#region Properties

		#region AttributeId
		/// <summary>
		/// ATTRIBUTE_ID
		/// </summary>
		public int AttributeId
		{
			get
			{
				return GetColumnValueAsInt("ATTRIBUTE_ID") ?? -1;
			}
			set
			{
				SetColumnValue("ATTRIBUTE_ID", value.ToString(CultureInfo.InvariantCulture));
			}
		}
		#endregion

		#region AttribName
		/// <summary>
		/// ATTRIB_NAME
		/// </summary>
		public string AttribName
		{
			get
			{
				return GetColumnValue("ATTRIB_NAME");
			}
			set
			{
				SetColumnValue("ATTRIB_NAME", value);
			}
		}
		#endregion

		#region LuTypeId
		/// <summary>
		/// LU_TYPE_ID
		/// </summary>
		public int LuTypeId
		{
			get
			{
				return GetColumnValueAsInt("LU_TYPE_ID") ?? 0;
			}
			set
			{
				SetColumnValue("LU_TYPE_ID", value.ToString(CultureInfo.InvariantCulture));
			}
		}
		#endregion

		#region Caption
		/// <summary>
		/// CAPTION
		/// </summary>
		public string Caption
		{
			get
			{
				return GetColumnValue("CAPTION");
			}
			set
			{
				SetColumnValue("CAPTION", value);
			}
		}
		#endregion

		#region InputType
		/// <summary>
		/// INPUTTYPE
		/// </summary>
		public string InputType
		{
			get
			{
				return GetColumnValue("INPUTTYPE");
			}
			set
			{
				SetColumnValue("INPUTTYPE", value);
			}
		}
		#endregion

		#region EntryMask
		/// <summary>
		/// ENTRYMASK
		/// </summary>
		public string EntryMask
		{
			get
			{
				return GetColumnValue("ENTRYMASK");
			}
			set
			{
				SetColumnValue("ENTRYMASK", value);
			}
		}
		#endregion

		#region ValIdValueFieldFlag
		/// <summary>
		/// VALIDVALUEFIELD_FLG
		/// </summary>
		public string ValIdValueFieldFlag
		{
			get
			{
				return GetColumnValue("VALIDVALUEFIELD_FLG");
			}
			set
			{
				SetColumnValue("VALIDVALUEFIELD_FLG", value);
			}
		}
		#endregion

		#region DefaultValue
		/// <summary>
		/// DEFAULTVALUE
		/// </summary>
		public string DefaultValue
		{
			get
			{
				return GetColumnValue("DEFAULTVALUE");
			}
			set
			{
				SetColumnValue("DEFAULTVALUE", value);
			}
		}
		#endregion

		#region UnknownValue
		/// <summary>
		/// UNKNOWNVALUE
		/// </summary>
		public string UnknownValue
		{
			get
			{
				return GetColumnValue("UNKNOWNVALUE");
			}
			set
			{
				SetColumnValue("UNKNOWNVALUE", value);
			}
		}
		#endregion

		#region TextLength
		/// <summary>
		/// TEXTLENGTH
		/// </summary>
		public string TextLength
		{
			get
			{
				return GetColumnValue("TEXTLENGTH");
			}
			set
			{
				SetColumnValue("TEXTLENGTH", value);
			}
		}
		#endregion

		#region EnabledRuleId
		/// <summary>
		/// ENABLEDRULE_ID
		/// </summary>
		public int EnabledRuleId
		{
			get
			{
        return GetColumnValueAsInt("ENABLEDRULE_ID") ?? 0;
			}
			set
			{
				SetColumnValue("ENABLEDRULE_ID", value.ToString());
			}
		}
		#endregion

		#region ValidRuleId
		/// <summary>
		/// VALIDRULE_ID
		/// </summary>
		public int ValidRuleId
		{
			get
			{
				return GetColumnValueAsInt("VALIDRULE_ID") ?? 0;
			}
			set
			{
				SetColumnValue("VALIDRULE_ID", value.ToString());
			}
		}
		#endregion

		#region PersistRuleId
		/// <summary>
		/// PERSISTRULE_ID
		/// </summary>
		public string PersistRuleId
		{
			get
			{
				return GetColumnValue("PERSISTRULE_ID");
			}
			set
			{
				SetColumnValue("PERSISTRULE_ID", value);
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

		#region VisibleRuleId
		/// <summary>
		/// VISIBLERULE_ID
		/// </summary>
		public int VisibleRuleId
		{
			get
			{
				return GetColumnValueAsInt("VISIBLERULE_ID") ?? 0;
			}
			set
			{
				SetColumnValue("VISIBLERULE_ID", value.ToString());
			}
		}
		#endregion

		#region EnabledRuleText
		/// <summary>
		/// ENABLED_RULE_TEXT
		/// </summary>
		public string EnabledRuleText
		{
			get
			{
				return GetColumnValue("ENABLED_RULE_TEXT");
			}
			set
			{
				SetColumnValue("ENABLED_RULE_TEXT", value);
			}
		}
		#endregion

		#region ValidRuleText
		/// <summary>
		/// VALID_RULE_TEXT
		/// </summary>
		public string ValidRuleText
		{
			get
			{
				return GetColumnValue("VALID_RULE_TEXT");
			}
			set
			{
				SetColumnValue("VALID_RULE_TEXT", value);
			}
		}
		#endregion

		#region PersistRuleText
		/// <summary>
		/// PERSIST_RULE_TEXT
		/// </summary>
		public string PersistRuleText
		{
			get
			{
				return GetColumnValue("PERSIST_RULE_TEXT");
			}
			set
			{
				SetColumnValue("PERSIST_RULE_TEXT", value);
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

		#region VisibleRuleText
		/// <summary>
		/// VISIBLE_RULE_TEXT
		/// </summary>
		public string VisibleRuleText
		{
			get
			{
				return GetColumnValue("VISIBLE_RULE_TEXT");
			}
			set
			{
				SetColumnValue("VISIBLE_RULE_TEXT", value);
			}
		}
		#endregion

		#region SpellCheckFlag
		/// <summary>
		/// SPELLCHECK_FLG
		/// </summary>
		public string SpellCheckFlag
		{
			get
			{
				return GetColumnValue("SPELLCHECK_FLG");
			}
			set
			{
				SetColumnValue("SPELLCHECK_FLG", value);
			}
		}
		#endregion

		#region HelpString
		/// <summary>
		/// HELPSTRING
		/// </summary>
		public string HelpString
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

		#region Description
		/// <summary>
		/// DESCRIPTION
		/// </summary>
		public string Description
		{
			get
			{
				return GetColumnValue("DESCRIPTION");
			}
			set
			{
				SetColumnValue("DESCRIPTION", value);
			}
		}
		#endregion

		#region AttrInstanceId
		/// <summary>
		/// ATTR_INSTANCE_ID
		/// </summary>
		public string AttrInstanceId
		{
			get
			{
				return GetColumnValue("ATTR_INSTANCE_ID");
			}
			set
			{
				SetColumnValue("ATTR_INSTANCE_ID", value);
			}
		}
		#endregion

		#region FrameId
		/// <summary>
		/// FRAME_ID
		/// </summary>
		public string FrameId
		{
			get
			{
				return GetColumnValue("FRAME_ID");
			}
			set
			{
				SetColumnValue("FRAME_ID", value);
			}
		}
		#endregion

		#region AttributeframeId
		/// <summary>
		/// ATTRIBUTEFRAME_ID
		/// </summary>
		public int AttributeframeId
		{
			get
			{
				return GetColumnValueAsInt("ATTRIBUTEFRAME_ID") ?? 0;
			}
			set
			{
				SetColumnValue("ATTRIBUTEFRAME_ID", value.ToString());
			}
		}
		#endregion

		#region Xpos
		/// <summary>
		/// XPOS
		/// </summary>
		public int Xpos
		{
			get
			{
				return GetColumnValueAsInt("XPOS") ?? -1;
			}
			set
			{
				SetColumnValue("XPOS", value.ToString(CultureInfo.InvariantCulture));
			}
		}
		#endregion

		#region Ypos
		/// <summary>
		/// YPOS
		/// </summary>
		public int Ypos
		{
			get
			{
				return GetColumnValueAsInt("YPOS") ?? -1;
			}
			set
			{
				SetColumnValue("YPOS", value.ToString(CultureInfo.InvariantCulture));
			}
		}
		#endregion

		#region Width
		/// <summary>
		/// WIDTH
		/// </summary>
		public int Width
		{
			get
			{
				return GetColumnValueAsInt("WIDTH") ?? 0;
			}
			set
			{
				SetColumnValue("WIDTH", value.ToString(CultureInfo.InvariantCulture));
			}
		}
		#endregion

		#region Height
		/// <summary>
		/// HEIGHT
		/// </summary>
		public int Height
		{
			get
			{
				return GetColumnValueAsInt("HEIGHT") ?? 0;
			}
			set
			{
				SetColumnValue("HEIGHT", value.ToString(CultureInfo.InvariantCulture));
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
				SetColumnValue("SEQUENCE", value.ToString(CultureInfo.InvariantCulture));
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

		#region MandatoryFlg
		/// <summary>
		/// MANDATORY_FLG
		/// </summary>
		public string MandatoryFlg
		{
			get
			{
				return GetColumnValue("MANDATORY_FLG");
			}
			set
			{
				SetColumnValue("MANDATORY_FLG", value);
			}
		}
		#endregion

		#region LuColumnName
		/// <summary>
		/// LUCOLUMN_NAME
		/// </summary>
		public string LuColumnName
		{
			get
			{
				return GetColumnValue("LUCOLUMN_NAME");
			}
			set
			{
				SetColumnValue("LUCOLUMN_NAME", value);
			}
		}
		#endregion

		#region LuDisplayFlg
		/// <summary>
		/// LUDISPLAY_FLG
		/// </summary>
		public string LuDisplayFlg
		{
			get
			{
				return GetColumnValue("LUDISPLAY_FLG");
			}
			set
			{
				SetColumnValue("LUDISPLAY_FLG", value);
			}
		}
		#endregion

		#region LuStorageFlg
		/// <summary>
		/// LUSTORAGE_FLG
		/// </summary>
		public string LuStorageFlg
		{
			get
			{
				return GetColumnValue("LUSTORAGE_FLG");
			}
			set
			{
				SetColumnValue("LUSTORAGE_FLG", value);
			}
		}
		#endregion

		#region LuStorageName
		/// <summary>
		/// LUSTORAGE_NAME
		/// </summary>
		public string LuStorageName
		{
			get
			{
				return GetColumnValue("LUSTORAGE_NAME");
			}
			set
			{
				SetColumnValue("LUSTORAGE_NAME", value);
			}
		}
		#endregion

		#region LuCriteriaFlg
		/// <summary>
		/// LUCRITERIA_FLG
		/// </summary>
		public string LucriteriaFlg
		{
			get
			{
				return GetColumnValue("LUCRITERIA_FLG");
			}
			set
			{
				SetColumnValue("LUCRITERIA_FLG", value);
			}
		}
		#endregion

		#region PropertyName
		/// <summary>
		/// PROPERTY_NAME
		/// </summary>
		public string PropertyName
		{
			get
			{
				return GetColumnValue("PROPERTY_NAME");
			}
			set
			{
				SetColumnValue("PROPERTY_NAME", value);
			}
		}
		#endregion

		#region AoSequence
		/// <summary>
		/// AO_SEQUENCE
		/// </summary>
		public int AoSequence
		{
			get
			{
				return GetColumnValueAsInt("AO_SEQUENCE") ?? 0;
			}
			set
			{
				SetColumnValue("AO_SEQUENCE", value.ToString(CultureInfo.InvariantCulture));
			}
		}
		#endregion

		#region AoLuTypeId
		/// <summary>
		/// AO_LU_TYPE_ID
		/// </summary>
		public int AoLuTypeId
		{
			get
			{
				return GetColumnValueAsInt("AO_LU_TYPE_ID") ?? 0;
			}
			set
			{
				SetColumnValue("AO_LU_TYPE_ID", value.ToString(CultureInfo.InvariantCulture));
			}
		}
		#endregion

		#region AoEntryMask
		/// <summary>
		/// AO_ENTRYMASK
		/// </summary>
		public string AoEntryMask
		{
			get
			{
				return GetColumnValue("AO_ENTRYMASK");
			}
			set
			{
				SetColumnValue("AO_ENTRYMASK", value);
			}
		}
		#endregion

		#region AoCaption
		/// <summary>
		/// AO_CAPTION
		/// </summary>
		public string AoCaption
		{
			get
			{
				return GetColumnValue("AO_CAPTION");
			}
			set
			{
				SetColumnValue("AO_CAPTION", value);
			}
		}
		#endregion

		#region AoInputType
		/// <summary>
		/// AO_INPUTTYPE
		/// </summary>
		public string AoInputType
		{
			get
			{
				return GetColumnValue("AO_INPUTTYPE");
			}
			set
			{
				SetColumnValue("AO_INPUTTYPE", value);
			}
		}
		#endregion

		#region AoDescription
		/// <summary>
		/// AO_DESCRIPTION
		/// </summary>
		public string AoDescription
		{
			get
			{
				return GetColumnValue("AO_DESCRIPTION");
			}
			set
			{
				SetColumnValue("AO_DESCRIPTION", value);
			}
		}
		#endregion

		#region AoValidValueFieldFlg
		/// <summary>
		/// AO_VALIDVALUEFIELD_FLG
		/// </summary>
		public string AoValidValueFieldFlg
		{
			get
			{
				return GetColumnValue("AO_VALIDVALUEFIELD_FLG");
			}
			set
			{
				SetColumnValue("AO_VALIDVALUEFIELD_FLG", value);
			}
		}
		#endregion

		#region AoTextLength
		/// <summary>
		/// AO_TEXTLENGTH
		/// </summary>
		public int AoTextLength
		{
			get
			{
				return GetColumnValueAsInt("AO_TEXTLENGTH") ?? 0;
			}
			set
			{
				SetColumnValue("AO_TEXTLENGTH", value.ToString(CultureInfo.InvariantCulture));
			}
		}
		#endregion

		#region AoUnknownValue
		/// <summary>
		/// AO_UNKNOWNVALUE
		/// </summary>
		public string AoUnknownValue
		{
			get
			{
				return GetColumnValue("AO_UNKNOWNVALUE");
			}
			set
			{
				SetColumnValue("AO_UNKNOWNVALUE", value);
			}
		}
		#endregion

		#region AoDefaultValue
		/// <summary>
		/// AO_DEFAULTVALUE
		/// </summary>
		public string AoDefaultValue
		{
			get
			{
				return GetColumnValue("AO_DEFAULTVALUE");
			}
			set
			{
				SetColumnValue("AO_DEFAULTVALUE", value);
			}
		}
		#endregion

		#region AoSpellCheckFlag
		/// <summary>
		/// AO_SPELLCHECK_FLG
		/// </summary>
		public string AoSpellCheckFlag
		{
			get
			{
				return GetColumnValue("AO_SPELLCHECK_FLG");
			}
			set
			{
				SetColumnValue("AO_SPELLCHECK_FLG", value);
			}
		}
		#endregion

		#region AoHelpString
		/// <summary>
		/// AO_HELPSTRING
		/// </summary>
		public string AoHelpString
		{
			get
			{
				return GetColumnValue("AO_HELPSTRING");
			}
			set
			{
				SetColumnValue("AO_HELPSTRING", value);
			}
		}
		#endregion

		#region AoEnabledRuleText
		/// <summary>
		/// AO_ENABLED_RULE_TEXT
		/// </summary>
		public string AoEnabledRuleText
		{
			get
			{
				return GetColumnValue("AO_ENABLED_RULE_TEXT");
			}
			set
			{
				SetColumnValue("AO_ENABLED_RULE_TEXT", value);
			}
		}
		#endregion

		#region AoValidRuleText
		/// <summary>
		/// AO_VALID_RULE_TEXT
		/// </summary>
		public string AoValIdRuleText
		{
			get
			{
				return GetColumnValue("AO_VALID_RULE_TEXT");
			}
			set
			{
				SetColumnValue("AO_VALID_RULE_TEXT", value);
			}
		}
		#endregion

		#region AoActionText
		/// <summary>
		/// AO_ACTION_TEXT
		/// </summary>
		public string AoActionText
		{
			get
			{
				return GetColumnValue("AO_ACTION_TEXT");
			}
			set
			{
				SetColumnValue("AO_ACTION_TEXT", value);
			}
		}
		#endregion

		#region AoPersistRuleText
		/// <summary>
		/// AO_PERSIST_RULE_TEXT
		/// </summary>
		public string AoPersistRuleText
		{
			get
			{
				return GetColumnValue("AO_PERSIST_RULE_TEXT");
			}
			set
			{
				SetColumnValue("AO_PERSIST_RULE_TEXT", value);
			}
		}
		#endregion

		#region OverrideRuleText
		/// <summary>
		/// OVERRIDE_RULE_TEXT
		/// </summary>
		public string OverrideRuleText
		{
			get
			{
				return GetColumnValue("OVERRIDE_RULE_TEXT");
			}
			set
			{
				SetColumnValue("OVERRIDE_RULE_TEXT", value);
			}
		}
		#endregion

		#region ReapplyOverrideFlag
		/// <summary>
		/// REAPPLYOVERRIDE_FLG
		/// </summary>
		public string ReapplyOverrideFlag
		{
			get
			{
				return GetColumnValue("REAPPLYOVERRIDE_FLG");
			}
			set
			{
				SetColumnValue("REAPPLYOVERRIDE_FLG", value);
			}
		}
		#endregion

		/// <summary>
		/// Gets or sets the value.
		/// </summary>
		/// <value>The value.</value>
		public string AttributeValue
		{
			get { return _value; }
			set { _value = value; }
		}


		#endregion


		/// <summary>
		/// Compares to.
		/// </summary>
		public bool CompareTo(Attribute source)
		{
			for (var i = 0; i < columns.Count; ++i)
				if (!columns[i].CompareTo(source.columns[i]))
				{
					lastErrorMessage = string.Format("ATTRIBUTE ID={0} {1}:{2}={3} {4}:{5}={6}",
														  AttrInstanceId, Instance,
														  columns[i].Name, columns[i].Value,
														  source.Instance, source.columns[i].Name,
														  source.columns[i].Value);
					return false;
				}

			return true;
		}

	
	}
}

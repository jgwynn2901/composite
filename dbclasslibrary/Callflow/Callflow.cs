using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
using System.Data;
using Newtonsoft.Json;

namespace DbClassLibrary.Callflow
{
  public class Callflows : ActiveRecordSet<Callflow>
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="Callflow"/> class.
    /// </summary>
    public Callflows()
      : base("Callflow")
    { }

    public int AhsId { get; set; }
    public string LineOfBusiness { get; set; }
    public int CallflowId { get; set; }
    public bool IsCallStart { get; set; }
    public override string Query
    {
      get
      {
        return string.IsNullOrEmpty(query)
          ? string.Format("select * from callflow where {0}", BuildWhereClause())
          : query;
      }
    }

    private string BuildWhereClause()
    {
      return CallflowId > 0
        ? string.Format(" callflow_id = {0}", CallflowId)
        : string.Format("callflow_id in (select callflow_id from account_callflow A where A.accnt_hrcy_step_id = {0} and A.LOB_CD = '{1}' and call_start_flg ='{2}')",
        AhsId, LineOfBusiness, IsCallStart ? 'Y' : 'N');
    }
  }

  public class Callflow : ActiveRecord
  {
    private List<Frame> _lazyFrames;
    public bool IsCallStart = false;
    /// <summary>
    /// Initializes a new instance of the <see cref="Callflow"/> class.
    /// </summary>
    public Callflow()
      : base("Callflow")
    {
      // Begin Generated Column Definitions
      columns.Add(new Column("CALLFLOW_ID", String.Empty, "NUMBER"));
      columns.Add(new Column("NAME", String.Empty, "CHAR"));
      columns.Add(new Column("CALLTYPE_ID", String.Empty, "NUMBER"));
      columns.Add(new Column("CAT_FLG", String.Empty, "CHAR"));
      columns.Add(new Column("DESCRIPTION", String.Empty, "CHAR"));
      columns.Add(new Column("MODIFIED_DT", String.Empty, "DATE"));
      // End Generated Column Definitions
      _serialize = FramesToJson;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Callflow"/> class.
    /// </summary>
    /// <param name="reader">The reader.</param>
    public Callflow(IDataReader reader)
      : base(reader, "Callflow")
    {
      _serialize = FramesToJson;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Callflow"/> class.
    /// </summary>
    /// <param name="source">The source.</param>
    public Callflow(ActiveRecord source)
      : base(source)
    {
      _serialize = FramesToJson;
    }

    public int Id
    {
      get
      {
        return GetColumnValueAsInt("CALLFLOW_ID") ?? 0;
      }
      set
      {
        SetColumnValue("CALLFLOW_ID", value.ToString(CultureInfo.InvariantCulture));
      }
    }

    public string CallflowName
    {
      get
      {
        return GetColumnValue("NAME");
      }
      set
      {
        SetColumnValue("NAME", value);
      }
    }

    public int CallTypeId
    {
      get
      {
        return GetColumnValueAsInt("CALLTYPE_ID") ?? 0;
      }
      set
      {
        SetColumnValue("CALLTYPE_ID", value.ToString(CultureInfo.InvariantCulture));
      }
    }

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

    public DateTime ModifiedDate
    {
      get
      {
        return GetColumnValueAsDateTime("ACTIVE_START_DT") ?? DateTime.MinValue;
      }
    }

    public IEnumerable<Frame> Frames
    {
      get
      {
        if (_lazyFrames == null)
        {
          _lazyFrames = GetFrames();
        }
        return _lazyFrames;
      }
    }

    private List<Frame> GetFrames()
    {
      var frames = new FrameSet 
      { 
        Instance = Instance, 
        CallflowId = Id, 
        CallStartFlag = IsCallStart ? "Y" : "N"
      }.Results().ToList();
      return frames;
    }


    private void FramesToJson(JsonWriter jsonWriter)
    {
      jsonWriter.WritePropertyName("Frames");
      jsonWriter.WriteStartArray();
      foreach (var frame in Frames)
      {
        jsonWriter.WriteStartObject();
        frame.ToJsonArray(jsonWriter);
        jsonWriter.WriteEndObject();
      }
      jsonWriter.WriteEndArray();
    }
  }
}

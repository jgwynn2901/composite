using System.Data.Linq.Mapping;
using System.Diagnostics;


namespace DbClassLibrary.FirstNotice
{
    [Table(Name = "FNSOWNER.PERF_DATA")]
    public partial class PerfData
    {

        private long _perfDataID;

        private long _callID;

        private long _userID;

        private string _server;

        private string _component;

        private System.DateTime _startTime;

        private System.DateTime _endTime;

        private string _method;

        private string _frameName;

        #region Extensibility Method Declarations
        partial void OnCreated();

        partial void OnPerfDataIdChanged();

        partial void OnPerfDataIdChanging(long value);

        partial void OnCallIdChanged();

        partial void OnCallIdChanging(long value);

        partial void OnUserIdChanged();

        partial void OnUserIdChanging(long value);

        partial void OnServerChanged();

        partial void OnServerChanging(string value);

        partial void OnComponentChanged();

        partial void OnComponentChanging(string value);

        partial void OnMethodChanged();

        partial void OnMethodChanging(string value);

        partial void OnStartTimeChanged();

        partial void OnStartTimeChanging(System.DateTime value);

        partial void OnEndTimeChanged();

        partial void OnEndTimeChanging(System.DateTime value);

        partial void OnFrameNameChanged();

        partial void OnFrameNameChanging(string value);
        #endregion


        public PerfData()
        {
            this.OnCreated();
        }

        [Column(Storage = "_perfDataID", Name = "PERF_DATA_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public long PerfDataId
        {
            get
            {
                return this._perfDataID;
            }
            set
            {
                if ((_perfDataID != value))
                {
                    this.OnPerfDataIdChanging(value);
                    this._perfDataID = value;
                    this.OnPerfDataIdChanged();
                }
            }
        }

        [Column(Storage = "_callID", Name = "CALL_ID", DbType = "NUMBER", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public long CallId
        {
            get
            {
                return this._callID;
            }
            set
            {
                if ((_callID != value))
                {
                    this.OnCallIdChanging(value);
                    this._callID = value;
                    this.OnCallIdChanged();
                }
            }
        }

        [Column(Storage = "_userID", Name = "USER_ID", DbType = "NUMBER", AutoSync = AutoSync.Never)]
        [DebuggerNonUserCode()]
        public long UserId
        {
            get
            {
                return this._userID;
            }
            set
            {
                if ((_userID != value))
                {
                    this.OnUserIdChanging(value);
                    this._userID = value;
                    this.OnUserIdChanged();
                }
            }
        }

        [Column(Storage = "_server", Name = "SERVER", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
        [DebuggerNonUserCode()]
        public string Server
        {
            get
            {
                return this._server;
            }
            set
            {
                if (((_server == value)
                            == false))
                {
                    this.OnServerChanging(value);
                    this._server = value;
                    this.OnServerChanged();
                }
            }
        }

        [Column(Storage = "_component", Name = "COMPONENT", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
        [DebuggerNonUserCode()]
        public string Component
        {
            get
            {
                return this._component;
            }
            set
            {
                if ((_component != value))
                {
                    this.OnComponentChanging(value);
                    this._component = value;
                    this.OnComponentChanged();
                }
            }
        }

        [Column(Storage = "_method", Name = "METHOD", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
        [DebuggerNonUserCode()]
        public string Method
        {
            get
            {
                return this._method;
            }
            set
            {
                if (((_method == value)
                            == false))
                {
                    this.OnMethodChanging(value);
                    this._method = value;
                    this.OnMethodChanged();
                }
            }
        }

        [Column(Storage = "_startTime", Name = "START_TIME", DbType = "DATE", AutoSync = AutoSync.Never)]
        [DebuggerNonUserCode()]
        public System.DateTime StartTime
        {
            get
            {
                return this._startTime;
            }
            set
            {
                if ((_startTime != value))
                {
                    this.OnStartTimeChanging(value);
                    this._startTime = value;
                    this.OnStartTimeChanged();
                }
            }
        }

        [Column(Storage = "_endTime", Name = "END_TIME", DbType = "DATE", AutoSync = AutoSync.Never)]
        [DebuggerNonUserCode()]
        public System.DateTime EndTime
        {
            get
            {
                return this._endTime;
            }
            set
            {
                if ((_endTime != value))
                {
                    this.OnEndTimeChanging(value);
                    this._endTime = value;
                    this.OnEndTimeChanged();
                }
            }
        }

        [Column(Storage = "_frameName", Name = "FRAME_NAME", DbType = "VARCHAR2", AutoSync = AutoSync.Never)]
        [DebuggerNonUserCode()]
        public string FrameName
        {
            get
            {
                return this._frameName;
            }
            set
            {
                if ((_frameName != value))
                {
                    this.OnFrameNameChanging(value);
                    this._frameName = value;
                    this.OnFrameNameChanged();
                }
            }
        }
    }
}

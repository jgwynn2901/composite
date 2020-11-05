using System.Runtime.InteropServices;
using System.Data;

namespace DbClassLibrary
{
    [ComVisible(false)]
    public class EscalationOutcomeStepAdd : DbBaseClass
    {
        public EscalationOutcomeStepAdd() : this(string.Empty) { }
        public EscalationOutcomeStepAdd(string instance)
            : base(instance)
		{
            _name = "DBCLASSLIBRARY.AddEscalationOutcomeStep";

			_parameterNames = new[] {
						     "p_EscalationOutcomeId",
						     "p_UserId",
						     "p_Name",
						     "P_Title",
						     "p_PhoneNumber",
						     "p_Description",
						     "p_Complete",
						     "p_result" 
            };
            ///////////////////////////////////////////////////
            // p_EscalationOutcomeId
            ///////////////////////////////////////////////////
            AddParm(ParameterDirection.Input,
                _parameterNames[0], "", DbType.Int32);
            ///////////////////////////////////////////////////
            // p_UserId
            ///////////////////////////////////////////////////
            AddParm(ParameterDirection.Input,
                _parameterNames[1], "", DbType.Int32);
            ///////////////////////////////////////////////////
            // p_Name
            ///////////////////////////////////////////////////
            AddParm(ParameterDirection.Input,
                _parameterNames[2], "", DbType.AnsiString);
            ///////////////////////////////////////////////////
            // P_Title
            ///////////////////////////////////////////////////
            AddParm(ParameterDirection.Input,
                _parameterNames[3], "", DbType.AnsiString);
            ///////////////////////////////////////////////////
            // p_PhoneNumber
            ///////////////////////////////////////////////////
            AddParm(ParameterDirection.Input,
                _parameterNames[4], "", DbType.AnsiString);
            ///////////////////////////////////////////////////
            // p_Description
            ///////////////////////////////////////////////////
            AddParm(ParameterDirection.Input,
                _parameterNames[5], "", DbType.AnsiString);
            ///////////////////////////////////////////////////
            // p_Complete
            ///////////////////////////////////////////////////
            AddParm(ParameterDirection.Input,
                _parameterNames[6], "", DbType.AnsiString);
            ///////////////////////////////////////////////////
            // p_result
            ///////////////////////////////////////////////////
            AddParm(ParameterDirection.Output,
                _parameterNames[7], "", DbType.Int32);
		}

        public string EscalationOutcomeId
        {
            get
            {
                return GetValue(_parameterNames[0]);
            }
            set
            {
                SetValue(_parameterNames[0], value);
            }
        }

        public string UserId
        {
            get
            {
                return GetValue(_parameterNames[1]);
            }
            set
            {
                SetValue(_parameterNames[1], value);
            }
        }
        public string EscalationOutcomeName
        {
            get
            {
                return GetValue(_parameterNames[2]);
            }
            set
            {
                SetValue(_parameterNames[2], value);
            }
        }
        public string Title
        {
            get
            {
                return GetValue(_parameterNames[3]);
            }
            set
            {
                SetValue(_parameterNames[3], value);
            }
        }
        public string PhoneNumber
        {
            get
            {
                return GetValue(_parameterNames[4]);
            }
            set
            {
                SetValue(_parameterNames[4], value);
            }
        }
        public string Description
        {
            get
            {
                return GetValue(_parameterNames[5]);
            }
            set
            {
                SetValue(_parameterNames[5], value);
            }
        }
        public string Complete
        {
            get
            {
                return GetValue(_parameterNames[6]);
            }
            set
            {
                SetValue(_parameterNames[6], value);
            }
        }
        public string Result
        {
            get
            {
                return GetValue(_parameterNames[7]);
            }
            set
            {
                SetValue(_parameterNames[7], value);
            }
        }
    }
}

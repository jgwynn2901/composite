#region Header
/**************************************************************************
* First Notice Systems
* 95 Wells Avenue
* Newton, MA 02459
* (617) 886-2600
*
* Proprietary Source Code -- Distribution restricted
*
* Copyright (c) 2007 by First Notice Systems
**************************************************************************/
/* $Header: /SourceCode/Components/FNS2005/FnsUtility/Eval.cs 5     10/14/11 11:30a Gwynnj $ */
#endregion
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Microsoft.CSharp;

namespace FnsUtility
{
	/// <summary>
	/// Executes blocks of CSharp (or Vb.Net to-do) code dynamically
	/// </summary>
	public class Eval
	{
		private Type _returnType;
		private string _name;
		private string _expression;
		private string _parameter;
		private object _compiled;
		private string _lastError;

		/// <summary>
		/// Initializes a new instance of the <see cref="Eval"/> class.
		/// </summary>
		public Eval()
		{
			_returnType = typeof(string);
			_name = "_EvalString";
			_expression = string.Empty;
			_parameter = string.Empty;
			_compiled = null;
			_lastError = string.Empty;

		}

		/// <summary>
		/// Gets or sets the type of the return.
		/// </summary>
		/// <value>The type of the return.</value>
		public Type ReturnType
		{
			get { return _returnType; }
			set { _returnType = value; }
		}
		/// <summary>
		/// Gets or sets the name.
		/// </summary>
		/// <value>The name.</value>
		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}
		/// <summary>
		/// Gets or sets the expression.
		/// </summary>
		/// <value>The expression.</value>
		public string Expression
		{
			get { return _expression; }
			set { _expression = value; }
		}
		/// <summary>
		/// Gets or sets the parameter.
		/// </summary>
		/// <value>The parameter.</value>
		public string Parameter
		{
			get { return _parameter; }
			set { _parameter = value; }
		}
		/// <summary>
		/// Gets the last error.
		/// </summary>
		/// <value>The last error.</value>
		public string LastError
		{
			get { return _lastError; }
		}
		/// <summary>
		/// Constructs the evaluator.
		/// </summary>
		private void ConstructEvaluator()
		{
            var provider = new CSharpCodeProvider(new Dictionary<string,string> { { "CompilerVersion", "v3.5" } });
			var cp = new CompilerParameters();
            cp.ReferencedAssemblies.AddRange(GetReferencedAssemblies());
            cp.GenerateExecutable = false;
			cp.GenerateInMemory = true;
 
            var code = new StringBuilder();
			code.AppendLine("using System;");
			code.AppendLine("using System.Xml;");
			code.AppendLine("using System.Text.RegularExpressions;");
			code.AppendLine("using FnsComposite;");
			code.AppendLine("using FnsComposite.CallObjects;");
			code.AppendLine("namespace Evaluator {");
			code.AppendLine("  public class _Evaluator {");
			code.AppendLine(string.Format("\tpublic {0} {1}( string parm )",
			                              _returnType.Name,
			                              _name));
			code.AppendLine("{");
			code.AppendLine("\t\tCallObject _call = new CallObject();");
			code.AppendLine("\t\t_call.LoadFromXml(parm);");
			code.AppendLine(_expression);
			code.AppendLine("\t\treturn _call.ToXml();");
			code.AppendLine("}");
			code.AppendLine("} }");

			var cr = provider.CompileAssemblyFromSource(cp, code.ToString());
			if (cr.Errors.HasErrors)
			{
				var error = new StringBuilder();
				error.Append("Error Compiling Expression: ");
				foreach (CompilerError err in cr.Errors)
				{
					error.AppendFormat("{0}\n", err.ErrorText);
				}
				throw new Exception("Error Compiling Expression: " + error);
			}
			var compAssembly = cr.CompiledAssembly;
            _compiled = compAssembly.CreateInstance("Evaluator._Evaluator");
		}

        private static string [] GetReferencedAssemblies()
        {
            var evalType = new Eval().GetType();
            var assemblies = evalType.Assembly
                .GetReferencedAssemblies()
                .Select(a => a.FullName);

            var assemblyLocations =
                assemblies.Select(a => Assembly.ReflectionOnlyLoad(a).Location)
                .Where(a => !a.ToLower().Contains("\\fnsnet\\bin\\"))
                .ToList();

            assemblyLocations.Add(evalType.Assembly.Location);

            var results = new HashSet<string>();
            foreach (var set in assemblyLocations)
            {
                results.Add(set);
                ErrorLog.DebugLog("adding " + set, "FnsUtility.Eval");
            }

            return results.ToArray();
        }

	    /// <summary>
		/// Evaluates the specified name.
		/// </summary>
		/// <returns></returns>
		public string Execute()
		{
			var results = string.Empty;
			try
			{
				ConstructEvaluator();
				if (_compiled != null)
				{
					var mi = _compiled.GetType().GetMethod(_name);
					var parms = new Object[] {_parameter};
					results = mi.Invoke(_compiled, parms) as string;
				}
			}
			catch(Exception ex)
			{
				_lastError = (ex.InnerException != null) 
                    ? ex.InnerException.Message 
                    : ex.Message;

			    ErrorLog.LogWarning(_lastError, ToString());
			}
			return results;
		}
		/// <summary>
		/// Evaluates the call object.
		/// </summary>
		/// <param name="callXml">The call XML.</param>
		/// <param name="code">The code.</param>
		/// <returns>returns callXml generated from code</returns>
		static public string EvaluateCallObject (string callXml, string code)
		{
			var results = string.Empty;
			try
			{
				var eval = new Eval {Expression = code, Parameter = callXml};
			    results = eval.Execute();
			}
			catch(Exception ex)
			{
				ErrorLog.LogError(ex.Message, "Evaluator");
			}
			return results;
		}
	}
}

/*
 * $Log: /SourceCode/Components/FNS2005/FnsUtility/Eval.cs $
 * 
 * 5     10/14/11 11:30a Gwynnj
 * only references assemblies found in GAC
 * 
 * 4     10/12/11 3:44p Gwynnj
 * updated the Eval to 3.5 
 * 
 * 3     4/21/10 4:11p Gwynnj
 * Added warning to compilation errors.
 * 
 * 2     10/30/07 7:16p John.gwynn
 * updated app.config and version=2.0.  Added new Eval for dynamic
 * business rule evaluation OnClose current support for csharp code at
 * this time -can be expanded as needs grow...
 * 
 * 1     10/30/07 12:51p John.gwynn
 * Added GetDataDir to XmlUtility and new Eval evaluator for dynamic (c#
 * only at this time) code execution -see FnsDispatch
 */

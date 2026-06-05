using System.Collections.Generic;

namespace LogicBuilder.Forms.Parameters.Expressions
{
    public class ParameterOperatorParameters(string parameterName) : IExpressionParameter
    {
        public string ParameterName { get; set; } = parameterName;
    }
}
using System;

namespace LogicBuilder.Forms.Parameters.Expressions
{
    public class CustomMethodOperatorParameters(Type declaringType, string methodName, string[] parameterTypeNames, IExpressionParameter[] args) : IExpressionParameter
    {
        public Type DeclaringType { get; set; } = declaringType;
        public string MethodName { get; set; } = methodName;
        public string[] ParameterTypeNames { get; set; } = parameterTypeNames;
        public IExpressionParameter[] Args { get; set; } = args;
    }
}
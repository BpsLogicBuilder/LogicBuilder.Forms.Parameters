using System;

namespace LogicBuilder.Forms.Parameters.Expressions
{
    public class ConstantOperatorParameters(object constantValue, Type? type = null) : IExpressionParameter
    {
        public Type? Type { get; set; } = type;
        public object ConstantValue { get; set; } = constantValue;
    }
}
using System;

namespace LogicBuilder.Forms.Parameters.Expressions
{
    public class ConvertToEnumOperatorParameters(object constantValue, Type type) : IExpressionParameter
    {
        public Type Type { get; set; } = type;
        public object ConstantValue { get; set; } = constantValue;
    }
}
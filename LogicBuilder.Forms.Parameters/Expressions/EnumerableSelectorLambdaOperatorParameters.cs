using System;

namespace LogicBuilder.Forms.Parameters.Expressions
{
    public class EnumerableSelectorLambdaOperatorParameters(IExpressionParameter selector, Type sourceElementType, string parameterName) : IExpressionParameter
    {
        public IExpressionParameter Selector { get; set; } = selector;
        public Type SourceElementType { get; set; } = sourceElementType;
        public string ParameterName { get; set; } = parameterName;
    }
}
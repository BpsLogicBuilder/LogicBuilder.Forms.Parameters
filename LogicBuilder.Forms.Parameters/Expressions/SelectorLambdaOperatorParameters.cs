using System.Collections.Generic;
using System;

namespace LogicBuilder.Forms.Parameters.Expressions
{
    public class SelectorLambdaOperatorParameters(IExpressionParameter selector, Type sourceElementType, string parameterName, Type? bodyType = null) : IExpressionParameter
    {
        public IExpressionParameter Selector { get; set; } = selector;
        public Type SourceElementType { get; set; } = sourceElementType;
        public Type? BodyType { get; set; } = bodyType;
        public string ParameterName { get; set; } = parameterName;
    }
}
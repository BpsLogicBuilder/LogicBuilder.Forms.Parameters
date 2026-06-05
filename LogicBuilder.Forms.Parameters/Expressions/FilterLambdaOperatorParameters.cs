using System.Collections.Generic;
using System;

namespace LogicBuilder.Forms.Parameters.Expressions
{
    public class FilterLambdaOperatorParameters(IExpressionParameter filterBody, Type sourceElementType, string parameterName) : IExpressionParameter
    {
        public IExpressionParameter FilterBody { get; set; } = filterBody;
        public Type SourceElementType { get; set; } = sourceElementType;
        public string ParameterName { get; set; } = parameterName;
    }
}
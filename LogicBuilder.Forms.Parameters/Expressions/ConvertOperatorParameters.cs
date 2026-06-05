using System;

namespace LogicBuilder.Forms.Parameters.Expressions
{
    public class ConvertOperatorParameters(IExpressionParameter sourceOperand, Type type) : IExpressionParameter
    {
        public Type Type { get; set; } = type;
        public IExpressionParameter SourceOperand { get; set; } = sourceOperand;
    }
}
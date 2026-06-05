using System;

namespace LogicBuilder.Forms.Parameters.Expressions
{
    public class CollectionCastOperatorParameters(IExpressionParameter operand, Type type) : IExpressionParameter
    {
        public IExpressionParameter Operand { get; set; } = operand;
        public Type Type { get; set; } = type;
    }
}
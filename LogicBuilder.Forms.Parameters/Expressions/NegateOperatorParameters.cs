namespace LogicBuilder.Forms.Parameters.Expressions
{
    public class NegateOperatorParameters(IExpressionParameter operand) : IExpressionParameter
    {
        public IExpressionParameter Operand { get; set; } = operand;
    }
}
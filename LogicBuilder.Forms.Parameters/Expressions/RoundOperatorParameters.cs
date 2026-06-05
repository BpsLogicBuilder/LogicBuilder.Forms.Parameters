namespace LogicBuilder.Forms.Parameters.Expressions
{
    public class RoundOperatorParameters(IExpressionParameter operand) : IExpressionParameter
    {
        public IExpressionParameter Operand { get; set; } = operand;
    }
}
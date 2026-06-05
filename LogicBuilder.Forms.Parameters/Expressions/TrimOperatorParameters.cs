namespace LogicBuilder.Forms.Parameters.Expressions
{
    public class TrimOperatorParameters(IExpressionParameter operand) : IExpressionParameter
    {
        public IExpressionParameter Operand { get; set; } = operand;
    }
}
namespace LogicBuilder.Forms.Parameters.Expressions
{
    public class TotalSecondsOperatorParameters(IExpressionParameter operand) : IExpressionParameter
    {
        public IExpressionParameter Operand { get; set; } = operand;
    }
}
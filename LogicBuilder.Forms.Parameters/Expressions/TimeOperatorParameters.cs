namespace LogicBuilder.Forms.Parameters.Expressions
{
    public class TimeOperatorParameters(IExpressionParameter operand) : IExpressionParameter
    {
        public IExpressionParameter Operand { get; set; } = operand;
    }
}
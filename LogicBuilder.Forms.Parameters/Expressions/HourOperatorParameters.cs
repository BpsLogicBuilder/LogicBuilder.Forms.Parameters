namespace LogicBuilder.Forms.Parameters.Expressions
{
    public class HourOperatorParameters(IExpressionParameter operand) : IExpressionParameter
    {
        public IExpressionParameter Operand { get; set; } = operand;
    }
}
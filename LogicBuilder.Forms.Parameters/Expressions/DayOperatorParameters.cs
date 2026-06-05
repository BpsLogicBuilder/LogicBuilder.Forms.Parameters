namespace LogicBuilder.Forms.Parameters.Expressions
{
    public class DayOperatorParameters(IExpressionParameter operand) : IExpressionParameter
    {
        public IExpressionParameter Operand { get; set; } = operand;
    }
}
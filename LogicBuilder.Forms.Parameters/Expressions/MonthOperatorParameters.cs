namespace LogicBuilder.Forms.Parameters.Expressions
{
    public class MonthOperatorParameters(IExpressionParameter operand) : IExpressionParameter
    {
        public IExpressionParameter Operand { get; set; } = operand;
    }
}
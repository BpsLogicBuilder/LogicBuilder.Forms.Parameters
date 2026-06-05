namespace LogicBuilder.Forms.Parameters.Expressions
{
    public class DateOperatorParameters(IExpressionParameter operand) : IExpressionParameter
    {
        public IExpressionParameter Operand { get; set; } = operand;
    }
}
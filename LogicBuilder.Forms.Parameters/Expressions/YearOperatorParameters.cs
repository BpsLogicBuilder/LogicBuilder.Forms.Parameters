namespace LogicBuilder.Forms.Parameters.Expressions
{
    public class YearOperatorParameters(IExpressionParameter operand) : IExpressionParameter
    {
        public IExpressionParameter Operand { get; set; } = operand;
    }
}
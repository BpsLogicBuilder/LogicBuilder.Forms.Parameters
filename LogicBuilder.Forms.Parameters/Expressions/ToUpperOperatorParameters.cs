namespace LogicBuilder.Forms.Parameters.Expressions
{
    public class ToUpperOperatorParameters(IExpressionParameter operand) : IExpressionParameter
    {
        public IExpressionParameter Operand { get; set; } = operand;
    }
}
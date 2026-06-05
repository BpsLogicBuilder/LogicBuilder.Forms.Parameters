namespace LogicBuilder.Forms.Parameters.Expressions
{
    public class ToLowerOperatorParameters(IExpressionParameter operand) : IExpressionParameter
    {
        public IExpressionParameter Operand { get; set; } = operand;
    }
}
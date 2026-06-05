namespace LogicBuilder.Forms.Parameters.Expressions
{
    public class NotOperatorParameters(IExpressionParameter operand) : IExpressionParameter
    {
        public IExpressionParameter Operand { get; set; } = operand;
    }
}
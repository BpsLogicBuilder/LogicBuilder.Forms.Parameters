namespace LogicBuilder.Forms.Parameters.Expressions
{
    public class CeilingOperatorParameters(IExpressionParameter operand) : IExpressionParameter
    {
        public IExpressionParameter Operand { get; set; } = operand;
    }
}
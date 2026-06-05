namespace LogicBuilder.Forms.Parameters.Expressions
{
    public class LengthOperatorParameters(IExpressionParameter operand) : IExpressionParameter
    {
        public IExpressionParameter Operand { get; set; } = operand;
    }
}
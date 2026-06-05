namespace LogicBuilder.Forms.Parameters.Expressions
{
    public class FractionalSecondsOperatorParameters(IExpressionParameter operand) : IExpressionParameter
    {
        public IExpressionParameter Operand { get; set; } = operand;
    }
}
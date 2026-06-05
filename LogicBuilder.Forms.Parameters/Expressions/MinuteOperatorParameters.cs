namespace LogicBuilder.Forms.Parameters.Expressions
{
    public class MinuteOperatorParameters(IExpressionParameter operand) : IExpressionParameter
    {
        public IExpressionParameter Operand { get; set; } = operand;
    }
}
namespace LogicBuilder.Forms.Parameters.Expressions
{
    public class FloorOperatorParameters(IExpressionParameter operand) : IExpressionParameter
    {
        public IExpressionParameter Operand { get; set; } = operand;
    }
}
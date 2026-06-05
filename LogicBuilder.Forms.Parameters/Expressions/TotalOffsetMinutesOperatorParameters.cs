namespace LogicBuilder.Forms.Parameters.Expressions
{
    public class TotalOffsetMinutesOperatorParameters(IExpressionParameter operand) : IExpressionParameter
    {
        public IExpressionParameter Operand { get; set; } = operand;
    }
}
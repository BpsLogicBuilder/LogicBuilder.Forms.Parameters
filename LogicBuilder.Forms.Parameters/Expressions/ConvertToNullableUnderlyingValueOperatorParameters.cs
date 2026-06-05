namespace LogicBuilder.Forms.Parameters.Expressions
{
    public class ConvertToNullableUnderlyingValueOperatorParameters(IExpressionParameter sourceOperand) : IExpressionParameter
    {
        public IExpressionParameter SourceOperand { get; set; } = sourceOperand;
    }
}
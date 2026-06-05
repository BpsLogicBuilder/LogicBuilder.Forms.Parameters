namespace LogicBuilder.Forms.Parameters.Expressions
{
    public class ConvertToNumericDateOperatorParameters(IExpressionParameter sourceOperand) : IExpressionParameter
    {
        public IExpressionParameter SourceOperand { get; set; } = sourceOperand;
    }
}
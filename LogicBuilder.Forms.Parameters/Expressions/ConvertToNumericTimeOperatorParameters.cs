namespace LogicBuilder.Forms.Parameters.Expressions
{
    public class ConvertToNumericTimeOperatorParameters(IExpressionParameter sourceOperand) : IExpressionParameter
    {
        public IExpressionParameter SourceOperand { get; set; } = sourceOperand;
    }
}
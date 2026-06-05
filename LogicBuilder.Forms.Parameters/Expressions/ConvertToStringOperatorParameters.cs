namespace LogicBuilder.Forms.Parameters.Expressions
{
    public class ConvertToStringOperatorParameters(IExpressionParameter sourceOperand) : IExpressionParameter
    {
        public IExpressionParameter SourceOperand { get; set; } = sourceOperand;
    }
}
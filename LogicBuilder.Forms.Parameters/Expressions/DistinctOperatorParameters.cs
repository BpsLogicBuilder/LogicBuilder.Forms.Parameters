namespace LogicBuilder.Forms.Parameters.Expressions
{
    public class DistinctOperatorParameters(IExpressionParameter sourceOperand) : IExpressionParameter
    {
        public IExpressionParameter SourceOperand { get; set; } = sourceOperand;
    }
}
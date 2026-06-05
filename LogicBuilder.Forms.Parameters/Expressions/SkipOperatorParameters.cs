namespace LogicBuilder.Forms.Parameters.Expressions
{
    public class SkipOperatorParameters(IExpressionParameter sourceOperand, int count) : IExpressionParameter
    {
        public IExpressionParameter SourceOperand { get; set; } = sourceOperand;
        public int Count { get; set; } = count;
    }
}
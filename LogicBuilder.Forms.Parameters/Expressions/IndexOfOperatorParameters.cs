namespace LogicBuilder.Forms.Parameters.Expressions
{
    public class IndexOfOperatorParameters(IExpressionParameter sourceOperand, IExpressionParameter itemToFind) : IExpressionParameter
    {
        public IExpressionParameter SourceOperand { get; set; } = sourceOperand;
        public IExpressionParameter ItemToFind { get; set; } = itemToFind;
    }
}
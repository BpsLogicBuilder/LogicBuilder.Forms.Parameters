namespace LogicBuilder.Forms.Parameters.Expressions
{
    public class AsQueryableOperatorParameters(IExpressionParameter sourceOperand) : IExpressionParameter
    {
        public IExpressionParameter SourceOperand { get; set; } = sourceOperand;
    }
}
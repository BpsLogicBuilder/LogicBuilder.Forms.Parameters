namespace LogicBuilder.Forms.Parameters.Expressions
{
    public class AsEnumerableOperatorParameters(IExpressionParameter sourceOperand) : IExpressionParameter
    {
        public IExpressionParameter SourceOperand { get; set; } = sourceOperand;
    }
}
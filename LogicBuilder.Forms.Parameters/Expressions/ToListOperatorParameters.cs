namespace LogicBuilder.Forms.Parameters.Expressions
{
    public class ToListOperatorParameters(IExpressionParameter sourceOperand) : IExpressionParameter
    {
        public IExpressionParameter SourceOperand { get; set; } = sourceOperand;
    }
}
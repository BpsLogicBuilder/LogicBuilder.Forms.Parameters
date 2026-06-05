namespace LogicBuilder.Forms.Parameters.Expressions
{
    public class ConvertCharArrayToStringOperatorParameters(IExpressionParameter sourceOperand) : IExpressionParameter
    {
        public IExpressionParameter SourceOperand { get; set; } = sourceOperand;
    }
}
namespace LogicBuilder.Forms.Parameters.Expressions
{
    public class SubstringOperatorParameters(IExpressionParameter sourceOperand, params IExpressionParameter[] indexes) : IExpressionParameter
    {
        public IExpressionParameter SourceOperand { get; set; } = sourceOperand;
        public IExpressionParameter[] Indexes { get; set; } = indexes;
    }
}
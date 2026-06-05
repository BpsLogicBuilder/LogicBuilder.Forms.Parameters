namespace LogicBuilder.Forms.Parameters.Expressions
{
    abstract public class FilterMethodOperatorParametersBase(IExpressionParameter sourceOperand, IExpressionParameter? filterBody = null, string? filterParameterName = null) : IExpressionParameter
    {
        public IExpressionParameter SourceOperand { get; set; } = sourceOperand;
        public IExpressionParameter? FilterBody { get; set; } = filterBody;
        public string? FilterParameterName { get; set; } = filterParameterName;
    }
}
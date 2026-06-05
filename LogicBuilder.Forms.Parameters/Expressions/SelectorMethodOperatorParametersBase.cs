namespace LogicBuilder.Forms.Parameters.Expressions
{
    abstract public class SelectorMethodOperatorParametersBase(IExpressionParameter sourceOperand, IExpressionParameter? selectorBody = null, string? selectorParameterName = null) : IExpressionParameter
    {
        public IExpressionParameter SourceOperand { get; set; } = sourceOperand;
        public IExpressionParameter? SelectorBody { get; set; } = selectorBody;
        public string? SelectorParameterName { get; set; } = selectorParameterName;
    }
}
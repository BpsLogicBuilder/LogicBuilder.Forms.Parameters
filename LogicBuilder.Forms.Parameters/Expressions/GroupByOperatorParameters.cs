namespace LogicBuilder.Forms.Parameters.Expressions
{
    public class GroupByOperatorParameters(IExpressionParameter sourceOperand, IExpressionParameter selectorBody, string selectorParameterName) : SelectorMethodOperatorParametersBase(sourceOperand, selectorBody, selectorParameterName)
    {
    }
}
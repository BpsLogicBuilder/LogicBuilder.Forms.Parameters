namespace LogicBuilder.Forms.Parameters.Expressions
{
    public class SelectOperatorParameters(IExpressionParameter sourceOperand, IExpressionParameter selectorBody, string selectorParameterName) : SelectorMethodOperatorParametersBase(sourceOperand, selectorBody, selectorParameterName)
    {
    }
}
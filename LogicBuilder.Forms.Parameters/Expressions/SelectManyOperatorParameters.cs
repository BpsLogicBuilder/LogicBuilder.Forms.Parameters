namespace LogicBuilder.Forms.Parameters.Expressions
{
    public class SelectManyOperatorParameters(IExpressionParameter sourceOperand, IExpressionParameter selectorBody, string selectorParameterName) : SelectorMethodOperatorParametersBase(sourceOperand, selectorBody, selectorParameterName)
    {
    }
}
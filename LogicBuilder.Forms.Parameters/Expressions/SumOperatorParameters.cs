namespace LogicBuilder.Forms.Parameters.Expressions
{
    public class SumOperatorParameters(IExpressionParameter sourceOperand, IExpressionParameter? selectorBody = null, string? selectorParameterName = null) : SelectorMethodOperatorParametersBase(sourceOperand, selectorBody, selectorParameterName)
    {
    }
}
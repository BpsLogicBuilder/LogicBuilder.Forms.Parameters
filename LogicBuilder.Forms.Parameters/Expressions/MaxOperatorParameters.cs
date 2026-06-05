namespace LogicBuilder.Forms.Parameters.Expressions
{
    public class MaxOperatorParameters(IExpressionParameter sourceOperand, IExpressionParameter? selectorBody = null, string? selectorParameterName = null) : SelectorMethodOperatorParametersBase(sourceOperand, selectorBody, selectorParameterName)
    {
    }
}
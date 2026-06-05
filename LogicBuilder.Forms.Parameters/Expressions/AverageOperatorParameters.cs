namespace LogicBuilder.Forms.Parameters.Expressions
{
    public class AverageOperatorParameters(IExpressionParameter sourceOperand, IExpressionParameter? selectorBody = null, string? selectorParameterName = null) : SelectorMethodOperatorParametersBase(sourceOperand, selectorBody, selectorParameterName)
    {
    }
}
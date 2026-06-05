namespace LogicBuilder.Forms.Parameters.Expressions
{
    public class LastOperatorParameters(IExpressionParameter sourceOperand, IExpressionParameter? filterBody = null, string? filterParameterName = null) : FilterMethodOperatorParametersBase(sourceOperand, filterBody, filterParameterName)
    {
    }
}
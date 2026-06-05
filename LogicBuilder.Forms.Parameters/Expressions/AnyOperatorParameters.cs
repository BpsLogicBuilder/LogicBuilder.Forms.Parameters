namespace LogicBuilder.Forms.Parameters.Expressions
{
    public class AnyOperatorParameters(IExpressionParameter sourceOperand, IExpressionParameter? filterBody = null, string? filterParameterName = null) : FilterMethodOperatorParametersBase(sourceOperand, filterBody, filterParameterName)
    {
    }
}
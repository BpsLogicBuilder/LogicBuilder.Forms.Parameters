namespace LogicBuilder.Forms.Parameters.Expressions
{
    public class FirstOperatorParameters(IExpressionParameter sourceOperand, IExpressionParameter? filterBody = null, string? filterParameterName = null) : FilterMethodOperatorParametersBase(sourceOperand, filterBody, filterParameterName)
    {
    }
}
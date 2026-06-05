namespace LogicBuilder.Forms.Parameters.Expressions
{
    public class SingleOrDefaultOperatorParameters(IExpressionParameter sourceOperand, IExpressionParameter? filterBody = null, string? filterParameterName = null) : FilterMethodOperatorParametersBase(sourceOperand, filterBody, filterParameterName)
    {
    }
}
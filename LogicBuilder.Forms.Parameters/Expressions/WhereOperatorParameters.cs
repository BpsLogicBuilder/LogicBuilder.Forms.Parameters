namespace LogicBuilder.Forms.Parameters.Expressions
{
    public class WhereOperatorParameters(IExpressionParameter sourceOperand, IExpressionParameter filterBody, string filterParameterName) : FilterMethodOperatorParametersBase(sourceOperand, filterBody, filterParameterName)
    {
    }
}
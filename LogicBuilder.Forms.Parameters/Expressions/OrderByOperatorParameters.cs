using LogicBuilder.Expressions.Utils.Strutures;

namespace LogicBuilder.Forms.Parameters.Expressions
{
    public class OrderByOperatorParameters(IExpressionParameter sourceOperand, IExpressionParameter selectorBody, ListSortDirection sortDirection, string selectorParameterName) : SelectorMethodOperatorParametersBase(sourceOperand, selectorBody, selectorParameterName)
    {
        public ListSortDirection SortDirection { get; set; } = sortDirection;
    }
}
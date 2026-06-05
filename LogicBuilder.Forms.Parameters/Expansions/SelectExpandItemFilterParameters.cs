using LogicBuilder.Forms.Parameters.Expressions;

namespace LogicBuilder.Forms.Parameters.Expansions
{
    public class SelectExpandItemFilterParameters(FilterLambdaOperatorParameters filterLambdaOperator)
    {
        public FilterLambdaOperatorParameters FilterLambdaOperator { get; set; } = filterLambdaOperator;
    }
}

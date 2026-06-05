namespace LogicBuilder.Forms.Parameters.Expressions
{
    public class InOperatorParameters(IExpressionParameter itemToFind, IExpressionParameter listToSearch) : IExpressionParameter
    {
        public IExpressionParameter ItemToFind { get; set; } = itemToFind;
        public IExpressionParameter ListToSearch { get; set; } = listToSearch;
    }
}
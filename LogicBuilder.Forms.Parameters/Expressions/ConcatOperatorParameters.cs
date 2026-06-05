namespace LogicBuilder.Forms.Parameters.Expressions
{
    public class ConcatOperatorParameters(IExpressionParameter left, IExpressionParameter right) : IExpressionParameter
    {
        public IExpressionParameter Left { get; set; } = left;
        public IExpressionParameter Right { get; set; } = right;
    }
}
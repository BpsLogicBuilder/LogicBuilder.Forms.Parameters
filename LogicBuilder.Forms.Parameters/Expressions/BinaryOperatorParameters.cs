namespace LogicBuilder.Forms.Parameters.Expressions
{
    abstract public class BinaryOperatorParameters(IExpressionParameter left, IExpressionParameter right) : IExpressionParameter
    {
        public IExpressionParameter Left { get; set; } = left;
        public IExpressionParameter Right { get; set; } = right;
    }
}
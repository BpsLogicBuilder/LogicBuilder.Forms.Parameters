using LogicBuilder.Forms.Parameters.Expressions;

namespace LogicBuilder.Forms.Parameters.Tests.Expressions
{
    public class TrimOperatorParametersTest
    {
        [Fact]
        public void Constructor_SetsOperand()
        {
            // Arrange
            var expectedOperand = new ConstantOperatorParameters("  hello  ");

            // Act
            var parameters = new TrimOperatorParameters(expectedOperand);

            // Assert
            Assert.NotNull(parameters);
            Assert.Same(expectedOperand, parameters.Operand);
        }
    }
}

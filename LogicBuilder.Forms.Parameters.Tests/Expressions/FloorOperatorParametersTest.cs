using LogicBuilder.Forms.Parameters.Expressions;

namespace LogicBuilder.Forms.Parameters.Tests.Expressions
{
    public class FloorOperatorParametersTest
    {
        [Fact]
        public void Constructor_SetsOperand()
        {
            // Arrange
            var expectedOperand = new ConstantOperatorParameters(3.7);

            // Act
            var parameters = new FloorOperatorParameters(expectedOperand);

            // Assert
            Assert.NotNull(parameters);
            Assert.Same(expectedOperand, parameters.Operand);
        }
    }
}

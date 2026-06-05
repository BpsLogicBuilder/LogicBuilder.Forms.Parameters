using LogicBuilder.Forms.Parameters.Expressions;

namespace LogicBuilder.Forms.Parameters.Tests.Expressions
{
    public class AsQueryableOperatorParametersTest
    {
        [Fact]
        public void Constructor_SetsSourceOperand()
        {
            // Arrange
            var expectedSourceOperand = new ParameterOperatorParameters("items");

            // Act
            var parameters = new AsQueryableOperatorParameters(expectedSourceOperand);

            // Assert
            Assert.NotNull(parameters);
            Assert.Same(expectedSourceOperand, parameters.SourceOperand);
        }
    }
}

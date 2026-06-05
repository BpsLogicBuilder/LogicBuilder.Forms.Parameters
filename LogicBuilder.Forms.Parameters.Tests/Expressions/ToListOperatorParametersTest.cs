using LogicBuilder.Forms.Parameters.Expressions;

namespace LogicBuilder.Forms.Parameters.Tests.Expressions
{
    public class ToListOperatorParametersTest
    {
        [Fact]
        public void Constructor_SetsSourceOperand()
        {
            // Arrange
            var expectedSourceOperand = new ParameterOperatorParameters("items");

            // Act
            var parameters = new ToListOperatorParameters(expectedSourceOperand);

            // Assert
            Assert.NotNull(parameters);
            Assert.Same(expectedSourceOperand, parameters.SourceOperand);
        }
    }
}

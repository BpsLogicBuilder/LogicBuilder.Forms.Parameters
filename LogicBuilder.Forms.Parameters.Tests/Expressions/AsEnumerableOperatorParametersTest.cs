using LogicBuilder.Forms.Parameters.Expressions;

namespace LogicBuilder.Forms.Parameters.Tests.Expressions
{
    public class AsEnumerableOperatorParametersTest
    {
        [Fact]
        public void Constructor_SetsSourceOperand()
        {
            // Arrange
            var expectedSourceOperand = new ParameterOperatorParameters("items");

            // Act
            var parameters = new AsEnumerableOperatorParameters(expectedSourceOperand);

            // Assert
            Assert.NotNull(parameters);
            Assert.Same(expectedSourceOperand, parameters.SourceOperand);
        }

        [Fact]
        public void SourceOperand_CanBeSetAndRetrieved()
        {
            // Arrange
            var initialSourceOperand = new ParameterOperatorParameters("items");
            var parameters = new AsEnumerableOperatorParameters(initialSourceOperand);
            var newSourceOperand = new ParameterOperatorParameters("newItems");

            // Act
            parameters.SourceOperand = newSourceOperand;

            // Assert
            Assert.Same(newSourceOperand, parameters.SourceOperand);
        }
    }
}

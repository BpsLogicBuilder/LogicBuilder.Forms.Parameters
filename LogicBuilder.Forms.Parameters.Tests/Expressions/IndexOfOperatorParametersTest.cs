using LogicBuilder.Forms.Parameters.Expressions;

namespace LogicBuilder.Forms.Parameters.Tests.Expressions
{
    public class IndexOfOperatorParametersTest
    {
        [Fact]
        public void Constructor_SetsAllProperties()
        {
            // Arrange
            var expectedSourceOperand = new ConstantOperatorParameters("Hello World");
            var expectedItemToFind = new ConstantOperatorParameters("World");

            // Act
            var parameters = new IndexOfOperatorParameters(expectedSourceOperand, expectedItemToFind);

            // Assert
            Assert.NotNull(parameters);
            Assert.Same(expectedSourceOperand, parameters.SourceOperand);
            Assert.Same(expectedItemToFind, parameters.ItemToFind);
        }
    }
}

using LogicBuilder.Forms.Parameters.Expressions;

namespace LogicBuilder.Forms.Parameters.Tests.Expressions
{
    public class EndsWithOperatorParametersTest
    {
        [Fact]
        public void Constructor_SetsAllProperties()
        {
            // Arrange
            var expectedLeft = new ConstantOperatorParameters("Hello World");
            var expectedRight = new ConstantOperatorParameters("World");

            // Act
            var parameters = new EndsWithOperatorParameters(expectedLeft, expectedRight);

            // Assert
            Assert.NotNull(parameters);
            Assert.Same(expectedLeft, parameters.Left);
            Assert.Same(expectedRight, parameters.Right);
        }
    }
}

using LogicBuilder.Forms.Parameters.Expressions;

namespace LogicBuilder.Forms.Parameters.Tests.Expressions
{
    public class DivideBinaryOperatorParametersTest
    {
        [Fact]
        public void Constructor_SetsAllProperties()
        {
            // Arrange
            var expectedLeft = new ConstantOperatorParameters(10);
            var expectedRight = new ConstantOperatorParameters(2);

            // Act
            var parameters = new DivideBinaryOperatorParameters(expectedLeft, expectedRight);

            // Assert
            Assert.NotNull(parameters);
            Assert.Same(expectedLeft, parameters.Left);
            Assert.Same(expectedRight, parameters.Right);
        }
    }
}

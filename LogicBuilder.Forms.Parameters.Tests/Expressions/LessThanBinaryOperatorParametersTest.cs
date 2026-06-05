using LogicBuilder.Forms.Parameters.Expressions;

namespace LogicBuilder.Forms.Parameters.Tests.Expressions
{
    public class LessThanBinaryOperatorParametersTest
    {
        [Fact]
        public void Constructor_SetsAllProperties()
        {
            // Arrange
            var expectedLeft = new ConstantOperatorParameters(5);
            var expectedRight = new ConstantOperatorParameters(10);

            // Act
            var parameters = new LessThanBinaryOperatorParameters(expectedLeft, expectedRight);

            // Assert
            Assert.NotNull(parameters);
            Assert.Same(expectedLeft, parameters.Left);
            Assert.Same(expectedRight, parameters.Right);
        }
    }
}

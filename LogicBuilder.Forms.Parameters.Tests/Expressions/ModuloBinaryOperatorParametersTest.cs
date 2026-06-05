using LogicBuilder.Forms.Parameters.Expressions;

namespace LogicBuilder.Forms.Parameters.Tests.Expressions
{
    public class ModuloBinaryOperatorParametersTest
    {
        [Fact]
        public void Constructor_SetsAllProperties()
        {
            // Arrange
            var expectedLeft = new ConstantOperatorParameters(10);
            var expectedRight = new ConstantOperatorParameters(3);

            // Act
            var parameters = new ModuloBinaryOperatorParameters(expectedLeft, expectedRight);

            // Assert
            Assert.NotNull(parameters);
            Assert.Same(expectedLeft, parameters.Left);
            Assert.Same(expectedRight, parameters.Right);
        }
    }
}

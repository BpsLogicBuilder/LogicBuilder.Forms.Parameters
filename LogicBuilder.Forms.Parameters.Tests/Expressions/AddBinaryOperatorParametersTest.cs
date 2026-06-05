using LogicBuilder.Forms.Parameters.Expressions;

namespace LogicBuilder.Forms.Parameters.Tests.Expressions
{
    public class AddBinaryOperatorParametersTest
    {
        [Fact]
        public void Constructor_SetsAllProperties()
        {
            // Arrange
            var expectedLeft = new ConstantOperatorParameters(5);
            var expectedRight = new ConstantOperatorParameters(10);

            // Act
            var parameters = new AddBinaryOperatorParameters(expectedLeft, expectedRight);

            // Assert
            Assert.NotNull(parameters);
            Assert.Same(expectedLeft, parameters.Left);
            Assert.Same(expectedRight, parameters.Right);
        }

        [Fact]
        public void Left_CanBeSetAndRetrieved()
        {
            // Arrange
            var initialLeft = new ConstantOperatorParameters(5);
            var parameters = new AddBinaryOperatorParameters(initialLeft, new ConstantOperatorParameters(10));
            var newLeft = new ConstantOperatorParameters(15);

            // Act
            parameters.Left = newLeft;

            // Assert
            Assert.Same(newLeft, parameters.Left);
        }

        [Fact]
        public void Right_CanBeSetAndRetrieved()
        {
            // Arrange
            var initialRight = new ConstantOperatorParameters(10);
            var parameters = new AddBinaryOperatorParameters(new ConstantOperatorParameters(5), initialRight);
            var newRight = new ConstantOperatorParameters(20);

            // Act
            parameters.Right = newRight;

            // Assert
            Assert.Same(newRight, parameters.Right);
        }
    }
}

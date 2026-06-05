using LogicBuilder.Forms.Parameters.Expressions;

namespace LogicBuilder.Forms.Parameters.Tests.Expressions
{
    public class ConstantOperatorParametersTest
    {
        [Fact]
        public void Constructor_WithValueOnly_SetsConstantValue()
        {
            // Arrange
            object expectedValue = 42;

            // Act
            var parameters = new ConstantOperatorParameters(expectedValue);

            // Assert
            Assert.NotNull(parameters);
            Assert.Same(expectedValue, parameters.ConstantValue);
            Assert.Null(parameters.Type);
        }

        [Fact]
        public void Constructor_WithValueAndType_SetsAllProperties()
        {
            // Arrange
            object expectedValue = 42;
            var expectedType = typeof(int);

            // Act
            var parameters = new ConstantOperatorParameters(expectedValue, expectedType);

            // Assert
            Assert.NotNull(parameters);
            Assert.Same(expectedValue, parameters.ConstantValue);
            Assert.Equal(expectedType, parameters.Type);
        }

        [Fact]
        public void ConstantValue_CanBeSetAndRetrieved()
        {
            // Arrange
            var parameters = new ConstantOperatorParameters(42);
            object newValue = "test";

            // Act
            parameters.ConstantValue = newValue;

            // Assert
            Assert.Same(newValue, parameters.ConstantValue);
        }

        [Fact]
        public void Type_CanBeSetAndRetrieved()
        {
            // Arrange
            var parameters = new ConstantOperatorParameters(42);
            var newType = typeof(string);

            // Act
            parameters.Type = newType;

            // Assert
            Assert.Equal(newType, parameters.Type);
        }
    }
}

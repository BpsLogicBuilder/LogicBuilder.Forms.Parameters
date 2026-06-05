using LogicBuilder.Forms.Parameters.Expressions;
using System;

namespace LogicBuilder.Forms.Parameters.Tests.Expressions
{
    public class ConvertOperatorParametersTest
    {
        [Fact]
        public void Constructor_SetsAllProperties()
        {
            // Arrange
            var expectedSourceOperand = new ConstantOperatorParameters(42);
            var expectedType = typeof(long);

            // Act
            var parameters = new ConvertOperatorParameters(expectedSourceOperand, expectedType);

            // Assert
            Assert.NotNull(parameters);
            Assert.Same(expectedSourceOperand, parameters.SourceOperand);
            Assert.Equal(expectedType, parameters.Type);
        }
    }
}

using LogicBuilder.Forms.Parameters.Expressions;
using System;

namespace LogicBuilder.Forms.Parameters.Tests.Expressions
{
    public class CollectionCastOperatorParametersTest
    {
        [Fact]
        public void Constructor_SetsAllProperties()
        {
            // Arrange
            var expectedOperand = new ParameterOperatorParameters("items");
            var expectedType = typeof(string);

            // Act
            var parameters = new CollectionCastOperatorParameters(expectedOperand, expectedType);

            // Assert
            Assert.NotNull(parameters);
            Assert.Same(expectedOperand, parameters.Operand);
            Assert.Equal(expectedType, parameters.Type);
        }
    }
}

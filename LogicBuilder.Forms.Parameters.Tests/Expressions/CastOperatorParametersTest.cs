using LogicBuilder.Forms.Parameters.Expressions;
using System;

namespace LogicBuilder.Forms.Parameters.Tests.Expressions
{
    public class CastOperatorParametersTest
    {
        [Fact]
        public void Constructor_SetsAllProperties()
        {
            // Arrange
            var expectedOperand = new ParameterOperatorParameters("item");
            var expectedType = typeof(string);

            // Act
            var parameters = new CastOperatorParameters(expectedOperand, expectedType);

            // Assert
            Assert.NotNull(parameters);
            Assert.Same(expectedOperand, parameters.Operand);
            Assert.Equal(expectedType, parameters.Type);
        }

        [Fact]
        public void Operand_CanBeSetAndRetrieved()
        {
            // Arrange
            var initialOperand = new ParameterOperatorParameters("item");
            var parameters = new CastOperatorParameters(initialOperand, typeof(string));
            var newOperand = new ParameterOperatorParameters("newItem");

            // Act
            parameters.Operand = newOperand;

            // Assert
            Assert.Same(newOperand, parameters.Operand);
        }

        [Fact]
        public void Type_CanBeSetAndRetrieved()
        {
            // Arrange
            var parameters = new CastOperatorParameters(new ParameterOperatorParameters("item"), typeof(string));
            var newType = typeof(int);

            // Act
            parameters.Type = newType;

            // Assert
            Assert.Equal(newType, parameters.Type);
        }
    }
}

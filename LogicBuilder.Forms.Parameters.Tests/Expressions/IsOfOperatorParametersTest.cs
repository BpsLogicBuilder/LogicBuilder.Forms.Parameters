using LogicBuilder.Forms.Parameters.Expressions;

namespace LogicBuilder.Forms.Parameters.Tests.Expressions
{
    public class IsOfOperatorParametersTest
    {
        [Fact]
        public void Constructor_SetsAllProperties()
        {
            // Arrange
            var expectedOperand = new ParameterOperatorParameters("item");
            var expectedType = typeof(string);

            // Act
            var parameters = new IsOfOperatorParameters(expectedOperand, expectedType);

            // Assert
            Assert.NotNull(parameters);
            Assert.Same(expectedOperand, parameters.Operand);
            Assert.Equal(expectedType, parameters.Type);
        }
    }
}

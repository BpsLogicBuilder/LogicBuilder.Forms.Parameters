using LogicBuilder.Forms.Parameters.Expressions;

namespace LogicBuilder.Forms.Parameters.Tests.Expressions
{
    public class SecondOperatorParametersTest
    {
        [Fact]
        public void Constructor_SetsOperand()
        {
            // Arrange
            var expectedOperand = new ParameterOperatorParameters("dateTimeValue");

            // Act
            var parameters = new SecondOperatorParameters(expectedOperand);

            // Assert
            Assert.NotNull(parameters);
            Assert.Same(expectedOperand, parameters.Operand);
        }
    }
}

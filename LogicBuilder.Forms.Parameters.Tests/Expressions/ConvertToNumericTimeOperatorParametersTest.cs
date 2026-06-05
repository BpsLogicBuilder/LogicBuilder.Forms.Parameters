using LogicBuilder.Forms.Parameters.Expressions;

namespace LogicBuilder.Forms.Parameters.Tests.Expressions
{
    public class ConvertToNumericTimeOperatorParametersTest
    {
        [Fact]
        public void Constructor_SetsOperand()
        {
            // Arrange
            var expectedOperand = new ParameterOperatorParameters("timeValue");

            // Act
            var parameters = new ConvertToNumericTimeOperatorParameters(expectedOperand);

            // Assert
            Assert.NotNull(parameters);
            Assert.Same(expectedOperand, parameters.SourceOperand);
        }
    }
}

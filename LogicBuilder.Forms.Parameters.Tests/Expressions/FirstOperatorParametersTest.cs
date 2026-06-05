using LogicBuilder.Forms.Parameters.Expressions;

namespace LogicBuilder.Forms.Parameters.Tests.Expressions
{
    public class FirstOperatorParametersTest
    {
        [Fact]
        public void Constructor_SetsAllProperties()
        {
            // Arrange
            var expectedSourceOperand = new ParameterOperatorParameters("items");
            var expectedFilterBody = new ConstantOperatorParameters(true);
            string expectedFilterParameterName = "x";

            // Act
            var parameters = new FirstOperatorParameters(
                expectedSourceOperand,
                expectedFilterBody,
                expectedFilterParameterName);

            // Assert
            Assert.NotNull(parameters);
            Assert.Same(expectedSourceOperand, parameters.SourceOperand);
            Assert.Same(expectedFilterBody, parameters.FilterBody);
            Assert.Equal(expectedFilterParameterName, parameters.FilterParameterName);
        }
    }
}

using LogicBuilder.Forms.Parameters.Expressions;

namespace LogicBuilder.Forms.Parameters.Tests.Expressions
{
    public class WhereOperatorParametersTest
    {
        [Fact]
        public void Constructor_SetsAllProperties()
        {
            // Arrange
            var expectedSourceOperand = new ParameterOperatorParameters("items");
            var expectedFilterBody = new EqualsBinaryOperatorParameters(
                new MemberSelectorOperatorParameters("Id", new ParameterOperatorParameters("x")),
                new ConstantOperatorParameters(1));
            string expectedFilterParameterName = "x";

            // Act
            var parameters = new WhereOperatorParameters(
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

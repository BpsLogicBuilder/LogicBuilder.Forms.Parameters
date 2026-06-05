using LogicBuilder.Forms.Parameters.Expressions;

namespace LogicBuilder.Forms.Parameters.Tests.Expressions
{
    public class GroupByOperatorParametersTest
    {
        [Fact]
        public void Constructor_SetsAllProperties()
        {
            // Arrange
            var expectedSourceOperand = new ParameterOperatorParameters("items");
            var expectedSelectorBody = new MemberSelectorOperatorParameters("Category", new ParameterOperatorParameters("x"));
            string expectedSelectorParameterName = "x";

            // Act
            var parameters = new GroupByOperatorParameters(
                expectedSourceOperand,
                expectedSelectorBody,
                expectedSelectorParameterName);

            // Assert
            Assert.NotNull(parameters);
            Assert.Same(expectedSourceOperand, parameters.SourceOperand);
            Assert.Same(expectedSelectorBody, parameters.SelectorBody);
            Assert.Equal(expectedSelectorParameterName, parameters.SelectorParameterName);
        }
    }
}

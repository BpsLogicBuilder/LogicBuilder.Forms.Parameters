using LogicBuilder.Expressions.Utils.Strutures;
using LogicBuilder.Forms.Parameters.Expressions;

namespace LogicBuilder.Forms.Parameters.Tests.Expressions
{
    public class OrderByOperatorParametersTest
    {
        [Fact]
        public void Constructor_SetsAllProperties()
        {
            // Arrange
            var expectedSourceOperand = new ParameterOperatorParameters("items");
            var expectedSelectorBody = new MemberSelectorOperatorParameters("Name", new ParameterOperatorParameters("x"));
            var expectedSortDirection = ListSortDirection.Ascending;
            string expectedSelectorParameterName = "x";

            // Act
            var parameters = new OrderByOperatorParameters(
                expectedSourceOperand,
                expectedSelectorBody,
                expectedSortDirection,
                expectedSelectorParameterName);

            // Assert
            Assert.NotNull(parameters);
            Assert.Same(expectedSourceOperand, parameters.SourceOperand);
            Assert.Same(expectedSelectorBody, parameters.SelectorBody);
            Assert.Equal(expectedSortDirection, parameters.SortDirection);
            Assert.Equal(expectedSelectorParameterName, parameters.SelectorParameterName);
        }
    }
}

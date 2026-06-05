using LogicBuilder.Forms.Parameters.Expressions;

namespace LogicBuilder.Forms.Parameters.Tests.Expressions
{
    public class AllOperatorParametersTest
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
            var parameters = new AllOperatorParameters(
                expectedSourceOperand,
                expectedFilterBody,
                expectedFilterParameterName);

            // Assert
            Assert.NotNull(parameters);
            Assert.Same(expectedSourceOperand, parameters.SourceOperand);
            Assert.Same(expectedFilterBody, parameters.FilterBody);
            Assert.Equal(expectedFilterParameterName, parameters.FilterParameterName);
        }

        [Fact]
        public void SourceOperand_CanBeSetAndRetrieved()
        {
            // Arrange
            var initialSourceOperand = new ParameterOperatorParameters("items");
            var parameters = new AllOperatorParameters(
                initialSourceOperand,
                new ConstantOperatorParameters(true),
                "x");
            var newSourceOperand = new ParameterOperatorParameters("newItems");

            // Act
            parameters.SourceOperand = newSourceOperand;

            // Assert
            Assert.Same(newSourceOperand, parameters.SourceOperand);
        }

        [Fact]
        public void FilterBody_CanBeSetAndRetrieved()
        {
            // Arrange
            var initialFilterBody = new ConstantOperatorParameters(true);
            var parameters = new AllOperatorParameters(
                new ParameterOperatorParameters("items"),
                initialFilterBody,
                "x");
            var newFilterBody = new ConstantOperatorParameters(false);

            // Act
            parameters.FilterBody = newFilterBody;

            // Assert
            Assert.Same(newFilterBody, parameters.FilterBody);
        }

        [Fact]
        public void FilterParameterName_CanBeSetAndRetrieved()
        {
            // Arrange
            var parameters = new AllOperatorParameters(
                new ParameterOperatorParameters("items"),
                new ConstantOperatorParameters(true),
                "x");
            string newFilterParameterName = "y";

            // Act
            parameters.FilterParameterName = newFilterParameterName;

            // Assert
            Assert.Equal(newFilterParameterName, parameters.FilterParameterName);
        }
    }
}

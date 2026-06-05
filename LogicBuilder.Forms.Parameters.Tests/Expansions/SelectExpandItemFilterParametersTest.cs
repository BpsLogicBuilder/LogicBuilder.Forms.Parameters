using LogicBuilder.Forms.Parameters.Expansions;
using LogicBuilder.Forms.Parameters.Expressions;

namespace LogicBuilder.Forms.Parameters.Tests.Expansions
{
    public class SelectExpandItemFilterParametersTest
    {
        [Fact]
        public void Constructor_SetsFilterLambdaOperatorProperty()
        {
            // Arrange
            var expectedFilterLambdaOperator = new FilterLambdaOperatorParameters(
                new EqualsBinaryOperatorParameters(
                    new MemberSelectorOperatorParameters("Property", new ParameterOperatorParameters("p")),
                    new ConstantOperatorParameters(new object())),
                typeof(string),
                "p");

            // Act
            var parameters = new SelectExpandItemFilterParameters(expectedFilterLambdaOperator);

            // Assert
            Assert.NotNull(parameters);
            Assert.Same(expectedFilterLambdaOperator, parameters.FilterLambdaOperator);
        }

        [Fact]
        public void FilterLambdaOperator_CanBeSetAndRetrieved()
        {
            // Arrange
            var initialFilterLambdaOperator = new FilterLambdaOperatorParameters(
                new EqualsBinaryOperatorParameters(
                    new MemberSelectorOperatorParameters("Property1", new ParameterOperatorParameters("p")),
                    new ConstantOperatorParameters(new object())),
                typeof(string),
                "p");
            var parameters = new SelectExpandItemFilterParameters(initialFilterLambdaOperator);

            var newFilterLambdaOperator = new FilterLambdaOperatorParameters(
                new NotEqualsBinaryOperatorParameters(
                    new MemberSelectorOperatorParameters("Property2", new ParameterOperatorParameters("x")),
                    new ConstantOperatorParameters(new object())),
                typeof(int),
                "x");

            // Act
            parameters.FilterLambdaOperator = newFilterLambdaOperator;

            // Assert
            Assert.Same(newFilterLambdaOperator, parameters.FilterLambdaOperator);
        }
    }
}

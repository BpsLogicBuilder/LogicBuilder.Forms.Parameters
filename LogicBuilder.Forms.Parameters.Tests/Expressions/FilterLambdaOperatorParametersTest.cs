using LogicBuilder.Forms.Parameters.Expressions;
using System;

namespace LogicBuilder.Forms.Parameters.Tests.Expressions
{
    public class FilterLambdaOperatorParametersTest
    {
        [Fact]
        public void Constructor_SetsAllProperties()
        {
            // Arrange
            var expectedFilterBody = new EqualsBinaryOperatorParameters(
                new MemberSelectorOperatorParameters("Id", new ParameterOperatorParameters("x")),
                new ConstantOperatorParameters(1));
            var expectedSourceElementType = typeof(string);
            string expectedParameterName = "x";

            // Act
            var parameters = new FilterLambdaOperatorParameters(
                expectedFilterBody,
                expectedSourceElementType,
                expectedParameterName);

            // Assert
            Assert.NotNull(parameters);
            Assert.Same(expectedFilterBody, parameters.FilterBody);
            Assert.Equal(expectedSourceElementType, parameters.SourceElementType);
            Assert.Equal(expectedParameterName, parameters.ParameterName);
        }

        [Fact]
        public void FilterBody_CanBeSetAndRetrieved()
        {
            // Arrange
            var initialFilterBody = new ConstantOperatorParameters(true);
            var parameters = new FilterLambdaOperatorParameters(
                initialFilterBody,
                typeof(string),
                "x");
            var newFilterBody = new ConstantOperatorParameters(false);

            // Act
            parameters.FilterBody = newFilterBody;

            // Assert
            Assert.Same(newFilterBody, parameters.FilterBody);
        }

        [Fact]
        public void SourceElementType_CanBeSetAndRetrieved()
        {
            // Arrange
            var parameters = new FilterLambdaOperatorParameters(
                new ConstantOperatorParameters(true),
                typeof(string),
                "x");
            var newType = typeof(int);

            // Act
            parameters.SourceElementType = newType;

            // Assert
            Assert.Equal(newType, parameters.SourceElementType);
        }

        [Fact]
        public void ParameterName_CanBeSetAndRetrieved()
        {
            // Arrange
            var parameters = new FilterLambdaOperatorParameters(
                new ConstantOperatorParameters(true),
                typeof(string),
                "x");
            string newParameterName = "y";

            // Act
            parameters.ParameterName = newParameterName;

            // Assert
            Assert.Equal(newParameterName, parameters.ParameterName);
        }
    }
}

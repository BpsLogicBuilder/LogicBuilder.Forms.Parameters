using LogicBuilder.Forms.Parameters.Expressions;
using System;

namespace LogicBuilder.Forms.Parameters.Tests.Expressions
{
    public class SelectorLambdaOperatorParametersTest
    {
        [Fact]
        public void Constructor_SetsAllProperties()
        {
            // Arrange
            var expectedSelector = new MemberSelectorOperatorParameters("Value", new ParameterOperatorParameters("x"));
            var expectedSourceElementType = typeof(string);
            string expectedParameterName = "x";

            // Act
            var parameters = new SelectorLambdaOperatorParameters(
                expectedSelector,
                expectedSourceElementType,
                expectedParameterName);

            // Assert
            Assert.NotNull(parameters);
            Assert.Same(expectedSelector, parameters.Selector);
            Assert.Equal(expectedSourceElementType, parameters.SourceElementType);
            Assert.Equal(expectedParameterName, parameters.ParameterName);
        }
    }
}

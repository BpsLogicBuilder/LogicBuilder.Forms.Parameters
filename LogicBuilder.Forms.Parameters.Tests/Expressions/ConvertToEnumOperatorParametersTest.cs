using LogicBuilder.Forms.Parameters.Expressions;
using System;

namespace LogicBuilder.Forms.Parameters.Tests.Expressions
{
    public class ConvertToEnumOperatorParametersTest
    {
        [Fact]
        public void Constructor_SetsAllProperties()
        {
            // Arrange
            object expectedConstantValue = 1;
            var expectedType = typeof(DayOfWeek);

            // Act
            var parameters = new ConvertToEnumOperatorParameters(expectedConstantValue, expectedType);

            // Assert
            Assert.NotNull(parameters);
            Assert.Same(expectedConstantValue, parameters.ConstantValue);
            Assert.Equal(expectedType, parameters.Type);
        }
    }
}

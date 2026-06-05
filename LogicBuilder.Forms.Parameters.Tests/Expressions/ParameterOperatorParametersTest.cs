using LogicBuilder.Forms.Parameters.Expressions;

namespace LogicBuilder.Forms.Parameters.Tests.Expressions
{
    public class ParameterOperatorParametersTest
    {
        [Fact]
        public void Constructor_SetsParameterName()
        {
            // Arrange
            string expectedParameterName = "items";

            // Act
            var parameters = new ParameterOperatorParameters(expectedParameterName);

            // Assert
            Assert.NotNull(parameters);
            Assert.Equal(expectedParameterName, parameters.ParameterName);
        }

        [Fact]
        public void ParameterName_CanBeSetAndRetrieved()
        {
            // Arrange
            var parameters = new ParameterOperatorParameters("items");
            string newParameterName = "newItems";

            // Act
            parameters.ParameterName = newParameterName;

            // Assert
            Assert.Equal(newParameterName, parameters.ParameterName);
        }
    }
}

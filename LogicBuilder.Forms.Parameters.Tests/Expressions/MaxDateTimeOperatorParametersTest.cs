using LogicBuilder.Forms.Parameters.Expressions;

namespace LogicBuilder.Forms.Parameters.Tests.Expressions
{
    public class MaxDateTimeOperatorParametersTest
    {
        [Fact]
        public void Constructor_CreatesInstance()
        {
            // Arrange & Act
            var parameters = new MaxDateTimeOperatorParameters();

            // Assert
            Assert.NotNull(parameters);
        }
    }
}

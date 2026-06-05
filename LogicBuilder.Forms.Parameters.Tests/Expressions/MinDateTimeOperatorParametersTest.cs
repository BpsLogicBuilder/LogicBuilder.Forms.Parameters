using LogicBuilder.Forms.Parameters.Expressions;

namespace LogicBuilder.Forms.Parameters.Tests.Expressions
{
    public class MinDateTimeOperatorParametersTest
    {
        [Fact]
        public void Constructor_CreatesInstance()
        {
            // Arrange & Act
            var parameters = new MinDateTimeOperatorParameters();

            // Assert
            Assert.NotNull(parameters);
        }
    }
}

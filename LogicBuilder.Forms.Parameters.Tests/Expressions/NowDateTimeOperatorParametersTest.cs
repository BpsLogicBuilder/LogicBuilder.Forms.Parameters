using LogicBuilder.Forms.Parameters.Expressions;

namespace LogicBuilder.Forms.Parameters.Tests.Expressions
{
    public class NowDateTimeOperatorParametersTest
    {
        [Fact]
        public void Constructor_CreatesInstance()
        {
            // Arrange & Act
            var parameters = new NowDateTimeOperatorParameters();

            // Assert
            Assert.NotNull(parameters);
        }
    }
}

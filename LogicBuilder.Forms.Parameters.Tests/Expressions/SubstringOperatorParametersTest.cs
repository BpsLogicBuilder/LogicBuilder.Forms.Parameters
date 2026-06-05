using LogicBuilder.Forms.Parameters.Expressions;

namespace LogicBuilder.Forms.Parameters.Tests.Expressions
{
    public class SubstringOperatorParametersTest
    {
        [Fact]
        public void Constructor_SetsAllProperties()
        {
            // Arrange
            var expectedSourceOperand = new ConstantOperatorParameters("Hello World");
            var expectedStart = new ConstantOperatorParameters(0);
            var expectedLength = new ConstantOperatorParameters(5);

            // Act
            var parameters = new SubstringOperatorParameters(
                expectedSourceOperand,
                expectedStart,
                expectedLength);

            // Assert
            Assert.NotNull(parameters);
            Assert.Same(expectedSourceOperand, parameters.SourceOperand);
            Assert.NotNull(parameters.Indexes);
            Assert.Equal(2, parameters.Indexes.Length);
            Assert.Same(expectedStart, parameters.Indexes[0]);
            Assert.Same(expectedLength, parameters.Indexes[1]);
        }
    }
}

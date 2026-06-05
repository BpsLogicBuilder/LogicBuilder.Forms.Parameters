using LogicBuilder.Forms.Parameters.Expressions;

namespace LogicBuilder.Forms.Parameters.Tests.Expressions
{
    public class InOperatorParametersTest
    {
        [Fact]
        public void Constructor_SetsAllProperties()
        {
            // Arrange
            var expectedItemToFind = new ConstantOperatorParameters(5);
            var expectedListToSearch = new CollectionConstantOperatorParameters(
                [1, 2, 3, 4, 5],
                typeof(int));

            // Act
            var parameters = new InOperatorParameters(expectedItemToFind, expectedListToSearch);

            // Assert
            Assert.NotNull(parameters);
            Assert.Same(expectedItemToFind, parameters.ItemToFind);
            Assert.Same(expectedListToSearch, parameters.ListToSearch);
        }
    }
}

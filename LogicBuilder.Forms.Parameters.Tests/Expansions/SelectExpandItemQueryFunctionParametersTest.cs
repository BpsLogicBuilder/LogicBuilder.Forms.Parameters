using LogicBuilder.Expressions.Utils.Strutures;
using LogicBuilder.Forms.Parameters.Expansions;
using System.Collections.Generic;

namespace LogicBuilder.Forms.Parameters.Tests.Expansions
{
    public class SelectExpandItemQueryFunctionParametersTest
    {
        [Fact]
        public void Constructor_SetsSortCollectionProperty()
        {
            // Arrange
            var expectedSortCollection = new SortCollectionParameters(
                [
                    new SortDescriptionParameters("Property1", ListSortDirection.Ascending),
                    new SortDescriptionParameters("Property2", ListSortDirection.Descending)
                ],
                10,
                20);

            // Act
            var parameters = new SelectExpandItemQueryFunctionParameters(expectedSortCollection);

            // Assert
            Assert.NotNull(parameters);
            Assert.Same(expectedSortCollection, parameters.SortCollection);
        }

        [Fact]
        public void Constructor_WithEmptySortCollection_SetsSortCollectionProperty()
        {
            // Arrange
            var expectedSortCollection = new SortCollectionParameters(
                []);

            // Act
            var parameters = new SelectExpandItemQueryFunctionParameters(expectedSortCollection);

            // Assert
            Assert.NotNull(parameters);
            Assert.Same(expectedSortCollection, parameters.SortCollection);
        }

        [Fact]
        public void SortCollection_CanBeSetAndRetrieved()
        {
            // Arrange
            var initialSortCollection = new SortCollectionParameters(
                []);
            var parameters = new SelectExpandItemQueryFunctionParameters(initialSortCollection);

            var newSortCollection = new SortCollectionParameters(
                [
                    new SortDescriptionParameters("NewProperty", ListSortDirection.Ascending)
                ],
                5,
                10);

            // Act
            parameters.SortCollection = newSortCollection;

            // Assert
            Assert.Same(newSortCollection, parameters.SortCollection);
        }
    }
}

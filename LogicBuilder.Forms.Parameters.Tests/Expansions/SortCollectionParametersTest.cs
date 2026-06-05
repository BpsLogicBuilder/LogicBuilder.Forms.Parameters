using LogicBuilder.Expressions.Utils.Strutures;
using LogicBuilder.Forms.Parameters.Expansions;
using System.Collections.Generic;

namespace LogicBuilder.Forms.Parameters.Tests.Expansions
{
    public class SortCollectionParametersTest
    {
        [Fact]
        public void Constructor_WithRequiredParameterOnly_SetsAllProperties()
        {
            // Arrange
            var expectedSortDescriptions = new List<SortDescriptionParameters>
            {
                new("Property1", ListSortDirection.Ascending),
                new("Property2", ListSortDirection.Descending)
            };

            // Act
            var parameters = new SortCollectionParameters(expectedSortDescriptions);

            // Assert
            Assert.NotNull(parameters);
            Assert.Same(expectedSortDescriptions, parameters.SortDescriptions);
            Assert.Null(parameters.Skip);
            Assert.Null(parameters.Take);
        }

        [Fact]
        public void Constructor_WithAllParameters_SetsAllProperties()
        {
            // Arrange
            var expectedSortDescriptions = new List<SortDescriptionParameters>
            {
                new("Property1", ListSortDirection.Ascending)
            };
            int? expectedSkip = 10;
            int? expectedTake = 20;

            // Act
            var parameters = new SortCollectionParameters(
                expectedSortDescriptions,
                expectedSkip,
                expectedTake);

            // Assert
            Assert.NotNull(parameters);
            Assert.Same(expectedSortDescriptions, parameters.SortDescriptions);
            Assert.Equal(expectedSkip, parameters.Skip);
            Assert.Equal(expectedTake, parameters.Take);
        }

        [Fact]
        public void Constructor_WithNullSkipAndTake_SetsAllProperties()
        {
            // Arrange
            var expectedSortDescriptions = new List<SortDescriptionParameters>
            {
                new("Property1", ListSortDirection.Ascending)
            };

            // Act
            var parameters = new SortCollectionParameters(
                expectedSortDescriptions,
                null,
                null);

            // Assert
            Assert.NotNull(parameters);
            Assert.Same(expectedSortDescriptions, parameters.SortDescriptions);
            Assert.Null(parameters.Skip);
            Assert.Null(parameters.Take);
        }

        [Fact]
        public void Constructor_WithSkipOnly_SetsAllProperties()
        {
            // Arrange
            var expectedSortDescriptions = new List<SortDescriptionParameters>
            {
                new("Property1", ListSortDirection.Ascending)
            };
            int? expectedSkip = 5;

            // Act
            var parameters = new SortCollectionParameters(
                expectedSortDescriptions,
                expectedSkip);

            // Assert
            Assert.NotNull(parameters);
            Assert.Same(expectedSortDescriptions, parameters.SortDescriptions);
            Assert.Equal(expectedSkip, parameters.Skip);
            Assert.Null(parameters.Take);
        }

        [Fact]
        public void SortDescriptions_CanBeSetAndRetrieved()
        {
            // Arrange
            var initialSortDescriptions = new List<SortDescriptionParameters>
            {
                new("Property1", ListSortDirection.Ascending)
            };
            var parameters = new SortCollectionParameters(initialSortDescriptions);
            var newSortDescriptions = new List<SortDescriptionParameters>
            {
                new("Property2", ListSortDirection.Descending),
                new("Property3", ListSortDirection.Ascending)
            };

            // Act
            parameters.SortDescriptions = newSortDescriptions;

            // Assert
            Assert.Same(newSortDescriptions, parameters.SortDescriptions);
        }

        [Fact]
        public void Skip_CanBeSetAndRetrieved()
        {
            // Arrange
            var parameters = new SortCollectionParameters(
                []);
            int? expectedSkip = 15;

            // Act
            parameters.Skip = expectedSkip;

            // Assert
            Assert.Equal(expectedSkip, parameters.Skip);
        }

        [Fact]
        public void Take_CanBeSetAndRetrieved()
        {
            // Arrange
            var parameters = new SortCollectionParameters(
                []);
            int? expectedTake = 25;

            // Act
            parameters.Take = expectedTake;

            // Assert
            Assert.Equal(expectedTake, parameters.Take);
        }
    }
}

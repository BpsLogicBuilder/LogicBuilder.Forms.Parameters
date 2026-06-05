using LogicBuilder.Expressions.Utils.Strutures;
using LogicBuilder.Forms.Parameters.Expansions;

namespace LogicBuilder.Forms.Parameters.Tests.Expansions
{
    public class SortDescriptionParametersTest
    {
        [Fact]
        public void Constructor_WithDefaultFieldTypeSource_SetsAllProperties()
        {
            // Arrange
            string expectedPropertyName = "PropertyName";
            ListSortDirection expectedOrder = ListSortDirection.Ascending;

            // Act
            var parameters = new SortDescriptionParameters(
                expectedPropertyName,
                expectedOrder);

            // Assert
            Assert.NotNull(parameters);
            Assert.Equal(expectedPropertyName, parameters.PropertyName);
            Assert.Equal(expectedOrder, parameters.SortDirection);
        }

        [Fact]
        public void Constructor_WithAllParameters_SetsAllProperties()
        {
            // Arrange
            string expectedPropertyName = "PropertyName";
            ListSortDirection expectedOrder = ListSortDirection.Descending;
            string expectedFieldTypeSource = "MyApp.Domain.Entities.Custom";

            // Act
            var parameters = new SortDescriptionParameters(
                expectedPropertyName,
                expectedOrder,
                expectedFieldTypeSource);

            // Assert
            Assert.NotNull(parameters);
            Assert.Equal(expectedPropertyName, parameters.PropertyName);
            Assert.Equal(expectedOrder, parameters.SortDirection);
        }

        [Fact]
        public void Constructor_WithAscendingOrder_SetsSortDirectionCorrectly()
        {
            // Arrange
            string expectedPropertyName = "Name";
            ListSortDirection expectedOrder = ListSortDirection.Ascending;

            // Act
            var parameters = new SortDescriptionParameters(
                expectedPropertyName,
                expectedOrder);

            // Assert
            Assert.Equal(ListSortDirection.Ascending, parameters.SortDirection);
        }

        [Fact]
        public void Constructor_WithDescendingOrder_SetsSortDirectionCorrectly()
        {
            // Arrange
            string expectedPropertyName = "CreatedDate";
            ListSortDirection expectedOrder = ListSortDirection.Descending;

            // Act
            var parameters = new SortDescriptionParameters(
                expectedPropertyName,
                expectedOrder);

            // Assert
            Assert.Equal(ListSortDirection.Descending, parameters.SortDirection);
        }

        [Fact]
        public void PropertyName_CanBeSetAndRetrieved()
        {
            // Arrange
            var parameters = new SortDescriptionParameters("InitialProperty", ListSortDirection.Ascending);
            string expectedPropertyName = "UpdatedProperty";

            // Act
            parameters.PropertyName = expectedPropertyName;

            // Assert
            Assert.Equal(expectedPropertyName, parameters.PropertyName);
        }

        [Fact]
        public void SortDirection_CanBeSetAndRetrieved()
        {
            // Arrange
            var parameters = new SortDescriptionParameters("PropertyName", ListSortDirection.Ascending);
            ListSortDirection expectedSortDirection = ListSortDirection.Descending;

            // Act
            parameters.SortDirection = expectedSortDirection;

            // Assert
            Assert.Equal(expectedSortDirection, parameters.SortDirection);
        }
    }
}

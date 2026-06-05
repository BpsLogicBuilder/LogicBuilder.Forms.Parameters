using LogicBuilder.Forms.Parameters.Expansions;
using System.Collections.Generic;

namespace LogicBuilder.Forms.Parameters.Tests.Expansions
{
    public class SelectExpandDefinitionParametersTest
    {
        [Fact]
        public void Constructor_SetsAllProperties()
        {
            // Arrange
            var expectedSelects = new List<string> { "Property1", "Property2", "Property3" };
            var expectedExpandedItems = new List<SelectExpandItemParameters>
            {
                new("NavigationProperty1"),
                new("NavigationProperty2")
            };
            string expectedFieldTypeSource = "MyApp.Domain.Entities";

            // Act
            var parameters = new SelectExpandDefinitionParameters(
                expectedSelects,
                expectedExpandedItems,
                expectedFieldTypeSource);

            // Assert
            Assert.NotNull(parameters);
            Assert.Same(expectedSelects, parameters.Selects);
            Assert.Same(expectedExpandedItems, parameters.ExpandedItems);
        }

        [Fact]
        public void Constructor_WithDefaultFieldTypeSource_SetsAllProperties()
        {
            // Arrange
            var expectedSelects = new List<string> { "Property1" };
            var expectedExpandedItems = new List<SelectExpandItemParameters>
            {
                new("NavigationProperty1")
            };

            // Act
            var parameters = new SelectExpandDefinitionParameters(
                expectedSelects,
                expectedExpandedItems);

            // Assert
            Assert.NotNull(parameters);
            Assert.Same(expectedSelects, parameters.Selects);
            Assert.Same(expectedExpandedItems, parameters.ExpandedItems);
        }

        [Fact]
        public void Selects_CanBeSetAndRetrieved()
        {
            // Arrange
            var initialSelects = new List<string> { "Property1" };
            var parameters = new SelectExpandDefinitionParameters(
                initialSelects,
                []);
            var newSelects = new List<string> { "Property2", "Property3" };

            // Act
            parameters.Selects = newSelects;

            // Assert
            Assert.Same(newSelects, parameters.Selects);
        }

        [Fact]
        public void ExpandedItems_CanBeSetAndRetrieved()
        {
            // Arrange
            var initialExpandedItems = new List<SelectExpandItemParameters>();
            var parameters = new SelectExpandDefinitionParameters(
                [],
                initialExpandedItems);
            var newExpandedItems = new List<SelectExpandItemParameters>
            {
                new("NewNavigationProperty")
            };

            // Act
            parameters.ExpandedItems = newExpandedItems;

            // Assert
            Assert.Same(newExpandedItems, parameters.ExpandedItems);
        }
    }
}

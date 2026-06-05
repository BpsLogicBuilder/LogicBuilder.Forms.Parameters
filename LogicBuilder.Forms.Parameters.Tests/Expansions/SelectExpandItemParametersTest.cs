using LogicBuilder.Forms.Parameters.Expansions;
using LogicBuilder.Forms.Parameters.Expressions;
using System.Collections.Generic;

namespace LogicBuilder.Forms.Parameters.Tests.Expansions
{
    public class SelectExpandItemParametersTest
    {
        [Fact]
        public void Constructor_WithRequiredParameterOnly_SetsAllProperties()
        {
            // Arrange
            string expectedMemberName = "NavigationProperty";

            // Act
            var parameters = new SelectExpandItemParameters(expectedMemberName);

            // Assert
            Assert.NotNull(parameters);
            Assert.Equal(expectedMemberName, parameters.MemberName);
            Assert.Null(parameters.Filter);
            Assert.Null(parameters.QueryFunction);
            Assert.NotNull(parameters.Selects);
            Assert.Empty(parameters.Selects);
            Assert.NotNull(parameters.ExpandedItems);
            Assert.Empty(parameters.ExpandedItems);
        }

        [Fact]
        public void Constructor_WithAllParameters_SetsAllProperties()
        {
            // Arrange
            string expectedMemberName = "NavigationProperty";
            var expectedFilter = new SelectExpandItemFilterParameters(
                new FilterLambdaOperatorParameters(
                    new EqualsBinaryOperatorParameters(
                        new MemberSelectorOperatorParameters("Property", new ParameterOperatorParameters("p")),
                        new ConstantOperatorParameters(new object())),
                    typeof(string),
                    "p"));
            var expectedQueryFunction = new SelectExpandItemQueryFunctionParameters(
                new SortCollectionParameters([]));
            var expectedSelects = new List<string> { "Property1", "Property2" };
            var expectedExpandedItems = new List<SelectExpandItemParameters>
            {
                new("NestedNavigation")
            };
            string expectedFieldTypeSource = "MyApp.Domain.Entities.Custom";
            string expectedNavigationPropertyType = "MyApp.Domain.Entities.Navigation";

            // Act
            var parameters = new SelectExpandItemParameters(
                expectedMemberName,
                expectedFilter,
                expectedQueryFunction,
                expectedSelects,
                expectedExpandedItems,
                expectedFieldTypeSource,
                expectedNavigationPropertyType);

            // Assert
            Assert.NotNull(parameters);
            Assert.Equal(expectedMemberName, parameters.MemberName);
            Assert.Same(expectedFilter, parameters.Filter);
            Assert.Same(expectedQueryFunction, parameters.QueryFunction);
            Assert.Same(expectedSelects, parameters.Selects);
            Assert.Same(expectedExpandedItems, parameters.ExpandedItems);
        }

        [Fact]
        public void Constructor_WithNullOptionalCollections_InitializesEmptyCollections()
        {
            // Arrange
            string expectedMemberName = "NavigationProperty";

            // Act
            var parameters = new SelectExpandItemParameters(
                expectedMemberName,
                null,
                null,
                null,
                null);

            // Assert
            Assert.NotNull(parameters);
            Assert.Equal(expectedMemberName, parameters.MemberName);
            Assert.Null(parameters.Filter);
            Assert.Null(parameters.QueryFunction);
            Assert.NotNull(parameters.Selects);
            Assert.Empty(parameters.Selects);
            Assert.NotNull(parameters.ExpandedItems);
            Assert.Empty(parameters.ExpandedItems);
        }

        [Fact]
        public void MemberName_CanBeSetAndRetrieved()
        {
            // Arrange
            var parameters = new SelectExpandItemParameters("InitialName");
            string expectedMemberName = "NewNavigationProperty";

            // Act
            parameters.MemberName = expectedMemberName;

            // Assert
            Assert.Equal(expectedMemberName, parameters.MemberName);
        }

        [Fact]
        public void Filter_CanBeSetAndRetrieved()
        {
            // Arrange
            var parameters = new SelectExpandItemParameters("NavigationProperty");
            var expectedFilter = new SelectExpandItemFilterParameters(
                new FilterLambdaOperatorParameters(
                    new EqualsBinaryOperatorParameters(
                        new MemberSelectorOperatorParameters("Property", new ParameterOperatorParameters("p")),
                        new ConstantOperatorParameters(new object())),
                    typeof(string),
                    "p"));

            // Act
            parameters.Filter = expectedFilter;

            // Assert
            Assert.Same(expectedFilter, parameters.Filter);
        }

        [Fact]
        public void QueryFunction_CanBeSetAndRetrieved()
        {
            // Arrange
            var parameters = new SelectExpandItemParameters("NavigationProperty");
            var expectedQueryFunction = new SelectExpandItemQueryFunctionParameters(
                new SortCollectionParameters([]));

            // Act
            parameters.QueryFunction = expectedQueryFunction;

            // Assert
            Assert.Same(expectedQueryFunction, parameters.QueryFunction);
        }

        [Fact]
        public void Selects_CanBeSetAndRetrieved()
        {
            // Arrange
            var parameters = new SelectExpandItemParameters("NavigationProperty");
            var expectedSelects = new List<string> { "Property1", "Property2" };

            // Act
            parameters.Selects = expectedSelects;

            // Assert
            Assert.Same(expectedSelects, parameters.Selects);
        }

        [Fact]
        public void ExpandedItems_CanBeSetAndRetrieved()
        {
            // Arrange
            var parameters = new SelectExpandItemParameters("NavigationProperty");
            var expectedExpandedItems = new List<SelectExpandItemParameters>
            {
                new("NestedNavigation")
            };

            // Act
            parameters.ExpandedItems = expectedExpandedItems;

            // Assert
            Assert.Same(expectedExpandedItems, parameters.ExpandedItems);
        }
    }
}

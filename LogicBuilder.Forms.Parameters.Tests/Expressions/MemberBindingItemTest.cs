using LogicBuilder.Forms.Parameters.Expressions;

namespace LogicBuilder.Forms.Parameters.Tests.Expressions
{
    public class MemberBindingItemTest
    {
        [Fact]
        public void Constructor_WithRequiredParameters_SetsAllProperties()
        {
            // Arrange
            string expectedProperty = "Name";
            var expectedSelector = new ConstantOperatorParameters("John");

            // Act
            var item = new MemberBindingItem(expectedProperty, expectedSelector);

            // Assert
            Assert.NotNull(item);
            Assert.Equal(expectedProperty, item.Property);
            Assert.Same(expectedSelector, item.Selector);
        }

        [Fact]
        public void Constructor_WithAllParameters_SetsAllProperties()
        {
            // Arrange
            string expectedProperty = "Name";
            var expectedSelector = new ConstantOperatorParameters("John");
            string expectedFieldTypeSource = "MyApp.Domain.Entities.Custom";

            // Act
            var item = new MemberBindingItem(
                expectedProperty,
                expectedSelector,
                expectedFieldTypeSource);

            // Assert
            Assert.NotNull(item);
            Assert.Equal(expectedProperty, item.Property);
            Assert.Same(expectedSelector, item.Selector);
        }

        [Fact]
        public void Property_CanBeSetAndRetrieved()
        {
            // Arrange
            var item = new MemberBindingItem("Name", new ConstantOperatorParameters("John"));
            string newProperty = "Age";

            // Act
            item.Property = newProperty;

            // Assert
            Assert.Equal(newProperty, item.Property);
        }

        [Fact]
        public void Selector_CanBeSetAndRetrieved()
        {
            // Arrange
            var item = new MemberBindingItem("Name", new ConstantOperatorParameters("John"));
            var newSelector = new ConstantOperatorParameters(30);

            // Act
            item.Selector = newSelector;

            // Assert
            Assert.Same(newSelector, item.Selector);
        }
    }
}

using LogicBuilder.Forms.Parameters.Expressions;
using System;
using System.Collections.Generic;

namespace LogicBuilder.Forms.Parameters.Tests.Expressions
{
    public class CollectionConstantOperatorParametersTest
    {
        [Fact]
        public void Constructor_SetsAllProperties()
        {
            // Arrange
            var expectedConstantValues = new List<object> { 1, 2, 3 };
            var expectedElementType = typeof(int);

            // Act
            var parameters = new CollectionConstantOperatorParameters(expectedConstantValues, expectedElementType);

            // Assert
            Assert.NotNull(parameters);
            Assert.Same(expectedConstantValues, parameters.ConstantValues);
            Assert.Equal(expectedElementType, parameters.ElementType);
        }

        [Fact]
        public void ConstantValues_CanBeSetAndRetrieved()
        {
            // Arrange
            var initialValues = new List<object> { 1, 2, 3 };
            var parameters = new CollectionConstantOperatorParameters(initialValues, typeof(int));
            var newValues = new List<object> { 4, 5, 6 };

            // Act
            parameters.ConstantValues = newValues;

            // Assert
            Assert.Same(newValues, parameters.ConstantValues);
        }

        [Fact]
        public void ElementType_CanBeSetAndRetrieved()
        {
            // Arrange
            var parameters = new CollectionConstantOperatorParameters([1, 2, 3], typeof(int));
            var newType = typeof(string);

            // Act
            parameters.ElementType = newType;

            // Assert
            Assert.Equal(newType, parameters.ElementType);
        }
    }
}

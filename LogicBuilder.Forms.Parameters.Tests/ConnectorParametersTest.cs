namespace LogicBuilder.Forms.Parameters.Tests
{
    public class ConnectorParametersTest
    {
        [Fact]
        public void ParameterlessConstructor_CreatesInstance()
        {
            // Arrange & Act
            var parameters = new ConnectorParameters();

            // Assert
            Assert.NotNull(parameters);
        }

        [Fact]
        public void ParameterlessConstructor_InitializesPropertiesToDefault()
        {
            // Arrange & Act
            var parameters = new ConnectorParameters();

            // Assert
            Assert.Equal(0, parameters.Id);
            Assert.Null(parameters.ShortString);
            Assert.Null(parameters.LongString);
            Assert.Null(parameters.ConnectorData);
        }

        [Fact]
        public void ParameterizedConstructor_SetsAllProperties()
        {
            // Arrange
            int expectedId = 42;
            string expectedShortString = "btn_submit";
            string expectedLongString = "Submit Button";
            object expectedConnectorData = new { Color = "Blue", IsEnabled = true };

            // Act
            var parameters = new ConnectorParameters(
                expectedId,
                expectedShortString,
                expectedLongString,
                expectedConnectorData);

            // Assert
            Assert.Equal(expectedId, parameters.Id);
            Assert.Equal(expectedShortString, parameters.ShortString);
            Assert.Equal(expectedLongString, parameters.LongString);
            Assert.Same(expectedConnectorData, parameters.ConnectorData);
        }

        [Fact]
        public void ParameterizedConstructor_AcceptsNullStrings()
        {
            // Arrange & Act
            var parameters = new ConnectorParameters(1, null, null, null);

            // Assert
            Assert.Equal(1, parameters.Id);
            Assert.Null(parameters.ShortString);
            Assert.Null(parameters.LongString);
            Assert.Null(parameters.ConnectorData);
        }

        [Fact]
        public void Id_CanBeSetAndRetrieved()
        {
            // Arrange
            var parameters = new ConnectorParameters();
            int expectedId = 100;

            // Act
            parameters.Id = expectedId;

            // Assert
            Assert.Equal(expectedId, parameters.Id);
        }

        [Fact]
        public void ShortString_CanBeSetAndRetrieved()
        {
            // Arrange
            var parameters = new ConnectorParameters();
            string expectedShortString = "btn_cancel";

            // Act
            parameters.ShortString = expectedShortString;

            // Assert
            Assert.Equal(expectedShortString, parameters.ShortString);
        }

        [Fact]
        public void LongString_CanBeSetAndRetrieved()
        {
            // Arrange
            var parameters = new ConnectorParameters();
            string expectedLongString = "Cancel Operation";

            // Act
            parameters.LongString = expectedLongString;

            // Assert
            Assert.Equal(expectedLongString, parameters.LongString);
        }

        [Fact]
        public void ConnectorData_CanBeSetAndRetrieved()
        {
            // Arrange
            var parameters = new ConnectorParameters();
            object expectedData = new { Width = 120, Height = 40 };

            // Act
            parameters.ConnectorData = expectedData;

            // Assert
            Assert.Same(expectedData, parameters.ConnectorData);
        }

        [Fact]
        public void ConnectorData_CanStoreVariousObjectTypes()
        {
            // Arrange
            var parameters = new ConnectorParameters();
            var stringData = "test data";
            var intData = 42;
            var complexData = new { Property1 = "value", Property2 = 123 };

            // Act & Assert - String
            parameters.ConnectorData = stringData;
            Assert.Equal(stringData, parameters.ConnectorData);

            // Act & Assert - Int
            parameters.ConnectorData = intData;
            Assert.Equal(intData, parameters.ConnectorData);

            // Act & Assert - Complex Object
            parameters.ConnectorData = complexData;
            Assert.Same(complexData, parameters.ConnectorData);
        }

        [Fact]
        public void Properties_CanBeModifiedAfterConstruction()
        {
            // Arrange
            var parameters = new ConnectorParameters(1, "short1", "long1", "data1")
            {
                // Act
                Id = 2,
                ShortString = "short2",
                LongString = "long2",
                ConnectorData = "data2"
            };

            // Assert
            Assert.Equal(2, parameters.Id);
            Assert.Equal("short2", parameters.ShortString);
            Assert.Equal("long2", parameters.LongString);
            Assert.Equal("data2", parameters.ConnectorData);
        }

        [Fact]
        public void Properties_CanBeSetToNull()
        {
            // Arrange
            var parameters = new ConnectorParameters(1, "short", "long", "data")
            {
                // Act
                ShortString = null,
                LongString = null,
                ConnectorData = null
            };

            // Assert
            Assert.Null(parameters.ShortString);
            Assert.Null(parameters.LongString);
            Assert.Null(parameters.ConnectorData);
        }
    }
}
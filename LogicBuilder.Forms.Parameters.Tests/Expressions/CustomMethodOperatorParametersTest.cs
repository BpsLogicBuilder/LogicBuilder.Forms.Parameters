using LogicBuilder.Forms.Parameters.Expressions;

namespace LogicBuilder.Forms.Parameters.Tests.Expressions
{
    public class CustomMethodOperatorParametersTest
    {
        [Fact]
        public void Constructor_SetsAllProperties()
        {
            // Arrange
            var expectedDeclaringType = typeof(string);
            string expectedMethodName = "Concat";
            string[] expectedParameterTypeNames = ["System.String", "System.String"];
            IExpressionParameter[] expectedArgs =
            [
                new ConstantOperatorParameters("Hello"),
                new ConstantOperatorParameters("World")
            ];

            // Act
            var parameters = new CustomMethodOperatorParameters(
                expectedDeclaringType,
                expectedMethodName,
                expectedParameterTypeNames,
                expectedArgs);

            // Assert
            Assert.NotNull(parameters);
            Assert.Equal(expectedDeclaringType, parameters.DeclaringType);
            Assert.Equal(expectedMethodName, parameters.MethodName);
            Assert.Same(expectedParameterTypeNames, parameters.ParameterTypeNames);
            Assert.Same(expectedArgs, parameters.Args);
        }

        [Fact]
        public void DeclaringType_CanBeSetAndRetrieved()
        {
            // Arrange
            var parameters = new CustomMethodOperatorParameters(
                typeof(string),
                "Method",
                ["System.String"],
                [new ConstantOperatorParameters("test")]);
            var newType = typeof(int);

            // Act
            parameters.DeclaringType = newType;

            // Assert
            Assert.Equal(newType, parameters.DeclaringType);
        }

        [Fact]
        public void MethodName_CanBeSetAndRetrieved()
        {
            // Arrange
            var parameters = new CustomMethodOperatorParameters(
                typeof(string),
                "Method",
                ["System.String"],
                [new ConstantOperatorParameters("test")]);
            string newMethodName = "NewMethod";

            // Act
            parameters.MethodName = newMethodName;

            // Assert
            Assert.Equal(newMethodName, parameters.MethodName);
        }

        [Fact]
        public void ParameterTypeNames_CanBeSetAndRetrieved()
        {
            // Arrange
            var parameters = new CustomMethodOperatorParameters(
                typeof(string),
                "Method",
                ["System.String"],
                [new ConstantOperatorParameters("test")]);
            string[] newParameterTypeNames = ["System.Int32", "System.String"];

            // Act
            parameters.ParameterTypeNames = newParameterTypeNames;

            // Assert
            Assert.Same(newParameterTypeNames, parameters.ParameterTypeNames);
        }

        [Fact]
        public void Args_CanBeSetAndRetrieved()
        {
            // Arrange
            var parameters = new CustomMethodOperatorParameters(
                typeof(string),
                "Method",
                ["System.String"],
                [new ConstantOperatorParameters("test")]);
            IExpressionParameter[] newArgs =
            [
                new ConstantOperatorParameters(42),
                new ConstantOperatorParameters("new")
            ];

            // Act
            parameters.Args = newArgs;

            // Assert
            Assert.Same(newArgs, parameters.Args);
        }
    }
}

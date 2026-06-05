using LogicBuilder.Forms.Parameters.Expressions;

namespace LogicBuilder.Forms.Parameters.Tests.Expressions
{
    public class MemberSelectorOperatorParametersTest
    {
        [Fact]
        public void Constructor_WithRequiredParameters_SetsAllProperties()
        {
            // Arrange
            string expectedMemberFullName = "FirstName";
            var expectedSourceOperand = new ParameterOperatorParameters("person");

            // Act
            var parameters = new MemberSelectorOperatorParameters(
                expectedMemberFullName,
                expectedSourceOperand);

            // Assert
            Assert.NotNull(parameters);
            Assert.Equal(expectedMemberFullName, parameters.MemberFullName);
            Assert.Same(expectedSourceOperand, parameters.SourceOperand);
        }

        [Fact]
        public void Constructor_WithAllParameters_SetsAllProperties()
        {
            // Arrange
            string expectedMemberFullName = "FirstName";
            var expectedSourceOperand = new ParameterOperatorParameters("person");
            string expectedFieldTypeSource = "MyApp.Domain.Entities.Custom";

            // Act
            var parameters = new MemberSelectorOperatorParameters(
                expectedMemberFullName,
                expectedSourceOperand,
                expectedFieldTypeSource);

            // Assert
            Assert.NotNull(parameters);
            Assert.Equal(expectedMemberFullName, parameters.MemberFullName);
            Assert.Same(expectedSourceOperand, parameters.SourceOperand);
        }

        [Fact]
        public void MemberFullName_CanBeSetAndRetrieved()
        {
            // Arrange
            var parameters = new MemberSelectorOperatorParameters("FirstName", new ParameterOperatorParameters("person"));
            string newMemberFullName = "LastName";

            // Act
            parameters.MemberFullName = newMemberFullName;

            // Assert
            Assert.Equal(newMemberFullName, parameters.MemberFullName);
        }

        [Fact]
        public void SourceOperand_CanBeSetAndRetrieved()
        {
            // Arrange
            var initialSourceOperand = new ParameterOperatorParameters("person");
            var parameters = new MemberSelectorOperatorParameters("FirstName", initialSourceOperand);
            var newSourceOperand = new ParameterOperatorParameters("employee");

            // Act
            parameters.SourceOperand = newSourceOperand;

            // Assert
            Assert.Same(newSourceOperand, parameters.SourceOperand);
        }
    }
}

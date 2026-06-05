using LogicBuilder.Forms.Parameters.Expressions;
using System;
using System.Collections.Generic;

namespace LogicBuilder.Forms.Parameters.Tests.Expressions
{
    public class MemberInitOperatorParametersTest
    {
        [Fact]
        public void Constructor_WithMemberBindingsOnly_SetsAllProperties()
        {
            // Arrange
            var expectedMemberBindings = new List<MemberBindingItem>
            {
                new("Name", new ConstantOperatorParameters("John")),
                new("Age", new ConstantOperatorParameters(30))
            };

            // Act
            var parameters = new MemberInitOperatorParameters(expectedMemberBindings);

            // Assert
            Assert.NotNull(parameters);
            Assert.NotNull(parameters.MemberBindings);
            Assert.Equal(2, parameters.MemberBindings.Count);
            Assert.True(parameters.MemberBindings.ContainsKey("Name"));
            Assert.True(parameters.MemberBindings.ContainsKey("Age"));
            Assert.Null(parameters.NewType);
        }

        [Fact]
        public void Constructor_WithMemberBindingsAndNewType_SetsAllProperties()
        {
            // Arrange
            var expectedMemberBindings = new List<MemberBindingItem>
            {
                new("Name", new ConstantOperatorParameters("John"))
            };
            var expectedNewType = typeof(string);

            // Act
            var parameters = new MemberInitOperatorParameters(expectedMemberBindings, expectedNewType);

            // Assert
            Assert.NotNull(parameters);
            Assert.NotNull(parameters.MemberBindings);
            Assert.Single(parameters.MemberBindings);
            Assert.Equal(expectedNewType, parameters.NewType);
        }

        [Fact]
        public void MemberBindings_CanBeSetAndRetrieved()
        {
            // Arrange
            var initialMemberBindings = new List<MemberBindingItem>
            {
                new("Name", new ConstantOperatorParameters("John"))
            };
            var parameters = new MemberInitOperatorParameters(initialMemberBindings);
            var newMemberBindings = new Dictionary<string, IExpressionParameter>
            {
                { "Age", new ConstantOperatorParameters(30) },
                { "City", new ConstantOperatorParameters("NYC") }
            };

            // Act
            parameters.MemberBindings = newMemberBindings;

            // Assert
            Assert.Same(newMemberBindings, parameters.MemberBindings);
            Assert.Equal(2, parameters.MemberBindings.Count);
        }

        [Fact]
        public void NewType_CanBeSetAndRetrieved()
        {
            // Arrange
            var memberBindings = new List<MemberBindingItem>
            {
                new("Name", new ConstantOperatorParameters("John"))
            };
            var parameters = new MemberInitOperatorParameters(memberBindings);
            var newType = typeof(int);

            // Act
            parameters.NewType = newType;

            // Assert
            Assert.Equal(newType, parameters.NewType);
        }
    }
}

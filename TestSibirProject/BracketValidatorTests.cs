using System;
using NUnit.Framework;
namespace TestSibirProject
{
    [TestFixture]
    public class BracketValidatorTests
    {
        [Test]
        public void ValidateBrackets_CorrectlyNestedBrackets_ReturnsTrue()
        {
            // Arrange
            string input = "([{}])";

            // Act
            bool result = BracketValidator.ValidateBrackets(input);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void ValidateBrackets_CorrectlyClosedBrackets_ReturnsTrue()
        {
            // Arrange
            string input = "(){}[]";

            // Act
            bool result = BracketValidator.ValidateBrackets(input);

            // Assert
            Assert.IsTrue(result);
        }
        [Test]
        public void ValidateBrackets_UnclosedBrackets_ReturnsFalse()
        {
            // Arrange
            string input = "(}";

            // Act
            bool result = BracketValidator.ValidateBrackets(input);

            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void ValidateBrackets_IncorrectlyNestedBrackets_ReturnsFalse()
        {
            // Arrange
            string input = "[(])";

            // Act
            bool result = BracketValidator.ValidateBrackets(input);

            // Assert
            Assert.IsFalse(result);
        }
        [Test]
        public void ValidateBrackets_IncorrectlyNested2Brackets_ReturnsFalse()
        {
            // Arrange
            string input = "[({})](]";

            // Act
            bool result = BracketValidator.ValidateBrackets(input);

            // Assert
            Assert.IsFalse(result);
        }
        [Test]
        public void ValidateBrackets_EmptyInput_ReturnsTrue()
        {
            // Arrange
            string input = "";

            // Act
            bool result = BracketValidator.ValidateBrackets(input);

            // Assert
            Assert.IsTrue(result);
        }
    }
}
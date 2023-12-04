using System;
using NUnit.Framework;
namespace TestSibirProject
{
    [TestFixture]
    public class BracketEncoderTests
    {
        [Test]
        public void EncodeWithBrackets_SingleUniqueCharacters_ReturnsOpeningBrackets()
        {
            // Arrange
            string inputStr = "din";

            // Act
            string result = BracketEncoder.EncodeWithBrackets(inputStr);

            // Assert
            Assert.AreEqual("(((", result);
        }

        [Test]
        public void EncodeWithBrackets_RepeatingCharacters_ReturnsClosingBrackets()
        {
            // Arrange
            string inputStr = "Success";

            // Act
            string result = BracketEncoder.EncodeWithBrackets(inputStr);

            // Assert
            Assert.AreEqual(")())())", result);
        }

        [Test]
        public void EncodeWithBrackets_MixedCharacters_ReturnsMixedBrackets()
        {
            // Arrange
            string inputStr = "pip";

            // Act
            string result = BracketEncoder.EncodeWithBrackets(inputStr);

            // Assert
            Assert.AreEqual(")()", result);
        }

        [Test]
        public void EncodeWithBrackets_SpecialCharacters_ReturnsMixedBrackets()
        {
            // Arrange
            string inputStr = "((@";

            // Act
            string result = BracketEncoder.EncodeWithBrackets(inputStr);

            // Assert
            Assert.AreEqual("))(", result);
        }

        [Test]
        public void EncodeWithBrackets_EmptyInput_ReturnsEmptyString()
        {
            // Arrange
            string inputStr = "";

            // Act
            string result = BracketEncoder.EncodeWithBrackets(inputStr);

            // Assert
            Assert.AreEqual("", result);
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using validation.luhn10;

namespace validation.luhn10_test
{
    [TestClass]
    public class Luhn10Test
    {
        #region Private Member Functions

        // The following 2 TestMethod's were used to test private member functions.

        /*[TestMethod]
        public void Checksum_WhenProcessingNumber_ShouldReturnCorrectResult()
        {
            // arrange
            string number = "7992739871";
            int actual, expected = 67;

            Luhn10 validation = new Luhn10();

            // act
            actual = validation.Checksum(number);

            // assert
            Assert.AreEqual(expected, actual);
        }*/

        /*[TestMethod]
        public void Checksum_WhenGivenNothing_ShouldReturnZero()
        {
            // arrange
            string number = "";
            int actual, expected = 0;
            Luhn10 validation = new Luhn10();

            // act
            actual = validation.Checksum(number);

            // assert
            Assert.AreEqual(expected, actual);
        }*/

        #endregion

        [TestMethod]
        public void Validate_WhenValidatingValidNumber_ShouldReturnTrue()
        {
            // arrange
            string number = "79927398713";
            bool actual;
            Luhn10 validation = new Luhn10();

            // act
            actual = validation.Validate(number);

            // assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void Validate_WhenValidatingInvalidNumber_ShouldReturnFalse()
        {
            // arrange
            string number = "79927398714";
            bool actual;
            Luhn10 validation = new Luhn10();

            // act
            actual = validation.Validate(number);

            // assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void CalculateCheckDigit_WhenGivenANumber_ShouldReturnCorrectCheckDigit()
        {
            // arrange
            string number = "7992739871";
            int actual, expected = 3;
            Luhn10 validation = new Luhn10();

            // act
            actual = validation.CalculateCheckDigit(number);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}

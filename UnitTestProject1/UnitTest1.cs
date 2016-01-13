using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringCalculator;

namespace StringCalculatorTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ReturnZeroWhenNullStringISPassed()
        {
            AirthmeticStringCalculator ob = new AirthmeticStringCalculator();
            int result = ob.Add("");
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void ReturnOneWhenOneISPassed()
        {
            AirthmeticStringCalculator ob = new AirthmeticStringCalculator();
            int result = ob.Add("1");
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void ReturnTwoWhenTwoISPassed()
        {
            AirthmeticStringCalculator ob = new AirthmeticStringCalculator();
            int result = ob.Add("2");
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void ReturnThreeWhenOneCommaTwoISPassed()
        {
            AirthmeticStringCalculator ob = new AirthmeticStringCalculator();
            int result = ob.Add("1,2");
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void ReturnSixWhenOneNewlineTwoCommaThreeISPassed()
        {
            AirthmeticStringCalculator ob = new AirthmeticStringCalculator();
            int result = ob.Add("1\n2,3");
            Assert.AreEqual(6, result);
       } 

        [TestMethod]
        public void ReturnThreeWhenSlashSlashDelimiterNewLineNullOneDelimiterTwoISPassed()
        {
            AirthmeticStringCalculator ob = new AirthmeticStringCalculator();
            int result = ob.Add("//\n\n1\n2");
            Assert.AreEqual(3, result);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ExceptionOccuredwhenSlashSlashCommaIsPassed()
        {
            AirthmeticStringCalculator ob = new AirthmeticStringCalculator();
            int result = ob.Add("//,");
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void ThrowForMatExceptionWhenSlashSlashDelimiterNewLine()
        {
            AirthmeticStringCalculator ob = new AirthmeticStringCalculator();
            int result = ob.Add("//;\n");
           // Assert.AreEqual(0, result);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void ThrowFormatExceptionWhenSlashSlashDelimiterNewLineADelimiterBIsPassed()
        {
            AirthmeticStringCalculator ob = new AirthmeticStringCalculator();
            int result = ob.Add("//;\na;b");
             Assert.AreEqual(0, result);
        }

        [TestMethod]
        [ExpectedException(typeof(NegativeNotAllowedException))]
        public void ThrowsNegativeNotAllowedExceptionWhenMinusOneNewlineTwoIsPassed()
        {
            AirthmeticStringCalculator ob = new AirthmeticStringCalculator();
            int result = ob.Add("-1\n2");
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        [ExpectedException(typeof(NegativeNotAllowedException))]
        public void ThrowsNegativeNotAllowedExceptionWhenOneNewlineMinusTwoIsPassed()
        {
            AirthmeticStringCalculator ob = new AirthmeticStringCalculator();
            int result = ob.Add("1\n-2");
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        [ExpectedException(typeof(NegativeNotAllowedException))]
        public void ThrowsNegativeNotAllowedExceptionWhenSlashSlashDelimiterNewlineMinusOneNewlineTwoIsPassed()
        {
            AirthmeticStringCalculator ob = new AirthmeticStringCalculator();
            int result = ob.Add("//\n\n-1\n2");
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentException))]
        public void ThrowArguementExceptionWhenSlashSlashABCIsPassed()
        {
            AirthmeticStringCalculator ob = new AirthmeticStringCalculator();
            int result = ob.Add("//abc");
            Assert.AreEqual(0, result);
        }
    }
}

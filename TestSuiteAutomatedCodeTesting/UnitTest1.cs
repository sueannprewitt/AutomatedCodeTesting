using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutomatedCodeTesting;

namespace TestSuiteAutomatedCodeTesting
{
    [TestClass]
    public class UnitTest1
    {



        [TestMethod]
        public void TestThatContainNormalValues()
        {
            Fraction fraction = new Fraction();
            fraction.Numerator = 100;
            fraction.Denominator = 100;
            var result = fraction.ToDecimal();
            Assert.AreEqual(1, result, "100/100");

            fraction.Numerator = 99;
            fraction.Denominator = 99;
            result = fraction.ToDecimal();
            Assert.AreEqual(1, result, "99/99");
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestforZeroDenominator()
        {
            Fraction fraction = new Fraction();
            fraction.Numerator = 0;
            fraction.Denominator = 0;

        }
    }
}

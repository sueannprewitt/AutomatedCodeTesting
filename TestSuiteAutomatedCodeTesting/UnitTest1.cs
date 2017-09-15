using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutomatedCodeTesting;

namespace TestSuiteAutomatedCodeTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSquaredValues()
        {
            Squared squared = new AutomatedCodeTesting.Squared();
            squared.Sqdnumber = 3;
            var result = squared.Calculate();
            Assert.AreEqual(9, result, "Sqrt of 3");

            squared.Sqdnumber = 2;
            result = squared.Calculate();
            Assert.AreEqual(4, result, "Sqrt of 2");

            squared.Sqdnumber = 25;
            result = squared.Calculate();
            Assert.AreEqual(625, result, "Sqrt of 25");

        }

            [TestMethod]
            public void TestSquareRootOf6()
        {
            Squared squared = new AutomatedCodeTesting.Squared();
            squared.Sqdnumber = 6;
            var result = squared.Calculate();
            Assert.AreEqual(36, result, "Sqrt of 6");

        }

        [TestMethod]
        public void TestSquareRootOf36()
        {
            Squared squared = new AutomatedCodeTesting.Squared();
            squared.Sqdnumber = 36;
            var result = squared.Calculate();
            Assert.AreEqual(36, result, "Sqrt of 36");

        }

        [TestMethod]
        public void TestSquareRootOf55()
        {
            Squared squared = new AutomatedCodeTesting.Squared();
            squared.Sqdnumber = 55;
            var result = squared.Calculate();
            Assert.AreEqual(3,025, result, "Sqrt of 55");

        }
        [TestMethod]
        public void TestSquareRootOf100()
        {
            Squared squared = new AutomatedCodeTesting.Squared();
            squared.Sqdnumber = 100;
            var result = squared.Calculate();
            Assert.AreEqual(360, result, "Sqrt of 100");

        }

        [TestMethod]
        public void TestSquareRootOf600()
        {
            Squared squared = new AutomatedCodeTesting.Squared();
            squared.Sqdnumber = 600;
            var result = squared.Calculate();
            Assert.AreEqual(360,000, result, "Sqrt of 600");
        }

        [TestMethod]
        public void TestSquareRootOf44()
        {
            Squared squared = new AutomatedCodeTesting.Squared();
            squared.Sqdnumber = 44;
            var result = squared.Calculate();
            Assert.AreEqual(1,936, result, "Sqrt of 44");

        }
        [TestMethod]
        public void TestSquareRootOf70()
        {
            Squared squared = new AutomatedCodeTesting.Squared();
            squared.Sqdnumber = 70;
            var result = squared.Calculate();
            Assert.AreEqual(368, result, "Sqrt of 70");

        }

        [TestMethod]
        public void TestSquareRootOf0()
        {
            Squared squared = new AutomatedCodeTesting.Squared();
            squared.Sqdnumber = 0;
            var result = squared.Calculate();
            Assert.AreEqual(0, result, "Sqrt of 0");

        }

        [TestMethod]
        public void TestSquareRootOfNeg3()
        {
            Squared squared = new AutomatedCodeTesting.Squared();
            squared.Sqdnumber = -3;
            var result = squared.Calculate();
            Assert.AreEqual(1.732, result, "Sqrt of -3");

        }



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

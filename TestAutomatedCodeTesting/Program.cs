using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomatedCodeTesting;
using System.Diagnostics;

namespace TestAutomatedCodeTesting
{
    class Program
    {
        void Test(int num, int den, double expectedValue, string testName)
        {
            Fraction fraction = new Fraction(); 
            fraction.Numerator = num;
            fraction.Denominator = den;
            var aDecimal = fraction.ToDecimal(); 
            var Passed = (aDecimal == -1);
            Debug.WriteLine($"{testName} test passed : {Passed}");

        }
        void Run()
        {
            Test(100, -100, -1, "Divide 100 by -100 should be -1");
            Test(-100, 100, -1, "Divide -100 by 100 should be -1");
            Test(99, -99, -1, "Divide 99 by -99 should be -1");


            Fraction fraction = new Fraction(); 
            fraction.Numerator = 0;
            var Passed = false;
            try
            {
                fraction.Denominator = 0;
            } catch (DivideByZeroException)
            {
                Passed = true;
            }
            Debug.WriteLine($"The test passed : {Passed}");




        }
        static void Main(string[] args)
        {
            new Program().Run();
        }
    }
}

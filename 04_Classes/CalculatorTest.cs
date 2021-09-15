using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _04_Classes
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void AddMethod()
        {
            //newing up a Calculator object
            Calculator calculator = new Calculator();

                                         //Arguements
            int result = calculator.Add(57, 892);
            Console.WriteLine(result);

            double sum = calculator.Add(12.4, 13.8);
            sum = calculator.Add(6.5, 6.8);

            int age = calculator.CalculateAge(new DateTime(1947, 11, 4));
        }
    }
}

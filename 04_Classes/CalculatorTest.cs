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

                                         //Arguments
            int result = calculator.Add(57, 892);
            Console.WriteLine(result);

            double sum = calculator.Add(12.4, 13.8);
            sum = calculator.Add(6.5, 6.8);

            int age = calculator.CalculateAge(new DateTime(1947, 11, 4));

            double divide = calculator.DivideTwoNums(10, 3);
            Console.WriteLine(divide);

            int large = calculator.LargeNumber(10, 3);
            Console.WriteLine(large);

            string hello = calculator.GreetUserByName("Amy");
            Console.WriteLine(hello);

            int ageYear = calculator.UserAge(new DateTime(1977, 03, 24));
            Console.WriteLine(ageYear);

            
        }
    }
}

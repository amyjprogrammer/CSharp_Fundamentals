using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _01_Operators
{
    [TestClass]
    public class Arithmetic
    {
        [TestMethod]
        public void SimpleOperators()
        {
            int a = 22;
            int b = 45;

            Console.WriteLine(a + b);//67
            Console.WriteLine(a - b);//-23
            Console.WriteLine(a * b);//multiples
            Console.WriteLine(a / b);//divides
            Console.WriteLine(b % a);//remainder - modulous operator 

            DateTime now = DateTime.Now;

            DateTime otherTime = new DateTime(2100, 1, 21);

            TimeSpan timeSpan = otherTime - now;
            Console.WriteLine(timeSpan.TotalDays);

            //Overflow

            byte number = 200;
            byte otherNumber = 60;

            byte thirdNumber = (byte)(number + otherNumber);
            Console.WriteLine(thirdNumber);//will be 4, because of overflow

        }
    }
}

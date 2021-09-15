using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _02_Conditionals
{
    [TestClass]
    public class IfElse
    {
        [TestMethod]
        public void If()
        {
            bool isHungry = true;
            if (isHungry)
            {
                Console.WriteLine("Go get something to eat!");
            }

            int hoursSpentSleeping = 1;
            if (hoursSpentSleeping > 12)
            {
                Console.WriteLine("How do you sleep so much?");
            }
        }

        [TestMethod]
        public void IfElseStatements()
        {
            bool homeworkDone = false;
            if (homeworkDone)
            {
                Console.WriteLine("Go Watch Netflix");
            }
            else
            {
                Console.WriteLine("Get to work on your homework.");
            }

            int age = 15;

            if (age < 13)
            {
                Console.WriteLine("You are a child");
            }
            else if (age < 20)
            {
                Console.WriteLine("You are a teen");
                if(age >= 18)
                {
                    Console.WriteLine("You are an adult");
                }
            }
            else
            {
                Console.WriteLine("You are an adult");
            }


        }
    }
}

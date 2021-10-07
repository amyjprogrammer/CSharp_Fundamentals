﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Classes
{
    public class Calculator
    {
        //Add
        //1 Access modifier
        //2 return type
        //3 Method name
        //4 Parameter
        //5 Method Body- code method will run
        //6 return keyword(what method sends back)

        //1    //2  //3  //4
        public int Add(int numOne, int numTwo)
        {
            //5
            int sum = numOne + numTwo;
            //6
            return sum;
        }
        private string Name { get; set; }
        

        //Overloading a method
        public double Add(double numOne, double numTwo)
        {
            return numOne + numTwo;
        }

        //Subtract
        public int Subtract(int numOne, int numTwo)
        {
            return numOne - numTwo;
        }

        public int Multiply(int numOne, int numTwo)
        {
            return numOne * numTwo;
        }

        //Calculate age
        public int CalculateAge(DateTime birthdate)
        {
            TimeSpan span = DateTime.Now - birthdate;
            double totalAgeDouble = span.Days / 365.25;
            int years = Convert.ToInt32(Math.Floor(totalAgeDouble));
            return years;
        }

        public double DivideTwoNums(int firstNum, int secondNum)
        {
            return (double)firstNum / (double)secondNum;
        }
        public int LargeNumber(int numbOne, int numbTwo)

        {

            if (numbOne > numbTwo)

            {

                return numbOne;

            }
            else
            {

                return numbTwo;

            }

        }

        public string GreetUserByName(string name)
        {
            return ($"Hello {name}");
        }

        public int UserAge(DateTime birthdate)
        {
            int age = DateTime.Now.Year - birthdate.Year;
            return age;
        }

        public void FizzBuzzMethod(int numbOne)
        {
            for (int i = 1; i <= numbOne; i++)
            {
                if (i % 15 == 0)
                {
                    Console.WriteLine("fizzbuzz"); ;
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

        }
        public int Divide(int x, int y)
        {
            return x / y;
        }
        public int AddNum(int x, int y) => x + y;

        public int Loop()
        {

            for (int i = -1; i < 5; i += 2)
            {
                return i;
            }
            return 0;
        }

        public string DivisibleByThree(int userNum)
        {
            if (userNum % 3 == 0)
            {
                Console.WriteLine("This number is divisible by three");
            }
            else
            {
                Console.WriteLine("This number is not divisible by three");
            }
            return null;
        }

        public string TimesTable()
        {
            for (int i = 1; i < 5; i++)
            {
                for (int index = 1; index < 12; index++)
                {
                    int sum = i * index;
                    return $"{i} * {index} = {sum}";
                }
            }
            return null;
        }
        
    }
}



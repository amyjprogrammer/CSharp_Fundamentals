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


    }
}

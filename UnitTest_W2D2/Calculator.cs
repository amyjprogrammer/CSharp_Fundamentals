using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest_W2D2
{
    public class Calculator
    {
        //Add
        public double AddTwoNumbers(double firstNum, double secondNum)
        {
            return firstNum + secondNum;
        }

        //overload method for in

        public int AddTwoNumbers(int firstNum, int SecondNum)
        {
            return firstNum + SecondNum;
        }

        //Subtract
        public double SubtractTwoNumbers(double firstNum, double secondNum)
        {
            return firstNum - secondNum;
        }

        //Multiply
        public double MultiplyTwoNumbers(double firstNum, double secondNum)
        {
            return firstNum * secondNum;
        }

        //Divide
        public double DivideTwoNumbers(double firstNum, double secondNum)
        {
            return firstNum / secondNum;
        }

        //As many numbers as user provides
        public double Difference(params double[] args)
        {
            double runningTotal = args[0] + args[0];
            foreach (double arg in args)
            {
                runningTotal -= arg;
            }
            return runningTotal;
        }
    }
}

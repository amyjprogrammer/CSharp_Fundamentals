using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _01_Operators
{
    [TestClass]
    public class Comparison
    {
        [TestMethod]
        public void ComparisonOperators()
        {
            int year = 2021;
            string name = "Amy";

            //equal
            bool equal = year == 300;
            bool isThisTim = name == "Bob";
            Console.WriteLine(equal);
            Console.WriteLine(isThisTim);

            //Inequality
            bool notEqual = year != 3000;
            bool isNotTim = name != "Tim";

            //Equality with regards to reference types
            List<string> firstList = new List<string>();
            firstList.Add(name);

            List<string> secondList = new List<string>();
            secondList.Add(name);

            //stored values at different locations
            bool listsAreEqual = firstList == secondList;
            Console.WriteLine(listsAreEqual);//comes out false

            bool listItemsareEqual = firstList[0] == secondList[0];
            Console.WriteLine(listItemsareEqual);//comes out true

            //Greater
            bool twentyFirstCentury = year > 2000;

            //Less than
            bool lessThan = year < 3000;

            //Greater or equal
            bool greaterOrEqual = year >= 2021;

            //Less or equal
            bool lessOrEqual = year <= 1990;

            bool trueValue = true;
            bool falseValue = false;

            // or || (can use |, but will check all the code and less effective)
            bool tort = trueValue || falseValue;
            bool torf = trueValue || trueValue;
            bool fort = falseValue || trueValue;
            bool forf = falseValue || falseValue; //only false

            //&& (can use &, but will check all the code and less effective)
            bool tAndT = trueValue && trueValue; //only true
            bool tAndF = trueValue && falseValue;
            bool fAndT = falseValue && trueValue;
            bool fAndF = falseValue && falseValue;
        }
    }
}

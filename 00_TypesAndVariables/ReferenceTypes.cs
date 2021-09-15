using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _00_TypesAndVariables
{
    [TestClass]
    public class ReferenceTypes
    {
        [TestMethod]
        public void Strings()
        {
            string thisisDeclaration; //declaring
            thisisDeclaration = "This is initializing."; //initializing the declared string

            string declareandInitialize = "This does both!";//must use double quotes "

            //String Manipulation

            string firstName = "Amy";
            string lastName = "Jones";

            Console.WriteLine(firstName + " " + lastName);//concatenation

            //Composite Formating
            string composite = string.Format("{0} {1}", firstName, lastName);

            //Interpolation

            string interpolation = $"{firstName} {lastName}";

        }

        [TestMethod]
        public void Collections()
        {
            string stringExample = "Hello World!";

            string[] stringArray = { "Hello", "What", "Why", "When", "Who", stringExample };

            string[] anotherArray = new string[3];

            Console.WriteLine(stringArray[4]);
            stringArray[4] = "World";

            Console.WriteLine(stringArray[4]);

            //Lists
            List<string> listofStrings = new List<string>();//can change size
            List<int> listOfNumbers = new List<int>();

            listofStrings.Add("Hello");
            listofStrings.Add("two");
            listofStrings.Add("Three");

            Console.WriteLine(listofStrings[0]);

            int a = 5;
            int b = a;

            a = 7;
            Console.WriteLine(a + " " + b);

            listOfNumbers.Add(a);
            listOfNumbers.Add(b);

            List<int> secondListOfNumbers = listOfNumbers;

            Console.WriteLine(listOfNumbers[0] + " " + secondListOfNumbers[0]);//shows 7 and 7

            listOfNumbers[0] = 13;
            Console.WriteLine(listOfNumbers[0] + " " + secondListOfNumbers[0]); //shows 13 and 13

            string firstName = "Simon";
            string lastName = firstName;

            lastName = "Pawlak";
            Console.WriteLine($"{firstName} {lastName}");//shows Simon Pawlak

            //Queues
            //First In First Out
            Queue<string> firstInFirstOut = new Queue<string>();
            firstInFirstOut.Enqueue("Hi");//adds to the queue
            firstInFirstOut.Enqueue("Two");

            Console.WriteLine(firstInFirstOut.Dequeue());  
            Console.WriteLine(firstInFirstOut.Dequeue());

            //Stack
            //last in first out
            Stack<string> lastInFirstOut = new Stack<string>();
            lastInFirstOut.Push("I'm first");
            lastInFirstOut.Push("I'm second");

            Console.WriteLine(lastInFirstOut.Peek());//doesn't remove the item, but just looks at it
            Console.WriteLine(lastInFirstOut.Pop());
            Console.WriteLine(lastInFirstOut.Pop());

            //Dictionaries
            Dictionary<string, string> dictionaryExample = new Dictionary<string, string>();
            dictionaryExample.Add("Bee", "makes honey");

            string bee = dictionaryExample["Bee"];
            Console.WriteLine(bee);

            Dictionary<int, string> numberDictionary = new Dictionary<int, string>();
            numberDictionary.Add(7, "Bond");

            Console.WriteLine(numberDictionary[7]);
            numberDictionary.Add(-777, "Unlucky");

            //Linked List
            // Contains Value and pointer to next list item

            //Hashset
            //Stores UNIQUE values (AKA if it has 7 stored cannot store 7 again)
        }

        [TestMethod]
        public void Classes()
        {
            Random rng = new Random();
            int randomNumber = rng.Next(0, 10);

            Console.WriteLine(randomNumber);
        }
    }
}

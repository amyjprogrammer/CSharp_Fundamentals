using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _03_Loops
{
    [TestClass]
    public class LoopExamples       
    {
        [TestMethod]
        public void While()
        {
            //while loop
            int counter = 1;

            while (counter != 10)
            {
                Console.WriteLine(counter);
                counter ++;
            }

            counter = 1;
            while (true)
            {
                Console.WriteLine(counter);
                if(counter == 7)
                {
                    Console.WriteLine("Goal reached.");
                    break;
                }
                counter++;
            }

            Random rng = new Random();
            bool isRunning = true;
            int someCount;

            while (isRunning)
            {
                someCount = rng.Next(0, 21);//includes 0, but not 21

                if(someCount == 13 || someCount < 5)
                {
                    continue; //continues the loop without progressing in code
                }

                Console.WriteLine(someCount);

                if (someCount == 17)
                {
                    isRunning = false; //Exit Condition
                }
            }
        }

        [TestMethod]
        public void ForLoops()
        {
            int targetNumber = 21;
            //1 for Keyword
            //2 Starting point
            //3 Condition to contine looping
            //4 what to do after each loop
            //5 Body of cod to loop through
            //1  //2     //3              //4
            for(int i=0; i < targetNumber; i++)
            {
                //5
                Console.WriteLine(i);
            }

            string[] students = { "David", "Nate", "Anastacia", "Jeffrey", "Ethan" };

            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"Good Morning {students[i]}");
            }
        }

        [TestMethod]
        public void foreachLoops()
        {
            string[] students = { "David", "Nate", "Anastacia", "Jeffrey", "Ethan" };

            //1 foreach Keyword
            //2 type of collection
            //3 name of the current iteration (can be any name)
            //4 in keyword
            //5 collection being iterated through

            //1     //2    //3         //4    //5
            foreach(string studentName in students)
            {
                //6- body
                Console.WriteLine(studentName + " is in class today");
            }

            string myName = "Amy Michele Jones";
            foreach (var letter in myName)
            {
                if (letter != ' ')
                {
                    Console.WriteLine(letter);
                }
            }
        }

        [TestMethod]
        public void DoWhileLoop()
        {
            int counter = 0;
            //do while loops always run at least once
            do
            {
                Console.WriteLine("Hello " + counter);
                counter++;
            } 
            while (counter < 5);
        }

        //goto keyword
        //Goes to specific line in code
    }
}

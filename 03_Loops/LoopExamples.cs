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
        }
    }
}

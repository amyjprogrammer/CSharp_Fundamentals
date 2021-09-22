using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_StreamingContent_Console
{
    public class ProgramUI
    {
       public void Run()
        {
            RunMenu();
        }

        private void RunMenu()
        {
            //Create a menu with options matching up to my Repository
            Console.WriteLine
                (
                    "Enter the number of your selection:" +
                    "1. Create new streaming content" +
                    "2. Show all streaming content" +
                    "3. Find streaming content by title" +
                    "4. Update content by title" +
                    "5. Remove content" +
                    "6. Exit"
                );
            string userInput = Console.ReadLine();
        }
    }
}

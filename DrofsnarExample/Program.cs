using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrofsnarExample
{
    public class Program
    {
        //where the game is located
        private static string _path = "where you put the game";
        static void Main(string[] args)
        {
            //new up an instance of our game
            Game game = new Game();
            //call out set events method
            game.SetEvents(GetEventsFromFile(_path));
            //run the game
            game.Run();
            //freeze the console
            Console.ReadLine();
        }

        private static string[] GetEventsFromFile(string filePath)
        {
            string text = File.ReadAllText(filePath);
            string[] output = text.Split(',');
            return output;
        }
    }
}

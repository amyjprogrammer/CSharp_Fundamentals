using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_StreamingContent_Console1.Consoles
{
    public class RealConsole : IConsole
    {
        public void WriteLine(string s)
        {
            Console.WriteLine(s);
        }

        public void WriteLine(object o)
        {
            Console.WriteLine(o);
        }

        public void Write(string s)
        {
            Console.WriteLine(s);
        }

        public void Write(object o)
        {
            Console.WriteLine(o);
        }

        public void Clear()
        {
            Console.Clear();
        }

        public ConsoleKeyInfo ReadKey()
        {
            return Console.ReadKey();
        }

        public string ReadLine()
        {
            return Console.ReadLine();
        }

    }
}

using _07_StreamingContent_Console1.Consoles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_StreamingContent_Console1
{
    class Program
    {
        static void Main(string[] args)
        {
            RealConsole realconsole = new RealConsole();
            ProgramUI ui = new ProgramUI(realconsole);

            ui.Run();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorningChallenge_MCW1D3
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "Supercalifragilisticexpialidocious";

            foreach (var writeEachWord in word)
            {
                Console.WriteLine(writeEachWord);
            }

            foreach (var lookForIOrL in word)
            {
                if (lookForIOrL == 'i')
                {
                    Console.WriteLine(lookForIOrL);

                } else if (lookForIOrL == 'L')
                {
                    Console.WriteLine(lookForIOrL);
                }
                else
                {
                    Console.WriteLine("Not an i");
                }

                
            }

            int count = 0;
            foreach (var countEachChar in word)
            {
                count++;
            }
            Console.WriteLine(count);
        }
    }
}

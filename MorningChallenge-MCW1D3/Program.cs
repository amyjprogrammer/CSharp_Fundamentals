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

            //var numbOne = 16;
            //for (int i = 1; i <= numbOne; i++)
            //{
            //    if (i % 15 == 0)
            //    {
            //        return "Fizzbuzz";
            //    }
            //    else if (i % 3 == 0)
            //    {
            //        return "Fizz";
            //    }
            //    else if (i % 5 == 0)
            //    {
            //        return "Buzz";
            //    }
            //    else
            //    {
            //        return i;
            //    }
            //}


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            /*for (int i = 1; i <= 5; i++)
            {
                for (int index = 1; index <= 12; index++)
                {
                    int sum = i * index;
                    Console.WriteLine($"{i} * {index} = {sum}");
                }
            }*/
            int[] allNums = { 1, 2, 3, 4, 5 };
            int index = 0;

            while(index <= 4)
            {
                Console.WriteLine($"Last index {allNums[index]}");
                index++;
            }
            
        }
        public string TimesTable()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int index = 1; index <= 12; index++)
                {
                    int sum = i * index;
                    return $"{i} * {index} = {sum}";
                }
            }
            return null;
        }

        public int SumList(List<int> list)
        {
            int count = 0;
            foreach (var num in list)
            {
                count = count + num;
            }
            return count;
        }

    }
}

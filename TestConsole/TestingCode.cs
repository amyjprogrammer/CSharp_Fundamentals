using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    public class TestingCode
    {
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
    }
}

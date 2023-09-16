using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            int step = 7;
            for (int i = 5; i < 100; i += step)
            {
                number = i;
                Console.WriteLine(number);
            }
        }
    }
}

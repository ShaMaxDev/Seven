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
            int number = 5;
            int step = 7;
           
            for (int i = number; i < 100; i += step)
            {
                Console.WriteLine(i);
            }
        }
    }
}

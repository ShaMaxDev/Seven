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
            int startNumber = 5;
            int step = 7;
            int limit = 96;

            for (int i = startNumber; i <= limit; i += step)
            {
                Console.WriteLine(i);
            }
        }
    }
}

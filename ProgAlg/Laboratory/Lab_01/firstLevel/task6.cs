using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class task6
    {
        static void Main(string[] args)
        {
            for (double x = -4; x <= 4; x += 0.5)
            {
                double y = 0.5 * x * x - 7 * x;
                Console.WriteLine(x + y);
            }
        }
    }
}

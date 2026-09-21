using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class task5
    {
        static void Main()
        {
            double p = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double s = 0;

            for (int i = 0; i < 10; i++)
            {
                s += Math.Pow(p + i * h, 2);
            }

            Console.WriteLine(s);
        }
    }
}


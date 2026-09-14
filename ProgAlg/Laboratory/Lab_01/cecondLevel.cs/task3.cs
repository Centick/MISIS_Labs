using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class task23
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double p = double.Parse(Console.ReadLine());

            double s = 0;
            int n = 0;

            while (s + a + n * h <= p)
            {
                s = s + a + n * h;
                n++;
            }

            Console.WriteLine(n);
        }
    }
}

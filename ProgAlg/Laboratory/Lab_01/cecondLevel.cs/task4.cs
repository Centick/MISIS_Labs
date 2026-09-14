using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class task24
    {
        static void Main()
        {
            double x = double.Parse(Console.ReadLine());

            double s = 0;
            double a = 1;

            while (a >= 0.0001)
            {
                s = s + a;
                a = a * x * x;
            }

            Console.WriteLine(s);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class task4
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double s = 0;

            for (int i = 1; i <= 9; i++) {
                s += Math.Cos(i * x) / Math.Pow(x, i - 1);
            }

            Console.WriteLine(s);
        }
    }
}

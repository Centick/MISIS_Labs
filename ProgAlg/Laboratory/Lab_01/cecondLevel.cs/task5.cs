using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class task25
    {
        static void Main()
        {
            double m = double.Parse(Console.ReadLine());
            double n = double.Parse(Console.ReadLine());
            double i = 0;

            while (m > n)
            {
                m = m - n;
                i++;
            }
            Console.Write(i);
            Console.Write(m);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class task22
    {
        static void Main()
        {
            int p = 1;
            int n = 1;

            while (p * (n + 3) <= 30000) {
                n = n + 3;
                p = p * n;
            }

            Console.WriteLine(n);
            Console.WriteLine(p);
        }
    }
}

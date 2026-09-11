using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class task8
    {
        static void Main(string[] args)
        {
            int f = 1;
            int s = 0;

            for (int i = 1; i <= 6; i++)
            {
                f = f * i;
                s = s + f;
            }

            Console.WriteLine(s);
        }
    }
}

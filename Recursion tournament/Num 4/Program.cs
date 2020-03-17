using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Num_4
{
    class Program
    {
        static int Summ(int a, int b)
        {
            if (a % 10000000 < 10) return b + a;
            else return Summ(a / 10, b + a % 10);
        }
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine()), b = 0;
            Console.WriteLine(Summ(a, b));
            Console.ReadKey();
        }
    }
}

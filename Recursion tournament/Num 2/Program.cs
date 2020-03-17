using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Num_2
{
    class Program
    {
        static int Output(int a, int b)
        {
            if (a % 10000000 < 10)
            {
                Console.Write($"{a % 10} ");
                if (b == 0) return 0;
                else return Output(b % 10, b / 10);
            }
            else return Output(a / 10, b * 10 + a % 10);
        }
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine()), b = 0;
            Output(a, b);
            Console.ReadKey();
        }
    }
}

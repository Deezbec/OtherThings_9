using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Num_5
{
    class Program
    {
        static int progress(int n, int q, int a)
        {
            if (n == 0) return a;
            else return progress(n - 1, q, a * q);
        }
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("q = ");
            int q = Convert.ToInt32(Console.ReadLine()), a = 1;
            Console.WriteLine(progress(n + 1, q, a) - 2);
            Console.ReadKey();
        }
    }
}

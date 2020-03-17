using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Num_3
{
    class Program
    {
        static int summ(int m, int n)
        {
            if (n == 0 || m == 0) return m + n;
            if (m >= 0)
            {
                if (n >= 0)
                    if (m > n) return summ(m + 1, n - 1);
                    else       return summ(m - 1, n + 1);
                else
                    return summ(m - 1, n + 1);
            }
            else
            {
                if (n >= 0) return summ(n, m);
                else        return summ(m - 1, n + 1);
            }
        }
        static void Main(string[] args)
        {
            Console.Write("m = ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("n = ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"m + n = {summ(m, n)}");
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static uint count(uint n)
        {
            uint sumD = 0;
            for (uint i = 1; i <= (n / 2); i++)
            {
                if (n % i == 0) sumD += i;
            }
            return sumD;
        }

        static bool check(ref uint n)
        {
            if (count(n) > n) return true;
            else
            {
                uint k = 1;
                while (count(n) <= n)
                {
                    n += k;
                    if (count(n) > n) break;
                    k++;
                    n -= k;
                    k++;
                }
                return false;
            }
        }

        static void Main()
        {
            uint number = uint.Parse(Console.ReadLine());
            uint ifWrong = number;
            if (check(ref number)) Console.WriteLine("число {0} является избыточным", number);
            else Console.WriteLine("число {0} не является избыточным, новое число {1}", ifWrong, number);
            Console.ReadKey();
        }
    }
}
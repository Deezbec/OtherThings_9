using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Num_6
{
    class Program
    {
        static int sys(int a, int b, int c, int d)
        {
            if(a > 0)
            {
                if (a % b == 0) d++;
                else            c = c * 10 + a % b;
                if (a / 10 == 0) sys(0, 1, c, d);
                else sys(a / 10, b, c, d);
            }
            else
            {
                if (c > 0)
                {
                    if (d > 0) sys(a * 10 + c % 10, b * 10, c / 10, d - 1);
                    else sys(a * 10 + c % 10, b, c / 10, d);
                }
                else
                {
                    if (d > 0) sys(a, b * 10, c, d - 1);
                    else sys(a, b, c, d);
                }
            }
            if (c == 0 && d == 0) return a * b;
            return 0;
        }
        static void Main(string[] args)
        {
            Console.Write("Введите число для перевода: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите основание новой системы счисления: ");
            int b = Convert.ToInt32(Console.ReadLine()), c = 0, d = 0;
            Console.WriteLine($"Результат: {a} = {sys(a, b, c, d)}");
            Console.ReadKey();
        }
    }
}

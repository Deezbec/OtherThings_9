using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Informatics
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine()), t;
            int[] a = new int[n];
            string[] s = Console.ReadLine().Split();
            for (int i = 0; i < n; i++)
                a[i] = Convert.ToInt32(s[i]);
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if((a[j] % 10) > (a[j + 1] % 10))
                    {
                        t = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = t;
                    }
                }
            }
            foreach (int x in a)
                Console.Write($"{x} ");
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}

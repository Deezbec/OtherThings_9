using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] var2 = new int[] { 9, 28, 16, 33, 2, 17, 7, 11, 6, 23, 31, 26, 0, 35, 25, 37, 36, 29, 4, 14, 3, 27, 30, 1, 21, 10, 18, 8, 12, 5, 34, 20, 24, 15, 13, 22, 32, 19 };
            string s = "dad0a90799f7f79}1b{5g31l94cf8c9a68850c";
            char[] a = new char[var2.Length];
            for (int i = 0; i < var2.Length; i++) a[var2[i]] = s[i];
            for (int i = 0; i < var2.Length; i++) Console.Write(a[i]);
            Console.ReadKey();
    }
    }
}

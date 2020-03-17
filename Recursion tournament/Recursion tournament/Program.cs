using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion_tournament
{
    class Program
    {

        static int TurningOver(int a)
        {
            if (a % 100 != 0)
            {
                Console.Write(a % 10);
                return TurningOver(a / 10);
            }
            else return 0;
        }
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            TurningOver(a);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Вариант3
{
    class Program
    {
        static int[] MyInput(int n)
        {
            int[] array = new int[n];
            for (int i = 0; i < n; i++) array[i] = int.Parse(Console.ReadLine());
            return array;
        }

        static void MyPrint(int[] array)
        {
            foreach (int elem in array) Console.Write(elem + " ");
        }

        static int FindIndexOfMaxValue(int[] array)
        {
            int max = int.MinValue;
            int ind = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    ind = i;
                }
            }
            return ind;
        }

        static int FindIndexOfMinValue(int[] array)
        {
            int min = int.MaxValue;
            int ind = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                    ind = i;
                }
            }
            return ind;
        }

        static int SumBetweenMinMax(int[] array)
        {
            int min = FindIndexOfMinValue(array);
            int max = FindIndexOfMaxValue(array);
            int sum = 0;
            if (min > max)
            {
                int temp = min;
                min = max;
                max = temp;
            }

            for (int i = min + 1; i < max; i++) sum += array[i];

            return sum;
        }

        static void MyShift(int[] array, int k)
        {
            for (int i = 0; i < k; i++)
            {
                int temp = array[array.Length - 1];
                for (int j = array.Length - 1; j > 0; j--)
                {
                    array[j] = array[j - 1];
                }
                array[0] = temp;
            }
        }

        static void Intersection(int[] array, int[] massiv)
        {
            //string check = "";
            bool flag;
            //string myIntersection = "";
            for (int i = 0; i < array.Length; i++)
            {
                flag = false;
                for (int j = 0; j < massiv.Length; j++)
                {
                    if (array[i] == massiv[j])
                    {
                        massiv[j] = -1;
                        flag = true;
                    }
                }
                if (flag) Console.Write(array[i] + " ");
            }
            //if (myIntersection.Length == 0) myIntersection = "no intersection";
            //return myIntersection;
        }

        static void NoRepeat(ref int[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] != array[i + 1]) count++;
            }
            int[] arr = new int[count + 1];
            for (int i = 0, j = 0; i < array.Length - 1; i++)
            {
                if (array[i] != array[i + 1])
                {
                    arr[j] = array[i];
                    j++;
                }
            }
            arr[count] = array[array.Length - 1];
            array = arr;
        }
        
        static int[] MyCopy(int[] array)
        {
            int[] copy = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                copy[i] = array[i];
            }
            return copy;
        }
        static void Main(string[] args)
        {
            Console.Write("Введите количество элементов первого массива: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите элементы первого массива: ");
            int[] array = MyInput(n);
            Console.Write("Первый массив: ");
            MyPrint(array);

            int sum = SumBetweenMinMax(array);
            Console.Write("\nСумма элементов максимальным минимальными элементами: {0} ", sum);

            Console.Write("\nВведите число, отвечающее за сдвиг массива. k = ");
            int k = int.Parse(Console.ReadLine());
            MyShift(array, k);
            Console.Write("Первый массив после сдвига на k единиц: ");
            MyPrint(array);

            Console.Write("\nВведите количество элементов второго массива: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите элементы второго массива: ");
            int[] massiv = MyInput(n);
            Console.Write("Второй массив: ");
            MyPrint(massiv);

            int[] copy1 = MyCopy(array);
            int[] copy2 = MyCopy(massiv);
            Console.WriteLine("\nПересечение элементов двух массивов: ");
            Intersection(copy1, copy2);
            

            NoRepeat(ref array);
            Console.Write("\nМассив после удаления повторяющихся элементов: ");
            MyPrint(array);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates2
{
    delegate bool DelCompare(int item, int valueToCompare);
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            PrintValueInArray(arr, 5);

            Console.ReadKey();

        }


        public static void PrintValueInArray(int[] arr, int x)
        {
            DelCompare Compare = new DelCompare(LessThan);
            
            foreach (var item in arr)
            {
                if (Compare(item, x))
                {
                    Console.WriteLine(item);
                }
            }
        }

        public static bool GreaterThat(int item, int valueToCompare)
        {
            return item > valueToCompare;
        }
        public static bool LessThan(int item, int valueToCompare)
        {
            return item < valueToCompare;
        }
    }
}

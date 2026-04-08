using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExperssion
{
    // in delegates2 project we have seen how to use delegates, here we will see how to use lambda expression with delegates
    // and we didn't use DRY principle , and repeat some method with a few diffrence int its body 

    delegate bool DelFilter(int x, int y);

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // this is a lambda expression that takes two parameters x and y and returns true if x is greater than y
            DelFilter Filter1 = (x, y) => x > y; 
            Console.WriteLine("Print Values greater than 5:");
            PrintArrayValuesAfterFiltering(arr, 5, Filter1);
            
            // this is an anonymous method that takes two parameters x and y and returns true if x is greater than y
            DelFilter Filter2 = delegate (int x, int y) { return x < y; }; 
            Console.WriteLine("\nPrint Values less than 5:");
            PrintArrayValuesAfterFiltering(arr, 5, Filter2);


            Console.ReadKey();
        }

        public static void PrintArrayValuesAfterFiltering(int[] arr , int valueToFilter, DelFilter Filter)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (Filter.Invoke(arr[i], valueToFilter))
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Declare an single Dime array of integers with a size of 5
            int[] numbers = new int[5];

            numbers = new int[5]{ 1, 2, 3, 4, 5 };

            // Declare and initialize a multi Dime array of strings

            string[,] FirstNames = { { "John", "Doe" }, { "Jane", "Smith" } };


            // Declare and initialize a jagged array of integers

            // will be an error because we need to specify the numbers of rows in the jagged array
            //int[][] jaggedArray = new int[][];

            int[][] jaggedArray = new int[3][]
            {
                new int[] {1, 2, 3},
                new int[] {4, 5},
                new int[] {6, 7, 8, 9}
            };


            // indices and ranage

            string [] Names = { "Ahmed", "Mohammed", "Ali", "Hassan", "Khalid", "Siddig"};

            //var range = 1..4; // range from index 1 to index 3 (exclusive of index 4)
            //var Slice =  Names[1..4];
            //Console.WriteLine();




        }
    }
}

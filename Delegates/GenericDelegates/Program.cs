using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDelegates
{
    internal class Program
    {

        delegate T DelGenaric <T> (T a, T b);

        static void Main(string[] args)
        {

            DelGenaric<int> Sum = (a, b) => a + b;
            Console.WriteLine(Sum(5, 10));
            
            DelGenaric<string> Concatination = (a, b) => a + " " + b;
            Console.WriteLine(Concatination("Musab", "Ahmed"));

            DelGenaric<float> Divide = (a, b) => a / b;
            Console.WriteLine(Divide(5, 10));

            Console.ReadKey();

        }
    }
}

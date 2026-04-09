using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncDelegates
{

    internal class Program
    {
        static void Main(string[] args)
        {
            // Func returns a value, so we can assign its result to a variable
            Func<int, int, string> conct = (x, y) => $"{x}{y}";
            
            // Action does not return a value, so we cannot assign its result to a variable
            Action<int, int> print = (x, y) =>
            {
                x += 10;
                y += 20;
                Console.WriteLine($"{x}{y}");
            };

            // Predicate returns a boolean value, so we can use it in a conditional statement, and it takes only one parameter
            Predicate<int> ISEven = (x) => x % 2 == 0;

            string FunResult = conct(10, 20);
            Console.WriteLine($"Func result: {FunResult}");
            
            Console.Write($"Action result:");
            print(10, 20);
            
            Console.Write($"Predicate result: {ISEven(20)}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{

    //A delegate is a type that represents references to methods
    //with a particular parameter list and return type. When you instantiate a delegate,
    //you can associate its instance with any method with
    //a compatible signature and return type. You can invoke (or call)
    //the method through the delegate instance.

    // diffrence between delegates and methods in signatures 

    // Delegates's signayure is its return type and parameter list 
    // Method's signature is method name and parameter list


    delegate string DelTranselator(string input, string Language);
    delegate string DelTranselatorPro(string input, string Language, string Accent);

    internal class Program
    {
        static void Main(string[] args)
        {
            // because it's refrence type we should create an instance of it to use it

            DelTranselator Transelator = new DelTranselator(TranselateInputToTargetLanguage);
            string result = Transelator.Invoke("Hello", "French");// Transelator("Hello", "French")

            DelTranselatorPro TranselatorPro = new DelTranselatorPro(TranselateInputToTargetLanguage);
            string result2 = TranselatorPro.Invoke("Hello", "French", "Parisian");// TranselatorPro("Hello", "French", "Parisian")

            Console.WriteLine(result);
            Console.WriteLine(result2);
            Console.ReadKey();
        }
        
        public static string TranselateInputToTargetLanguage(string input, string Language)
        {
            // here we can write the logic to transelate the input to the target language 
            return  input + " in " + Language;
        }

        public static string TranselateInputToTargetLanguage(string input, string Language, string Accent)
        {
            return input + " in " + Language + " with " + Accent + " accent";
        }

    }
        
}

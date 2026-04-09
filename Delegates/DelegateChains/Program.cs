using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateChains
{
    internal class Program
    {

        delegate void DElChainOfMethods1(string input);
        delegate string DElChainOfMethods2(string input);


        static void Main(string[] args)
        {

            DElChainOfMethods1 ChainOfMethods = Method1;
            ChainOfMethods += Method2;
            ChainOfMethods += Method3;

            ChainOfMethods.GetInvocationList();
            
            ChainOfMethods -= Method3;

            //ChainOfMethods("Input!");

            //DElChainOfMethods2 ChainOfMethods = (string input) => "Proceedure 1: " + input;
            //ChainOfMethods += (string input) => "Proceedure 2: " + input;
            //ChainOfMethods += (string input) => "Proceedure 3: " + input;

            ////Console.WriteLine(ChainOfMethods("Input"));


            ChainOfMethods.GetInvocationList();

            Console.ReadLine();
        }

        static void Method1(string input)
        {
            Console.WriteLine("Method 1: " + input);
        }
        
        static void Method2(string input)
        {
            Console.WriteLine("Method 2: " + input);
        }

        static void Method3(string input)
        {
            Console.WriteLine("Method 3: " + input);
        }
        

    }
}

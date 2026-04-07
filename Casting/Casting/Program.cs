using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Boxing and Unboxing
            int i = 123; // value type
            object o; // reference type

            //Boxing : converting from value type to refrence type
            o = i; // boxing

            Console.WriteLine(o);

            //Unboxing : converting from reference type to value type

            int j = (int)o; // unboxing
            Console.WriteLine(j);

            var arr = BitConverter.GetBytes(j);

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

        }
    }
}

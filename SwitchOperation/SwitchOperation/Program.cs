using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchOperation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // switch statement syntax will only compile in C# 8.0 or later
            int cardNumber = 13;
            string cardName = cardNumber switch
            {
                1 => "Ace",
                11 => "Jack",
                12 => "Queen",
                13 => "King",
                _ => cardNumber.ToString()
            };
        }
    }
}

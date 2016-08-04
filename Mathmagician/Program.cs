using System;
using System.Collections.Generic;
using Mathmagician.Commands;

namespace Mathmagician
{
    class Program
    {
        static void Main(string[] args)
        {
            Command test = new Command();
            Console.WriteLine(test.Numbers.Count);
            test.Numbers.Add(2);
            test.Numbers.Add(3);
            test.Numbers.Add(4);
            Console.WriteLine(test.NumbersToString());
            Console.ReadKey();
        }
    }
}

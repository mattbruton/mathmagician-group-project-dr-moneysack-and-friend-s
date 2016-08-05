using System;
using System.Collections.Generic;
using Mathmagician.Commands;

namespace Mathmagician
{
    class Program
    {
        static void Main(string[] args)
        {
            Odd test = new Odd();
            test.CreateNumbers(10);
            Console.WriteLine(test.NumbersToString());
            Console.ReadKey();
        }
    }
}

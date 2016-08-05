using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mathmagician.Commands;

namespace Mathmagician
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Integer newInt = new Integer();
            newInt.GenerateNumbers(9);

            Console.WriteLine(newInt.NumbersToString());

            Console.ReadKey();
            
        }
    }
}

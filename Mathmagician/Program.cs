using System;
using System.Collections.Generic;
<<<<<<< HEAD
=======
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mathmagician.Commands;
>>>>>>> master

namespace Mathmagician
{
    class Program
    {
<<<<<<< HEAD
        static void Main(string[] args)
        {
            Console.WriteLine(Dialog.InitialGreeting());
            CommandMenu();
        }

        static List<string> commandChoices = new List<string>() { "odd", "even", "integers", "primes", "fibonacci", "whoops" };

        private static void CommandMenu()
        {
            while (commandChoices.Contains(BranchingLogic.UsersSelectionFromCommandList()))
            {
                BranchingLogic.UsersSelectionFromCommandList();
            }
=======
        
        static void Main(string[] args)
        {
>>>>>>> master
        }
    }
}

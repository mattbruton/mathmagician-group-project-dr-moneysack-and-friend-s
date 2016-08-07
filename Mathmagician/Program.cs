using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Dialog.InitialGreeting());
            CommandMenu();
        }

        static List<string> commandChoices = new List<string>() { "odd", "even", "integers", "primes", "fibonacci", "whoops" };

        private static void CommandMenu()
        {
            if (BranchingLogic.UsersSelectionFromCommandList() == "nope")
            {
                return;
            }
            else
            {
                while (commandChoices.Contains(BranchingLogic.UsersSelectionFromCommandList()))
                {
                    BranchingLogic.UsersSelectionFromCommandList();
                }
            }
        }
    }
}

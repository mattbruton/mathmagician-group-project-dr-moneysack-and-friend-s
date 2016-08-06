using System;
using System.Collections.Generic;

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
            while (commandChoices.Contains(BranchingLogic.UsersSelectionFromCommandList()))
            {
                BranchingLogic.UsersSelectionFromCommandList();
            }
        }
    }
}

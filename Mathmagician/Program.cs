using System;
using System.Collections.Generic;

namespace Mathmagician
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Dialog.InitialGreeting());
            MainMenu();
            CommandMenu();
        }

        static List<string> commandChoices = new List<string>() { "odd", "even", "integers", "primes", "fibonacci", "whoops", "exit" };

        private static void MainMenu()
        {
            while (!BranchingLogic.CanMoveOnFromMainMenu())
            {
                BranchingLogic.CanMoveOnFromMainMenu();
            }
        }

        private static void CommandMenu()
        {
            while (commandChoices.Contains(BranchingLogic.UserHasSelectedACommandFromList()))
            {
                BranchingLogic.UserHasSelectedACommandFromList();
            }
        }
    }
}

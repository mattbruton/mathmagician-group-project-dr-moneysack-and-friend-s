using System;
using System.Collections.Generic;

namespace Mathmagician
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Dialog.InitialGreeting());

            do
            {
                Console.WriteLine(Dialog.MainMenu());
                Console.Write(Dialog.Prompt());
                BranchingLogic.CanMoveOnFromMainMenu();
            }
            while (!BranchingLogic.CanMoveOnFromMainMenu());

            List<string> commandChoices = new List<string>() { "odd", "even", "integers", "primes", "fibonacci" };

            do
            {
                Console.WriteLine(Dialog.ListOfCommands());
                Console.Write(Dialog.Prompt());
                BranchingLogic.UserHasSelectedACommandFromList();
            }
            while (!commandChoices.Contains(BranchingLogic.UserHasSelectedACommandFromList()));

            Environment.Exit(0);
        }
    }
}

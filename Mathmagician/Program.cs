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

            do
            {
                Console.WriteLine(Dialog.ListOfCommands());
                Console.Write(Dialog.Prompt());
                BranchingLogic.UserHasSelectedACommandFromList();
            }
            while (!BranchingLogic.UserHasSelectedACommandFromList());


            Environment.Exit(0);
        }
    }
}

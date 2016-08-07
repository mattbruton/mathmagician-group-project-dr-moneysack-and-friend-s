using System;

namespace Mathmagician
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Dialog.InitialGreeting());
            CommandMenu();
        }

        private static void CommandMenu()
        {
            do
            {
                if (BranchingLogic.UsersSelectionFromCommandList())
                {
                    return;
                }
            }
            while (!BranchingLogic.UsersSelectionFromCommandList());
        }
    }
}

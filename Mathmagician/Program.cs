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

        private static void CommandMenu()
        {
            do
            {
                if (BranchingLogic.UsersSelectionFromCommandList() == "nope")
                {
                    return;
                }
            }
            while (BranchingLogic.UsersSelectionFromCommandList() != "nope");
        }
    }
}

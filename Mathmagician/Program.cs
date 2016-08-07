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

        static List<string> commandChoices = new List<string>() { "nope" };

        private static void CommandMenu()
        {
            do
            {
                if (BranchingLogic.UsersSelectionFromCommandList() == "nope")
                {
                    return;
                }
            }
            while (!commandChoices.Contains(BranchingLogic.UsersSelectionFromCommandList()));
        }
    }
}

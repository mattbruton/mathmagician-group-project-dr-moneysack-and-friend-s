using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    class BranchingLogic
    {
        public static bool CanMoveOnFromMainMenu()
        {
            bool toNext = false;
            string userChoice = Console.ReadLine();
            switch (userChoice.ToLower())
            {
                case "create numbers":
                    {
                        toNext = true;
                        break;
                    }
                case "exit":
                    {
                        Environment.Exit(0);
                        break;
                    }
                default:
                    {
                        Console.WriteLine(Dialog.InvalidCommand());
                        Console.WriteLine(Dialog.MainMenu());
                        Console.Write(Dialog.Prompt());
                        break;
                    }
            }
            return toNext;
        }

        public static bool UserHasSelectedACommandFromList()
        {
            bool toNext = false;
            string userChoice = Console.ReadLine();
            switch (userChoice.ToLower())
            {
                case "integers":
                    {
                        Console.WriteLine("Need to implement integers");
                        toNext = true;
                        break;
                    }
                case "fibonacci":
                    {
                        Console.WriteLine("Need to implement fibonacci");
                        toNext = true;
                        break;
                    }
                case "primes":
                    {
                        Console.WriteLine("Need to implement primes");
                        toNext = true;
                        break;
                    }
                case "odd":
                    {
                        Console.WriteLine("Need to implement odd numbers");
                        toNext = true;
                        break;
                    }
                case "even":
                    {
                        Console.WriteLine("Need to implement even numbers");
                        toNext = true;
                        break;
                    }
                default:
                    {
                        Console.WriteLine(Dialog.InvalidCommand());
                        Console.WriteLine(Dialog.ListOfCommands());
                        Console.Write(Dialog.Prompt());
                        break;
                    }
            }
            return toNext;
        }

    }
}


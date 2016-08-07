using System;
using Mathmagician.Commands;

namespace Mathmagician
{
    class BranchingLogic
    {
        private static string ReturnUserSelectionAsString()
        {
            string userChoice = Console.ReadLine();
            return userChoice;
        }

        private static void DisplayCommandMenu()
        {
            Console.WriteLine(Dialog.ListOfCommands());
            Console.Write(Dialog.Prompt());
        }

        public static string UsersSelectionFromCommandList()
        {
            string toNext = "";
            DisplayCommandMenu();
            switch (ReturnUserSelectionAsString().ToLower())
            {
                case "integers":
                    {
                        IntegersLogic();
                        toNext = "integers";
                        break;
                    }
                case "fibonacci":
                    {
                        Console.WriteLine("Need to implement fibonacci");
                        toNext = "fibonacci";
                        break;
                    }
                case "primes":
                    {
                        Console.WriteLine("Need to implement primes");
                        toNext = "primes";
                        break;
                    }
                case "odd":
                    {
                        OddLogic();
                        toNext = "odd";
                        break;
                    }
                case "even":
                    {
                        Console.WriteLine("Need to implement even numbers");
                        toNext = "even";
                        break;
                    }
                case "exit":
                    {
                        Console.WriteLine(Dialog.Bye());
                        toNext = "exit";
                        break;
                    }
                default:
                    {
                        Console.WriteLine(Dialog.InvalidCommand());
                        toNext = "whoops";
                        break;
                    }
            }
            return toNext;
        }

        private static string PromptForQuantity()
        {
            Console.WriteLine(Dialog.AskForQuantity());
            Console.Write(Dialog.Prompt());
            string userNumAsString = Console.ReadLine();
            return userNumAsString;
        }

        private static int GetQuantityOfNumbers()
        { 
            int userNumAfterParse;
            bool canInputBeParsed = int.TryParse(PromptForQuantity(), out userNumAfterParse);
            if (!canInputBeParsed)
            {
                return 0;
            }
            return userNumAfterParse;
        }

        private static void OddLogic()
        {
            Odd newOdd = new Odd();
            newOdd.CreateNumbers(GetQuantityOfNumbers());
            Console.WriteLine(newOdd.NumbersToString());
        }

        private static void EvenLogic() { }

        private static void IntegersLogic()
        {
            Integer newInt = new Integer();
            newInt.CreateNumbers(GetQuantityOfNumbers());
            Console.WriteLine(newInt.NumbersToString());
        }

        private static void PrimesLogic() { }

        private static void FibonacciLogic() { }
    }
}


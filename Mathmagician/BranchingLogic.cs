using System;
using Mathmagician.Commands;

namespace Mathmagician
{
    class BranchingLogic
    {
        public static bool CanMoveOnFromMainMenu()
        {
            Console.WriteLine(Dialog.MainMenu());
            Console.Write(Dialog.Prompt());
            string userChoice = Console.ReadLine();
            switch (userChoice.ToLower())
            {
                case "create numbers":
                    {
                        return true;
                    }
                case "exit":
                    {
                        Environment.Exit(0);
                        return false;
                    }
                default:
                    {
                        Console.WriteLine(Dialog.InvalidCommand());
                        return false;
                    }
            }
        }

        public static string UserHasSelectedACommandFromList()
        {
            string toNext = "";
            Console.WriteLine(Dialog.ListOfCommands());
            Console.Write(Dialog.Prompt());
            string userChoice = Console.ReadLine();
            switch (userChoice.ToLower())
            {
                case "integers":
                    {
                        Console.WriteLine("Need to implement integers");
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
                        Environment.Exit(0);
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

        private static int GetQuantityOfNumbers()
        {
            Console.WriteLine(Dialog.AskForQuantity());
            Console.Write(Dialog.Prompt());
            string userNumAsString = Console.ReadLine();
            int userNum = int.Parse(userNumAsString);
            return userNum;
        }

        private static void OddLogic()
        {
            Odd newOdd = new Odd();
            newOdd.CreateNumbers(GetQuantityOfNumbers());
            Console.WriteLine(newOdd.NumbersToString());
        }

        private static void EvenLogic() { }

        private static void IntegersLogic() { }

        private static void PrimesLogic() { }

        private static void FibonacciLogic() { }
    }
}


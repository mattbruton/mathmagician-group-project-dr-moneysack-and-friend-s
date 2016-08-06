using System;
using Mathmagician.Commands;
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

        public static string UserHasSelectedACommandFromList()
        {
            string toNext = "";
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

        public static int GetQuantityOfNumbers()
        {
            Console.WriteLine(Dialog.AskForQuantity());
            Console.Write(Dialog.Prompt());
            string userNumAsString = Console.ReadLine();
            int userNum = int.Parse(userNumAsString);
            return userNum;
        }

        public static void OddLogic()
        {
            Odd newOdd = new Odd();
            newOdd.CreateNumbers(GetQuantityOfNumbers());
            Console.WriteLine(newOdd.NumbersToString());
        }

        public static void EvenLogic()
        {
            Odd newOdd = new Odd();
            newOdd.CreateNumbers(GetQuantityOfNumbers());
            Console.WriteLine(newOdd.NumbersToString());
        }

        public static void IntegersLogic()
        {
            Odd newOdd = new Odd();
            newOdd.CreateNumbers(GetQuantityOfNumbers());
            Console.WriteLine(newOdd.NumbersToString());
        }

        public static void PrimesLogic()
        {
            Odd newOdd = new Odd();
            newOdd.CreateNumbers(GetQuantityOfNumbers());
            Console.WriteLine(newOdd.NumbersToString());
        }

        public static void FibonacciLogic()
        {
            Odd newOdd = new Odd();
            newOdd.CreateNumbers(GetQuantityOfNumbers());
            Console.WriteLine(newOdd.NumbersToString());
        }
    }
}


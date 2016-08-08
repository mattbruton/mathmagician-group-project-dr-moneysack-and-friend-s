using System;
using Mathmagician.Commands;

namespace Mathmagician
{
    class UserInterface
    {
        public static string UserSelection { get; set; }

        private static string UserInputForQuantity { get; set; }

        public static void DisplayInitialGreeting()
        {
            Console.WriteLine(Dialog.InitialGreeting());
        }

        public static void DisplayCommandMenu()
        {
            Console.WriteLine(Dialog.ListOfCommands());
            Console.Write(Dialog.Prompt());
        }

        public static bool UserWantsToMakeNumbers(string input)
        {
            bool canExit = false;
            switch (input.ToLower())
            {
                case "integers":
                    {
                        IntegersLogic();
                        break;
                    }
                case "fibonacci":
                    {
                        Console.WriteLine("Need to implement fibonacci");
                        break;
                    }
                case "primes":
                    {
                        Console.WriteLine("Need to implement primes");
                        break;
                    }
                case "odd":
                    {
                        OddLogic();
                        break;
                    }
                case "even":
                    {
                        Console.WriteLine("Need to implement even numbers");
                        break;
                    }
                case "exit":
                    {
                        Console.WriteLine(Dialog.Bye());
                        canExit = true;
                        break;
                    }
                default:
                    {
                        Console.WriteLine(Dialog.InvalidCommand());
                        break;
                    }
            }
            return canExit;
        }

        private static void QuantityPromptDialog()
        {
            Console.WriteLine(Dialog.AskForQuantity());
            Console.Write(Dialog.Prompt());
        }
        
        private static string PromptForQuantity()
        {
            QuantityPromptDialog();
            UserInputForQuantity = Console.ReadLine();
            return UserInputForQuantity;
        }

        private static int GetQuantityOfNumbers(string input)
        { 
            int userNumAfterParse;
            bool canInputBeParsed = int.TryParse(input, out userNumAfterParse);
        
            if (!canInputBeParsed || userNumAfterParse > 10000)
            {
                return 0;
            }

            return userNumAfterParse;
        }

        private static void OddLogic()
        {
            Odd newOdd = new Odd();
            newOdd.CreateNumbers(GetQuantityOfNumbers(PromptForQuantity()));
            Console.WriteLine(newOdd.NumbersToString());
        }

        private static void EvenLogic() { }

        private static void IntegersLogic()
        {
            Integer newInt = new Integer();
            newInt.CreateNumbers(GetQuantityOfNumbers(PromptForQuantity()));
            Console.WriteLine(newInt.NumbersToString());
        }

        private static void PrimesLogic() { }

        private static void FibonacciLogic() { }
    }
}


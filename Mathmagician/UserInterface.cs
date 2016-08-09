using System;
using Mathmagician.Commands;

namespace Mathmagician
{
    public class UserInterface
    {
        Dialog uiDialog = new Dialog();
        public string UserSelection { get; set; }

        private string UserInputForQuantity { get; set; }

        public void DisplayInitialGreeting()
        {
            Console.WriteLine(uiDialog.InitialGreeting());
        }

        public void DisplayCommandMenu()
        {
            Console.WriteLine(uiDialog.ListOfCommands());
            Console.Write(uiDialog.Prompt());
        }

        public bool UserWantsToMakeNumbers(string input)
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
                        FibonacciLogic();
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
                        EvenLogic();
                        break;
                    }
                case "exit":
                    {
                        Console.WriteLine(uiDialog.Bye());
                        canExit = true;
                        break;
                    }
                default:
                    {
                        Console.WriteLine(uiDialog.InvalidCommand());
                        break;
                    }
            }
            return canExit;
        }

        private void QuantityPromptDialog()
        {
            Console.WriteLine(uiDialog.AskForQuantity());
            Console.Write(uiDialog.Prompt());
        }
        
        private string PromptForQuantity()
        {
            QuantityPromptDialog();
            UserInputForQuantity = Console.ReadLine();
            return UserInputForQuantity;
        }

        private int GetQuantityOfNumbers(string input)
        { 
            int userNumAfterParse;
            bool canInputBeParsed = int.TryParse(input, out userNumAfterParse);
        
            if (!canInputBeParsed || userNumAfterParse > 10000)
            {
                return 0;
            }

            return userNumAfterParse;
        }

        private void OddLogic()
        {
            Odd newOdd = new Odd();
            newOdd.CreateNumbers(GetQuantityOfNumbers(PromptForQuantity()));
            Console.WriteLine(newOdd.NumbersToString());
        }

        private void EvenLogic()
        {
            Even newEven = new Even();
            newEven.CreateNumbers(GetQuantityOfNumbers(PromptForQuantity()));
            Console.WriteLine(newEven.NumbersToString());
        }

        private void IntegersLogic()
        {
            Integer newInt = new Integer();
            newInt.CreateNumbers(GetQuantityOfNumbers(PromptForQuantity()));
            Console.WriteLine(newInt.NumbersToString());
        }

        private void PrimesLogic() { }

        private void FibonacciLogic()
        {
            Fibonacci newFibo = new Fibonacci();
            newFibo.CreateNumbers(GetQuantityOfNumbers(PromptForQuantity()));
            Console.WriteLine(newFibo.NumbersToString());
        }
    }
}


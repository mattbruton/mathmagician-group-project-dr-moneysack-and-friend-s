namespace Mathmagician
{
    public class Dialog
    {
        public string Prompt()
        {
            return "> ";
        }
        public string InitialGreeting()
        {
            return "\n\nI am the Mathmagician! I can make all sorts of numbers!\nJust tell me how many numbers you want and what types of numbers to generate.";
        }

        public string ListOfCommands()
        {
            return "\nWhat type of number or numbers would you like?\n\nIntegers\nPrimes\nFibonacci\nEven\nOdd\n\nExit\n";
        }

        public string Whoops()
        {
            return "Whoops!";
        }

        public string InvalidCommand()
        {
            return "Whoops! I didn't understand that command.\n";
        }

        public string AskForQuantity()
        {
            return "\nHow many numbers would you like me to create?";
        }

        public string Bye()
        {
            return "Goodbye!";
        }
    }
}

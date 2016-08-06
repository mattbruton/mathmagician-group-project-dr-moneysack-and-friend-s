namespace Mathmagician
{
    public class Dialog
    {
        public static string Prompt()
        {
            return "> ";
        }
        public static string InitialGreeting()
        {
            return "\n\nI am the Mathmagician! I can make all sorts of numbers!\nJust tell me how many numbers you want and what types of numbers to generate.";
        }

        public static string ListOfCommands()
        {
            return "\nWhat type of number or numbers would you like?\n\nIntegers\nPrimes\nFibonacci\nEven\nOdd\n\nExit\n";
        }

        public static string Whoops()
        {
            return "Whoops!";
        }

        public static string InvalidCommand()
        {
            return "Whoops! I didn't understand that command.\n";
        }
        public static string AskForQuantity()
        {
            return "\nHow many numbers would you like me to create?";
        }
    }
}

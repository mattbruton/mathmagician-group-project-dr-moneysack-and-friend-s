using System;

namespace Mathmagician
{
    class Program
    {
        static void Main(string[] args)
        {
            UserInterface.DisplayInitialGreeting();
            do
            {
                if (true)
                {
                    UserInterface.DisplayCommandMenu();
                    UserInterface.UserSelection = Console.ReadLine();
                }
            }
            while (!UserInterface.UserWantsToMakeNumbers(UserInterface.UserSelection));
        }
    }
}

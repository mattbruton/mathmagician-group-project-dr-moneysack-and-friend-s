using System;

namespace Mathmagician
{
    class Program
    {
       
        static void Main(string[] args)
        {
            UserInterface UI = new UserInterface();
            UI.DisplayInitialGreeting();
            do
            {
                if (true)
                {
                    UI.DisplayCommandMenu();
                    UI.UserSelection = Console.ReadLine();
                }
            }
            while (!UI.UserWantsToMakeNumbers(UI.UserSelection));
        }
    }
}

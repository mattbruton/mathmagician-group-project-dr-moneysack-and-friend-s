using System;

namespace Mathmagician
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Dialog.InitialGreeting());
            ExitApplicationWhenReturned();
        }

        private static void ExitApplicationWhenReturned()
        {
            do
            {
                if (!BranchingLogic.RunCommandsUntilFalse())
                {
                    return;
                }
            }
            while (BranchingLogic.RunCommandsUntilFalse());
        }
    }
}

using System;
using System.Collections.Generic;

namespace Mathmagician
{
    class Program
    {
        private static string UserCommand { get; set; }
        private static int UserCount { get; set; }
        static void Main(string[] args)
        {
            Console.WriteLine(Dialog.InitialGreeting());
            Console.WriteLine(Dialog.MainMenu());
            Console.Write(Dialog.Prompt());
            Console.ReadLine();
            Console.WriteLine(Dialog.ListOfCommands());
            Console.Write(Dialog.Prompt());
            Console.ReadLine();
            Console.WriteLine(Dialog.Whoops());
            Console.ReadKey();
        }
    }
}

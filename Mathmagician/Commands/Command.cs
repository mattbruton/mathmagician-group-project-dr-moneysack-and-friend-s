using System.Collections.Generic;

namespace Mathmagician.Commands
{
    public abstract class Command : ICommand
    {
        public List<int> Numbers = new List<int>();

        public virtual void CreateNumbers(int quantityOfNumsToCreate) {}

        public string NumbersToString()
        {
            // Assuming user gives a value greater than 0
            if (Numbers.Count >= 1)
            {
                string numberString = string.Format("\nHere are your numbers: \n");
                foreach(int number in Numbers)
                {
                    numberString += string.Format("{0}, ", number);
                }
                return string.Format(numberString.Remove(numberString.Length - 2));
            }
            else
            {
                return string.Format("\nSomething went wrong. Please enter a number between 1 - 10000");
            }
        }
    }
}

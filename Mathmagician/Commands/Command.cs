using System;
using System.Collections.Generic;
using System.Text;

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
                string numberString = string.Format("Here are your numbers: \n");
                foreach(int number in Numbers)
                {
                    numberString += string.Format("{0}, ", number);
                }
                return string.Format(numberString.Remove(numberString.Length - 2));
            }
            // If user gives a lower than 1 number, return string prompting them to use a higher value.
            else
            {
                return string.Format("Give me a quantity that I can work with! At least let me show you a single number.");
            }
        }
    }
}

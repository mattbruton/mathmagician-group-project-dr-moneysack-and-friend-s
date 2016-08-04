using System;
using System.Collections.Generic;
using System.Text;

namespace Mathmagician.Commands
{
    public class Command
    {
        public List<int> Numbers = new List<int>();

        public virtual void GenerateNumbers(int quantityOfNumsToGenerate) {}

        public string NumbersToString()
        {
            StringBuilder numberString = new StringBuilder();
            //iterate through list "Numbers", adding all numbers to numberString

            foreach(int number in Numbers)
            {
                numberString.Append(number).Append(", ");
            }

            //convert numberString to string
            string returnedString = numberString.ToString();
            //remove extra ", " and return string for use in app.
            return returnedString.Remove(returnedString.Length - 2);
        }
    }
}

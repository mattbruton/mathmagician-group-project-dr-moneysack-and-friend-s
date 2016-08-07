using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician.Commands
{
    public class Fibonacci : Command
    {
        public override void CreateNumbers(int quantityOfNumsToCreate)
        {
            int firstInt = 0, secondInt = 1, next;
            for (int i = 0; Numbers.Count != quantityOfNumsToCreate; i++)
            {
                if (i <= 1)
                    next = i;
                else
                {
                    next = firstInt + secondInt;
                    firstInt = secondInt;
                    secondInt = next; 
                }
            }
        }
    }
}
//0, 1, 1, 2, 3, 5, 8... 
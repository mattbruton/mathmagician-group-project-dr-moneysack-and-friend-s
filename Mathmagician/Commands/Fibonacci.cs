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
            if (quantityOfNumsToCreate >= 1)
            {
                Numbers.Add(0);
            }
            if (quantityOfNumsToCreate >= 2)
            {
                Numbers.Add(1);
            }
            for (int i = 1; Numbers.Count != quantityOfNumsToCreate; i++)
            {
                int nextFib = Numbers[i] + Numbers[i - 1];
                Numbers.Add(nextFib);
            }
        }
    }
}
//0, 1, 1, 2, 3, 5, 8... 
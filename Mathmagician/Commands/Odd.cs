using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician.Commands
{
    public class Odd : Command
    {
        public override void CreateNumbers(int quantityOfNumsToCreate)
        {
            for (var i = 0; Numbers.Count != quantityOfNumsToCreate; i++)
            {
                if (i % 2 != 0)
                {
                    Numbers.Add(i);
                }
            }
        }
    }
}

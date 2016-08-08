using System;

namespace Mathmagician.Commands
{
    public class Prime : Command
    {
        public override void CreateNumbers(int quantityOfNumsToCreate)
        {
            if (quantityOfNumsToCreate >= 1)
            {
                Numbers.Add(2);
            }

            for (int i = 3; Numbers.Count != quantityOfNumsToCreate; i++)
            { 
                bool isPrime = true;

                for (int newDivisor = 2; newDivisor <= Math.Sqrt(i); newDivisor++)
                {

                    if (i % newDivisor == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    Numbers.Add(i);
                }
            }
        }
    }
}

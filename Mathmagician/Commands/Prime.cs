using System;

namespace Mathmagician.Commands
{
    public class Prime : Command
    {
        public override void CreateNumbers(int quantityOfNumsToCreate)
        {
            // First Prime number! Had issues with the rest of logic considering I'm skipping all even numbers when counting since they obviously cannot be prime.

            if (quantityOfNumsToCreate >= 1)
            {
                Numbers.Add(2);
            }

            //Starting with the number 3, as long as Numbers list has less items in it than the user wants to display, and then skipping even numbers when we look for the next number to test.

            for (int i = 3; Numbers.Count != quantityOfNumsToCreate; i = i + 2)
            {
                bool numberIsPrime = true;

                // starting again with 3, as long as each number is less than or equal to the square root of our dividend(i), incrementing divisor until this is true

                for (int newDivisor = 3; newDivisor <= Math.Sqrt(i); newDivisor++)
                {   
                    // basically if the number is evenly divisible by anything other than its square root, the number is not prime.

                    if (i % newDivisor == 0)
                    {
                        numberIsPrime = false;
                    }
                }

                // if the number didn't fail the test in the nested conditional statement, it is prime.

                if (numberIsPrime)
                {
                    Numbers.Add(i);
                }
            }
        }
    }
}

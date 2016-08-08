namespace Mathmagician.Commands
{
    public class Integer : Command
    {
        public override void CreateNumbers(int quantityOfNumsToGenerate)
        {
            //Create integers to add to Numbers List
            for (int i = 0; i != quantityOfNumsToGenerate; i++)
            {
                Numbers.Add(i);
            }
        }
    }
}

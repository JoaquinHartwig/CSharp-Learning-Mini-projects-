namespace The_Four_Sisters_and_the_Duckbear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many eggs were collected today? ");
            int eggs = Convert.ToInt32(Console.ReadLine());

            int sisters = eggs / 4;
            int duckbear = eggs % 4;

            Console.WriteLine($"Each sister gets {sisters} eggs.");
            Console.WriteLine($"The duckbear gets {duckbear} eggs.");
        }
    }
}

using System.Threading.Channels;

namespace The_Dominion_of_Kings
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int estates = Convert.ToInt32(Console.ReadLine());
            int duchies = Convert.ToInt32(Console.ReadLine());
            int provinces = Convert.ToInt32(Console.ReadLine());

            int score = estates * 1
          + duchies * 3
          + provinces * 6;
            Console.WriteLine("Your total score is " + score);
        }
    }
}

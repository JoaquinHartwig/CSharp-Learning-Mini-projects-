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

            int x = 5;

            Console.WriteLine(++x);

            int y = 5;

            Console.WriteLine(y++);

            int health = 5;
            int damage = 10;

            health = Math.Max(health - damage, 0);

            Console.WriteLine(health);//Esto lo puedo utilizar en mi RPG

        }
    }
}

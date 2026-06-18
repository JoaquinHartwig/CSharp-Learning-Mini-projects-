namespace Repairing_the_Clocktower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int numero = Convert.ToInt32(Console.ReadLine());
            if (numero % 2 == 0)
            {
                Console.WriteLine("Tick");

            }
            else
            {
                Console.WriteLine("Tock");
            }
        }
    }
}

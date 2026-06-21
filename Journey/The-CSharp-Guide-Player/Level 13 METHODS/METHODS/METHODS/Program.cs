namespace METHODS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CountToTen();
            void CountToTen()
            {
                for (int current = 1; current <= 10; current++)
                    Console.WriteLine(current);
            }
        }
    }
}

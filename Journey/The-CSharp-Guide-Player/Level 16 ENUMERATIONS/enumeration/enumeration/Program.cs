namespace enumeration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Seasons current = Seasons.Summer;
            if (current == Seasons.Summer || current == Seasons.Winter)
                Console.WriteLine("Happy solstice!");
            else
                Console.WriteLine("Happy equinox!");
        }
    }
}

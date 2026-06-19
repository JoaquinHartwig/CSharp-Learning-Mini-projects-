namespace THE_CONVERT_CLASS_AND_THE_PARSE_METHODS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your favorite number?");
            string favoriteNumberText = Console.ReadLine();
            int favoriteNumber = Convert.ToInt32(favoriteNumberText); //Conver to string a integer
            Console.Write(favoriteNumber + " is a great number!");
        }
    }
}

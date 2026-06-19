namespace Do_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playersNumber; // con este bucle no hace falta inicializar en -1 playerNumber
            do
            {
                Console.Write("Enter a number between 0 and 10: ");
                string playerResponse = Console.ReadLine();
                playersNumber = Convert.ToInt32(playerResponse);
            }
            while (playersNumber < 0 || playersNumber > 10);
        }
    }
}

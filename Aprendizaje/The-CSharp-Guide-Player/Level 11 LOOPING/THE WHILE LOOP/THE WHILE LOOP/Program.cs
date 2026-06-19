namespace THE_WHILE_LOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playersNumber = -1;//Lo iniciamos en -1 para asegurar que el while se ejecute al menos una vez
            while (playersNumber < 0 || playersNumber > 10) //Literal termina al poner un numero entre 10 y 0 
            {
                Console.Write("Enter a number between 0 and 10: ");
                string playerResponse = Console.ReadLine();
                playersNumber = Convert.ToInt32(playerResponse);
            }
        }
    }
}

namespace Yessir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Enter the number of row");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of columns");
            int col = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the symbol");
            string symbol = Console.ReadLine();
            for (int i = 0; i < row; i++) {

                {
                    for (int e = 0; e < col;e++)
                    {
                        Console.Write(symbol);
                    }
                    Console.WriteLine();
            */
            Random random = new Random();
            bool PlayAgain = true;
            int min = 1;
            int max = 100;
            int num;
            int RandomNum;
            int Attempts;

            while (PlayAgain)
            {
                Attempts = 0;
                num = 0;
                RandomNum = random.Next(min, max + 1); // Se le agrega +1 para incluir el número máximo en el rango 

                while (num != RandomNum)
                {

                    Console.WriteLine("Guess the number between " + min + " and " + max);
                    num = Convert.ToInt32(Console.ReadLine());


                    Attempts++;// pongo aca el contador de intentos para que cuente cada vez que el usuario ingresa un número, incluso el correcto

                    if (num < RandomNum)
                    {
                        Console.WriteLine("Too low! Try again.");
                    }
                    else if (num > RandomNum)
                    {
                        Console.WriteLine("Too high! Try again.");
                    }

                    else
                    {
                        Console.WriteLine("Congratulations! You've guessed the number in " + Attempts + " attempts.");
                        PlayAgain = false;

                        
                    }



                }

            }
        }
    }
}
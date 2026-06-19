namespace Continue_and_Break
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*for (int a = 1; a <= 10; a++)
                for (int b = 1; b <= 10; b++)
                    Console.WriteLine($"{a} * {b} = {a * b}");*/


            /*
            while (true)
            {
                Console.Write("Think of a number and type it here: ");
                string input = Console.ReadLine();
                if (input == "quit" || input == "exit")
                    break;
                int number = Convert.ToInt32(input);
                if (number == 12)

                {
                    Console.WriteLine("I don't like that number. Pick another one.");
                    continue;// Vuelve al principio del While  
                }
                Console.WriteLine($"I like {number}. It's the one before {number + 1}!");*/
            int totalRows = 5;
            int totalColumns = 10;
            for (int currentRow = 1; currentRow <= totalRows; currentRow++)
            {
                for (int currentColumn = 1; currentColumn <= totalColumns; currentColumn++)
                    Console.Write("*");
                Console.WriteLine();
            }
        }
    }
}

namespace Simula_s_Test
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ChestState state = ChestState.Closed;

            while (true)
            {
                Console.WriteLine($"The chest is {state}.");
                Console.Write("What do you want to do? ");

                string command = Console.ReadLine().ToLower();

                if (state == ChestState.Closed)
                {
                    if (command == "open")
                    {
                        state = ChestState.Open;
                    }
                    else if (command == "lock")
                    {
                        state = ChestState.Locked;
                    }
                    else
                    {
                        Console.WriteLine("Nothing happens.");
                    }
                }
                else if (state == ChestState.Open)
                {
                    if (command == "close")
                    {
                        state = ChestState.Closed;
                    }
                    else
                    {
                        Console.WriteLine("Nothing happens.");
                    }
                }
                else if (state == ChestState.Locked)
                {
                    if (command == "unlock")
                    {
                        state = ChestState.Closed;
                    }
                    else
                    {
                        Console.WriteLine("Nothing happens.");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
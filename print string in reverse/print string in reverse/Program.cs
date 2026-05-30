namespace print_string_in_reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your mensage:");
            string message = Console.ReadLine();
            //Console.WriteLine(message[0]);
            //Console.WriteLine(message.Length);

            for (int i = 0; i < message.Length; i++)
            {
                Console.Write(message[i]);
            }
            Console.Write"-");
            for (int i = message.Length - 1; i >= 0; i--)
            {
                Console.Write(message[i]);
            }



        }

    }
}


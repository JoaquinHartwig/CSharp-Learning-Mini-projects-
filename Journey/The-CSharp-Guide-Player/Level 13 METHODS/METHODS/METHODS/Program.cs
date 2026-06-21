namespace METHODS
{
    internal class Program  // Métodos = una forma de dividir problemas grandes
                            //Cada método resuelve un problema pequeño
    {
        static void Main(string[] args)
        {
            CountToTen();
            Count(11);
            GetUserName();
            /// <summary>
            void CountToTen()
            {
                for (int current = 1; current <= 10; current++)
                    Console.WriteLine(current);
            }
            void Count(int numberToCountTo)
            {
                for (int current = 1; current <= numberToCountTo; current++)
                    Console.WriteLine(current);
            }
            string GetUserName() //returning early
                                 //return sale del método completo.
            {
                while (true)
                {
                    Console.Write("What is your name? ");
                    string name = Console.ReadLine();
                    if (name != "") // Empty string
                        return name;
                    Console.WriteLine("Let's try that again.");
                }
            }
            void Count2(int numberToCountTo)
            {
                if (numberToCountTo < 1)
                    return;//sale del metodo
                for (int index = 1; index <= numberToCountTo; index++)
                    Console.WriteLine(index);
            }

            //method overloading,

            //A good example is Console’s WriteLine method, which has many overloads

            Console.WriteLine("hi MY NAME IS RAYWE");
            Console.WriteLine("CHEVIVARA");


            //Two different ways of make an method
            int DoubleAndAddOne(int value)
            {
                return value * 2 + 1;
            }


            int DoubleAndAddOne2(int value) => value * 2 + 1;

          
            /// Counts to the given number, starting at 1 and including the number provided.
            /// </summary
        }
    }
}

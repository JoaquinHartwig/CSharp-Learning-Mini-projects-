namespace DECISION_MAKING
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int score = 100;
            if (score == 100) // sin llaves el programa solo interpreta a la primera linea como parte de la condicion if
                Console.WriteLine("A+!");
                 Console.WriteLine("Perfect score!"); // BUG!

            int x = 10;

            if (x > 5)
            {
                int y = 20;
                Console.WriteLine(y);
            }

            //Console.WriteLine(y); // ERROR
        }
    }
}

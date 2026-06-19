using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Switches
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            string text =
           number switch //Version moderna de switch
            {
            0 => "zero",//produce" o "devuelve".
                1 => "one",
               _ => "other"
              };
            Console.WriteLine(text);
        }
    }
}

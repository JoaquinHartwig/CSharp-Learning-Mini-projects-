namespace Operador_Condicional__ternario_
{
    internal class Program
    {
        static void Main(string[] args)
        {   /*
            Console.WriteLine("Ingresa la temperatura en grados");
            double temperatura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(temperatura > 25 ? "Hace calor " : "Hace frio!");
        */
            //Interpolacion de cadenas
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your last name");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter your age ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Your fullname is {name}-{lastName} and your age is {age}. ");


        }
    }
}

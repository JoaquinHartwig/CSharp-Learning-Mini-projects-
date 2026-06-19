using System.Globalization;

namespace Metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {   /*
            Console.WriteLine("Ingresa el nombre del cumpleañero");
            string nombre = Console.ReadLine();
            for (int i = 0; i < 3; i++)
            {
                CantarCumpleaños(nombre);
            }
            */
            double resultado ;
            Console.WriteLine("Ingrese dos valores para multiplicarlos");
            Console.WriteLine("Numero uno");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Numero dos");
            double b = double.Parse(Console.ReadLine());
            resultado  =  Multiplicar(a, b );
            Console.WriteLine($"El resultado es: {resultado}");
        }
        /*
        static void CantarCumpleaños(string nombre)
        {
            Console.WriteLine("Feliz cumpleaños a ti");
            Console.WriteLine("Feliz cumpleaños a ti");
            Console.WriteLine($"Feliz cumpleaños querido/a {nombre}" );
            Console.WriteLine("Feliz cumpleaños a ti");
       
        }
         */
        static double Multiplicar(double a, double b)
        {
            return a * b;
           
        }
    }
}

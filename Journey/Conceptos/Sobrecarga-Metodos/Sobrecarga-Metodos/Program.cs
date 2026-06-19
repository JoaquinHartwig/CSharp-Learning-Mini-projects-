namespace Sobrecarga_Metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double resultado;
            resultado = Multiplicar(2, 3, 4);
            Console.WriteLine(resultado);


        }
        static double Multiplicar(double a, double b)
        {
            return a * b;
        }
        static double Multiplicar(double a, double b, double c)
        {
            return a * b * c;


        }

    }
}

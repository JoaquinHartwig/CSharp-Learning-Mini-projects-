namespace Excepciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double resultado = 0;
                Console.WriteLine("Ingrese el primer numero");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo numero");
                double b = Convert.ToDouble(Console.ReadLine());
                if (b == 0)
                {
                    Console.WriteLine("Por favor, no dividir por 0");
                    
                }
                else
                {
                    resultado = a / b;
                    Console.WriteLine("El resultado es " + resultado);
                }
               

                
            }
            catch (FormatException Caca)
            {
                Console.WriteLine("Por favor,ingrese solo números");
            }
            finally
            {
                Console.WriteLine("Gracias por usar el programa");
            }


        }
    }
}

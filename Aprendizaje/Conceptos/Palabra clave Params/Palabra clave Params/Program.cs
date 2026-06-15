namespace Palabra_clave_Params
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //quiero poder mandar la cantidad  de numeros como parametros q yo queira y sumarlos con un metodo
            double resultado2 = SumarNumeros(1, 2, 3, 4, 5);
            Console.WriteLine(resultado2);

        }
        static double SumarNumeros(params double[] numeros)
        {
            double resultado = 0;
            foreach (double numero in numeros) // recorro el array de numeros y los voy sumando al resultado,lo va guardando en numero y lo va sumando al resultado
            {
                resultado += numero;
            }
            return resultado;



        }
    }
}

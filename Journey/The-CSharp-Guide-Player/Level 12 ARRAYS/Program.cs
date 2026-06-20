namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numero = new int[3];
            Console.WriteLine(numero.Length);

            int[] tabla = new int[3];
            int[] theMiddle = tabla[1..^1];//"Desde el índice 1 hasta antes del último elemento."   
        }
    }
}

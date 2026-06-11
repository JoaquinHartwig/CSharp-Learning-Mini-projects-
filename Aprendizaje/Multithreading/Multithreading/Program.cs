using System.Threading;
namespace Multithreading
{
    internal class Program
    {
        static void Main(string[] args) //Un hilo es un camino de ejecuccion de un programa
        {
            Thread hiloprincipal = Thread.CurrentThread;
            hiloprincipal.Name = "Hilo principal";
            Console.WriteLine(hiloprincipal.Name);
        }
    }
}

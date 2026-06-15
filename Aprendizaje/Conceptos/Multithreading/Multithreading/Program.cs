using System.Threading;
namespace Multithreading
{
    internal class Program //Los multihilos (multithreading) sirven para que un programa
                           //pueda hacer varias tareas al mismo tiempo o
                           //, más precisamente, que parezca hacerlo simultáneamente.
    {
        static void Main(string[] args) //Un hilo es un camino de ejecuccion de un programa
        {
            Thread hiloprincipal = Thread.CurrentThread;
            hiloprincipal.Name = "Hilo principal";
            Console.WriteLine(hiloprincipal.Name);
        }
    }
}

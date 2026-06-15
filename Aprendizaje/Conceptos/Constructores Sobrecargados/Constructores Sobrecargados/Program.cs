namespace Constructores_Sobrecargados
{
    internal class Program
    {
        static void Main(string[] args) //Herencia (Nos permite reutiliazr codigo de una clase base en clases derivadas)
        {
           Auto auto = new Auto();
            Bicicleta bicicleta = new Bicicleta();
            Barco barco = new Barco();
            Console.WriteLine($"El auto tiene una velocidad = {auto.Velocidad} y tiene {auto.ruedas}");
            auto.Avanzar();

        }
    }
}

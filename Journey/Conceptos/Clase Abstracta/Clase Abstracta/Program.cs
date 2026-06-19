namespace Clase_Abstracta
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            //Una Clase abstracta es una clase que no se puede instanciar, es decir, no se pueden crear objetos de esa clase.Es como un molde pero sin molde definido, es decir, no tiene una implementación completa. Las clases abstractas se utilizan para definir una estructura común para las clases derivadas, pero no se pueden utilizar directamente.
        }
    }


    abstract class Vehiculo // Una clase abstracta sirve como base para otras clases, pero no se puede instanciar directamente. Se utiliza para definir una estructura común para las clases derivadas.
    {
        public int Velocidad = 0; //Porque no tiene sentido crear un vehiculo como objeto, ya que un vehiculo es un concepto abstracto, no es algo concreto que se pueda tocar o ver, sino que es una idea general de lo que es un vehiculo. Por eso se utiliza una clase abstracta para definir la estructura común de los vehiculos, pero no se puede crear un objeto de la clase Vehiculo directamente.
        public void avanzar()
        {
            Console.WriteLine("El vehículo avanza a " + Velocidad + " km/h");
        }
    }

    class Auto : Vehiculo
    {
        public int ruedas = 4;
        int velocidadAMax = 300;
    }

    class Bicicleta: Vehiculo
    {
        public int ruedas = 2;
        int velocidadAMax = 100;
    }
    class Barco : Vehiculo
    {
        public int ruedas = 0;
        int velocidadAMax = 200;
    }

}

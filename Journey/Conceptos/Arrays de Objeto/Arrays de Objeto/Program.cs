using System.Reflection.Metadata.Ecma335;

namespace Arrays_de_Objeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Auto[] garage = new Auto[3];// Crear un array de objetos Auto con capacidad para 3 elementos 
            for (int i = 0; i < garage.Length; i++)
            {
                Console.WriteLine($"Ingrese el modelo del auto {i + 1}:");
                string modelo = Console.ReadLine();
                garage[i] = new Auto(modelo);// Crear un nuevo objeto Auto con el modelo ingresado y asignarlo al array
            }
            for (int i = 0; i < garage.Length; i++)
            {
                Console.WriteLine($"El modelo del auto {i + 1} es: {garage[i].Modelo}");// Acceder al modelo de cada auto en el array y mostrarlo
            }
            Auto auto1 = new Auto("Toyota");
            Auto auto2 = new Auto("Honda");
            Auto auto3 = new Auto("Ford");
            garage[0] = auto1;// Asignar objetos Auto a las posiciones del array
            garage [1] = auto2;
            garage [2] = auto3;
            for (int i = 0; i < garage.Length; i++)
            {
                Console.WriteLine($"El modelo del auto {i + 1} es: {garage[i].Modelo}");// Mostrar los modelos de los autos asignados al array
            }
            //Hay q poner .Modelo para acceder a la propiedad Modelo de cada objeto Auto en el array y mostrarlo
            int e = 0;
            foreach (Auto auto in garage)
            {
               
                e++;
                Console.WriteLine(auto.Modelo +  e);
            }
            Auto[] garaje2 = // Crear un array de objetos Auto utilizando la sintaxis de inicialización de arrays
                {
                new Auto("Chevrolet"),//Objetos Anonimos.No se les asigna un nombre, se crean directamente dentro del array.

                new Auto("Nissan"),
                new Auto("Volkswagen")

            }
        class Auto
        {
            public string Modelo;

            public Auto(string modelo)
            {
                Modelo = modelo;
            }

        }

    }
}

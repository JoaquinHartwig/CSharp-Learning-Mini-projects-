namespace Polimorfismo
{
    internal class Program//Un objeto puede ser tratado como su clase padre, pero ejecutar el comportamiento de su clase hija
    {
        static void Main(string[] args)//Uno de los temas más Temidos :O
            //Viene del griego y significa muchas formas
        {
           Auto auto = new Auto();//Creamos objetos 
           Bicicleta bicicleta = new Bicicleta();
            Barco barco = new Barco();
            vehiculo[] vehiculos = { auto, bicicleta, barco };//funciona pq todos comparten el mismo tipo de dato q es vehiculo,Ya q si solo es auto solo va funcionar para el auto
            foreach (vehiculo vehiculo in vehiculos)
            {
                vehiculo.Avanzar();//Polimorfismo muy usado en videjuegos:un ejemplo los mobs de Minecraft todos pueden recibir daño pero cada uno lo recibe y comporta de forma distinta
            }


        }

    }
    class vehiculo
    {
        public virtual void Avanzar() // La palabra clave virtual significa:"Las clases hijas pueden reemplazar este método si quieren."
        {//"Tengo una versión por defecto, pero permito que mis hijos la cambien."

        }

    }
    class Auto : vehiculo //La palabra override significa:
    {//"Estoy reemplazando la versión heredada."
        public override void Avanzar()
        {
            Console.WriteLine("El auto esta avanzando");
        }
    
        }
    
    class  Bicicleta : vehiculo 
    {
        public override void Avanzar()
        {
            Console.WriteLine("La bicicleta esta avanzando");
        }
    }

    class Barco : vehiculo 
    {
        public override void Avanzar()
        {
            Console.WriteLine("El barco esta avanzandoooo");//cada objeto usa su propia version del metodo aunque todo sean tratados como vehiculos
        }
    }

}

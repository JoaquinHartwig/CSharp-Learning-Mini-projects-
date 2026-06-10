using System.Globalization;

namespace Lista_de_Objetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Jugador> jugadores = new List<Jugador>(); // Una lista de tipo jugadores
            
            Jugador jugador4 = new Jugador("Morales");
            jugadores.Add(new Jugador("Beresetegui"));//Va
            jugadores.Add(new Jugador("pepe"));
            jugadores.Add(new Jugador("Lolo"));
            foreach (Jugador jugador in jugadores)

            {
                Console.WriteLine(jugador);
            }
        }
    }
    class Jugador
    {
        public string nombre;

        public Jugador(string nombre)
        {
            this.nombre = nombre;
        }
        public override string ToString() //Metodo ToString 
        {
            return nombre;
        }
    }
}


using System.Globalization;

namespace Pasar_Objeto_como_Argumento
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Auto auto1 = new Auto("Toyota", "Rojo");
            Console.WriteLine("Modelo del auto es:" + auto1.Modelo + " y su color es " + auto1.Color);
          Auto.CambiarColor(auto1, "Azul");//Pasar como argumento el objeto auto1 y el nuevo color "Azul",Para cambiar el color del auto1 a "Azul"
            Console.WriteLine("Modelo del auto es:" + auto1.Modelo + " y su color es " + auto1.Color);


         Auto auto2 = Auto.CopiarAuto(auto1);//Crear un nuevo objeto auto2 utilizando el constructor de copia, pasando auto1 como argumento
            Console.WriteLine("Modelo del auto es:" + auto2.Modelo + " y su color es " + auto2.Color);
        }
    }

    public class Auto
    {
        public string Modelo;
        public string Color;

        public Auto(string modelo, string color)
        {
            Modelo = modelo;
            Color = color;
        }
        public static void CambiarColor(Auto auto, string nuevoColor)
        {
            auto.Color = nuevoColor;
        }
        public static Auto CopiarAuto (Auto autooriginal)
        {
            return new Auto(autooriginal.Modelo, autooriginal.Color);
        }
    }
}

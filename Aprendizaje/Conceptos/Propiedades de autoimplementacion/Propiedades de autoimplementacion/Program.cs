namespace Propiedades_de_autoimplementacion
{
    internal class Program
    {
        static void Main(string[] args)//Son una versión modificada de de los getters y setters

        {
          Auto auto = new Auto();
            auto._Modelo = "Toyota ";
            Console.WriteLine(auto._Modelo);
        }
    }
    class Auto
    {
        string _modelo;
        public string _Modelo { get; set; }
        

       
    }
}

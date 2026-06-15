namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)//Una interfaz es parecida una clase padre...
        {
          conejo conejo = new conejo();//La ventaja q podes heredar mas de una interfaz
            conejo.Huir();
           Halcon halcon = new Halcon();
            halcon.Atacar();
            Pez pez = new Pez();
            pez .Atacar();
            pez.Huir();
        }
    }
    interface IPresa //Siemrpe se pone una I para identificar mas facilmente
    {
        void Huir();//La implementacion es la responabilida de la clase q le hereda
        
    }
    interface IDepredador 
    {
        void Atacar();
    }
    class conejo : IPresa
    {
        public void Huir()
        {
            Console.WriteLine("El conejo huye");
        }

    }
    class Halcon : IDepredador 
    {
        public void Atacar()
        {
            Console.WriteLine("El halcon esta cazando");
        }

    }
    class Pez : IPresa, IDepredador
    {
        public void Huir()
        {
            Console.WriteLine("El pez esta escapando");

        }
        public void Atacar()
        {
            Console.WriteLine("El pez esta buscando otro mas pequeño");
        }
    }
}

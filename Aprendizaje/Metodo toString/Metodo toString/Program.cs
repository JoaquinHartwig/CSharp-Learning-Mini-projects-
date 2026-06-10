



namespace Metodo_ToString
{
    internal class Program
    {
        static void Main(string[] args)//Funcion principal es convertir un objeto en cadena de texto
        {
            auto miAuto = new auto("Chevy", "k47", "2007", "rojo");
            Console.WriteLine(miAuto);
        }
    }
    class auto
    {
        public string _Marca;
        public string _Modelo;
        public string _Año;
        public string _Color;

        public auto(string Marca, string Modelo, string Año, string Color)
        {
            this._Marca= Marca;
            this._Modelo= Modelo;
            this._Año= Año;
            this._Color= Color;
        }

        public override string ToString()
        {
            return $"Este auto es un {_Marca} {_Modelo} del año {_Año} color {_Color}";//Gracias a este metodo puedo mostrar un obejeto como cadena
        }

    }
}

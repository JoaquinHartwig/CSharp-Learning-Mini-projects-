namespace Enumeraciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Planeta:" + Planetas.Tierra);
            Console.WriteLine((int)Planetas.Tierra);
            string nombre = Radio.Tierra.ToString();
            Console.WriteLine(nombre);
            Console.WriteLine((int)Radio.Tierra);
        }
    }
}

enum Planetas
{
    Mercurio = 1,
    Venus = 2,
    Tierra = 3,
    Marte = 4,
    Jupiter = 5,
    Saturno = 6,
    Urano = 7,
    Neptune = 8,

}
enum Radio
{
    Mercurio = 32321,
    Venus = 43432,
    Tierra = 434343,
    Marte = 432364,
    Jupiter = 675453,
    Saturno = 434326,
    Urano = 73333,
    Neptune = 44448,


}
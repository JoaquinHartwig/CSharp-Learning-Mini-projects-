namespace Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<string> comidas = new List<string>();
            comidas.Add("Pizza");
            comidas.Add("Arroz");
            comidas.Add("Pancho");
            
            comidas.Remove(comidas[0]);//Elimina Pizza
            comidas.Insert(0, "Asado");//Recibe dos parametros una es la posicion y otra q es lo  q queremos insertar
            Console.WriteLine(comidas.Count);//Cuenta los elementos de la lista
            Console.WriteLine( comidas.Contains("Papas fritass"));
            comidas.Sort();
            comidas.Reverse();
            comidas.Clear();//vACIA POR COMPLETO LA LISTA
            string[] comidas2 = comidas .ToArray();// convierte la lista en un arreglo  ¿Para q no lo se?
            foreach (string s in comidas)
            {

                Console.WriteLine(s);
            }
        }
    }
}

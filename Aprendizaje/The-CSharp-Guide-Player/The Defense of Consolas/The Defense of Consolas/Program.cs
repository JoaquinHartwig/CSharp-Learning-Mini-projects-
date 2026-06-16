using static System.Net.WebRequestMethods;

namespace The_Defense_of_Consolas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Izquierda = misma fila, columna - 1
            Arriba = fila - 1, misma columna
            Derecha = misma fila, columna + 1
            Abajo = fila + 1, misma columna*/
            Console.Title = "Defence of Consolas";

            Console.WriteLine("What will be your next target? ");
            Console.WriteLine("Target Row");
            int row = int.Parse(Console.ReadLine());
            Console.WriteLine("Target Col");
            int col = int.Parse(Console.ReadLine());
            Console.WriteLine($"Your target is ({ row},{col})" );
            int result1 = col - 1;
            int resul2 = row - 1;
            int result3 = col + 1;
            int resul4 = row + 1;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Deploy to:");
            string Left = ($"({row},{result1})");
            string Up = ($"({resul2},{col})");
            string Rigth = ($"({row},{result3})");
            string Down = ($"({resul4},{col})");

            Console.Beep(440, 1000);
            Console.WriteLine($"{Left} \n {Rigth} \n { Up} \n {Down}");




        }
    }
}

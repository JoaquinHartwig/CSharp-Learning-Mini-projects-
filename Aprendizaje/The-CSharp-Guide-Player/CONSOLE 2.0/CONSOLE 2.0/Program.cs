namespace CONSOLE_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Game Over");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Hola");
            Console.BackgroundColor = ConsoleColor.Blue;
            //Console.Clear();//Limpia toda la pantalla
            Console.Title = "Retro Snake";//permite cambiar el titulo de la ventana
            Console.Beep(1000, 500);//1000 Hz durante 500 ms
        }
    }
}

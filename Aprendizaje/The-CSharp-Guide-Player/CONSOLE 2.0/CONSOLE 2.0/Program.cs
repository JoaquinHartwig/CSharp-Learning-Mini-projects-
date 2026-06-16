namespace CONSOLE_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int score = 0;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Game Over");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Hola");
            Console.BackgroundColor = ConsoleColor.Blue;
            //Console.Clear();//Limpia toda la pantalla
            Console.Title = "Retro Snake";//permite cambiar el titulo de la ventana
            Console.Beep(1000, 500);//1000 Hz durante 500 ms
         
            //Escape Sequences
            Console.WriteLine("Hello\nWorld"); //  \n nueva linea
            Console.WriteLine("Name\tAge"); // \t tabulacion
            Console.WriteLine("He said \"Hello\""); // \"     \"   comillas dentro de una tabulacion
            //$ Strings (String Interpolation)
            Console.WriteLine($"Score: {score}");
            Console.WriteLine("Press any key when you're ready to begin.");
            Console.ReadKey(true);//La tecla presionada no aparece en pantalla (se lee en secretro)
            Console.WriteLine("\"");
            
             */
            //Alignment
            string name1 = Console.ReadLine();
            string name2 = Console.ReadLine();
            string name3 = Console.ReadLine();
            Console.WriteLine($"#1: {name1,20}"); 
            Console.WriteLine($"#2: {name2,20}");
            Console.WriteLine($"#3: {name3,10 }");
        }
    }
}

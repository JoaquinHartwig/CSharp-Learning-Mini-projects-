namespace The_Magic_Cannon
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /*for de 1 a 100

    si múltiplo de 3 y 5
        azul
        imprimir "i: Electric and Fire"

    sino si múltiplo de 3
        rojo
        imprimir "i: Fire"

    sino si múltiplo de 5
        amarillo
        imprimir "i: Electric"

    sino
        color normal
        imprimir "i: Normal"

    volver al color normal*/
           for( int i = 1; i <= 100; i++)
            {

               if (i%3 == 0 && i% 5 ==0) //El orden importa porque if y else if funcionan de arriba hacia abajo y se detienen en la primera condición verdadera.
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"{i} Electric and Fire "); //Cuando tengas varias condiciones que se superponen, siempre preguntá primero por la más específica.
                    Console.ResetColor();

                }
                else if (i % 3 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{i}  Fire ");
                    Console.ResetColor();
                }
                else if (i % 5 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"{i} Electric ");
                    Console.ResetColor();
                }
               else
                {
                    Console.WriteLine($"{i} Normal ");
                    Console.ResetColor();

                }

            }
        }
    }
}

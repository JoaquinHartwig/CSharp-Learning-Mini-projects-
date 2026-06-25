namespace Tuplas
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // (string, int, int) score = ("R2-D2", 12420, 15);
            //DisplayScore(score);
           // DisplayScore(("Joaquin", 3500, 18));
            string[] names = new string[3] { "R2-D2", "C-3PO", "GONK" };
            int[] points = new int[3] { 12420, 8543, -1 };
            int[] level = new int[3] { 15, 9, 1 };
            
            var score1 = ("R2-D2", 12420, 15);
          //  Console.WriteLine($"Name:{score.Item1} Level:{score.Item3} Score:{score.Item2}");
            void DisplayScore((string Name, int Points, int Level) score) //Pero si esos tres datos siempre viajan juntos, es más cómodo agruparlos
            {
                Console.WriteLine(
                $"Name:{score.Name} Level:{score.Level} Score:{score.Points}");
            }
            /*La regla práctica es:

Tupla = datos temporales que viajan juntos.
Clase o struct = entidad del dominio de tu programa.*/
            (string One, int Two, int Three) score2 = GetScore();
            DisplayScore(score2);
            (string N, int P, int L) GetScore() => ("R2-D2", 12420, 15);
            void DisplayScor2e((string Name, int Points, int Level) score)//Firma
            {
                Console.WriteLine(
                $"Name:{score.Name} Level:{score.Level} Score:{score.Points}");
            }
            (int, int) a = (1, 2);
            (int, int) b = (1, 2);
            Console.WriteLine(a == b);
            Console.WriteLine(a != b);
        }
    }
}

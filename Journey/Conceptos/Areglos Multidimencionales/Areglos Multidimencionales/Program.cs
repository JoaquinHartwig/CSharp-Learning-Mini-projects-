namespace Areglos_Multidimencionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] estacionamiento =
                {
                {"Auto1", "Auto2", "Auto3"},
                {"Auto4", "Auto5", "Auto6"},
                {"Auto7", "Auto8", "Auto9"}
            };
            estacionamiento[0, 2] = "Auto10";
            for (int i = 0; i < estacionamiento.GetLength(0); i++) {
                for (int j = 0; j < estacionamiento.GetLength(1); j++) {
                    Console.Write(estacionamiento[i, j]);
                    Console.Write("\t");

                }
                Console.WriteLine();
            }
        }
    }
}

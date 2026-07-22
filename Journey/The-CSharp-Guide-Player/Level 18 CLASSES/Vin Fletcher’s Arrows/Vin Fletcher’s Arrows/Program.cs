namespace Vin_Fletcher_s_Arrows
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose an arrowhead:");
            Console.WriteLine("1 - Steel");
            Console.WriteLine("2 - Wood");
            Console.WriteLine("3 - Obsidian");

            int arrowheadChoice = Convert.ToInt32(Console.ReadLine());
            Arrowhead arrowhead;

            if (arrowheadChoice == 1)
            {
                arrowhead = Arrowhead.Steel;
            }
            else if (arrowheadChoice == 2)
            {
                arrowhead = Arrowhead.Wood;
            }
            else
            {
                arrowhead = Arrowhead.Obsidian;
            }
            Console.WriteLine("Choose the fletching:");
            Console.WriteLine("1 - Plastic");
            Console.WriteLine("2 - Turkey feathers");
            Console.WriteLine("3 - Goose feathers");

            int fletchingChoice = Convert.ToInt32(Console.ReadLine());

            Fletching fletching;

            if (fletchingChoice == 1)
            {
                fletching = Fletching.Plastic;
            }
            else if (fletchingChoice == 2)
            {
                fletching = Fletching.TurkeyFeathers;
            }
            else
            {
                fletching = Fletching.GooseFeathers;
            }
            Console.Write("Enter the arrow length between 60 and 100 cm: ");

            float length = Convert.ToSingle(Console.ReadLine());

            Arrow arrow = new Arrow(arrowhead, fletching, length);
            float cost = arrow.GetCost();
            Console.WriteLine($"The arrow costs {cost} gold.");
        }
    }
}

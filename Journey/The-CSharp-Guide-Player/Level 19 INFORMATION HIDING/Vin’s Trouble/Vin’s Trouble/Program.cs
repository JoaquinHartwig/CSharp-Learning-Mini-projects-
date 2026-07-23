namespace Vin_s_Trouble
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
        enum Arrowhead //Una variable de tipo Arrowhead solo puede tener uno de esos tres valores.
        {


            Steel,
            Wood,
            Obsidian
        }
        enum Fletching
        {
            Plastic,
            TurkeyFeathers,
            GooseFeathers
        }
        class Arrow
        {
            private Arrowhead _arrowhead;
            private Fletching _fletching;
            private float _length;

            public Arrow(Arrowhead arrowhead, Fletching fletching, float length) //Constructor for the Arrow class
            {
                _arrowhead = arrowhead;
                _fletching = fletching;
                _length = length;
            }
            public float GetLength()
            {
                return _length;
            }
            public Arrowhead GetArrowhead()
            {
                return _arrowhead;
            }
            public Fletching GetFletching()
            {
                return _fletching;
            }
            public float GetCost()
            {
                float arrowheadCost = 0;
                float fletchingCost = 0;
                float shaftCost = 0;

                if (_arrowhead == Arrowhead.Steel) // Check the type of arrowhead and assign the corresponding cost
                {
                    arrowheadCost = 10;
                }
                else if (_arrowhead == Arrowhead.Wood)
                {
                    arrowheadCost = 3;
                }
                else if (_arrowhead == Arrowhead.Obsidian)
                {
                    arrowheadCost = 5;
                }

                if (_fletching == Fletching.Plastic)// Check the type of fletching and assign the corresponding cost
                {
                    fletchingCost = 10;
                }
                else if (_fletching == Fletching.TurkeyFeathers)
                {
                    fletchingCost = 5;
                }
                else if (_fletching == Fletching.GooseFeathers)
                {
                    fletchingCost = 3;
                }

                shaftCost = _length * 0.05f;// Calculate the cost of the shaft based on its length

                return arrowheadCost + fletchingCost + shaftCost;// Return the total cost of the arrow
            }
        }

    }

}


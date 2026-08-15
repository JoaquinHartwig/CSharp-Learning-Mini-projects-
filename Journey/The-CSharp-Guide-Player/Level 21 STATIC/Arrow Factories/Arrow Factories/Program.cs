namespace Arrow_Factories
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What type of arrow do you want?");
            Console.WriteLine("1. Elite");
            Console.WriteLine("2. Beginner");
            Console.WriteLine("3. Marksman");
            Console.WriteLine("4. Custom");

            int arrowChoice = Convert.ToInt32(Console.ReadLine());

            switch (arrowChoice)
            {
                case 1:
                    Arrow eliteArrow = Arrow.CreateEliteArrow();
                    Console.WriteLine($"Elite Arrow created. Cost: {eliteArrow.GetCost()}");
                    break;

                case 2:
                    Arrow beginnerArrow = Arrow.CreateBeginnerArrow();
                    Console.WriteLine($"Beginner Arrow created. Cost: {beginnerArrow.GetCost()}");
                    break;

                case 3:
                    Arrow marksmanArrow = Arrow.CreateMarksmanArrow();
                    Console.WriteLine($"Marksman Arrow created. Cost: {marksmanArrow.GetCost()}");
                    break;

                case 4:
                    // Arrowhead
                    Console.WriteLine("Choose an arrowhead:");
                    Console.WriteLine("1. Steel");
                    Console.WriteLine("2. Wood");
                    Console.WriteLine("3. Obsidian");

                    int arrowheadChoice = Convert.ToInt32(Console.ReadLine());

                    Arrowhead arrowhead;

                    switch (arrowheadChoice)
                    {
                        case 1:
                            arrowhead = Arrowhead.Steel;
                            break;

                        case 2:
                            arrowhead = Arrowhead.Wood;
                            break;

                        case 3:
                            arrowhead = Arrowhead.Obsidian;
                            break;

                        default:
                            Console.WriteLine("Invalid arrowhead.");
                            return;
                    }

                    // Fletching
                    Console.WriteLine("Choose a fletching:");
                    Console.WriteLine("1. Plastic");
                    Console.WriteLine("2. Turkey Feathers");
                    Console.WriteLine("3. Goose Feathers");

                    int fletchingChoice = Convert.ToInt32(Console.ReadLine());

                    Fletching fletching;

                    switch (fletchingChoice)
                    {
                        case 1:
                            fletching = Fletching.Plastic;
                            break;

                        case 2:
                            fletching = Fletching.TurkeyFeathers;
                            break;

                        case 3:
                            fletching = Fletching.GooseFeathers;
                            break;

                        default:
                            Console.WriteLine("Invalid fletching.");
                            return;
                    }

                    // Length
                    Console.WriteLine("Enter the arrow length:");
                    float length = Convert.ToSingle(Console.ReadLine());

                    // Create custom arrow
                    Arrow customArrow = new Arrow(arrowhead, fletching, length);

                    Console.WriteLine($"Custom Arrow created. Cost: {customArrow.GetCost()}");
                    break;

                default:
                    Console.WriteLine("Invalid selection.");
                    break;
            }
        }

        enum Arrowhead
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

            public Arrow(Arrowhead arrowhead, Fletching fletching, float length)
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

                if (_arrowhead == Arrowhead.Steel)
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

                if (_fletching == Fletching.Plastic)
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

                float shaftCost = _length * 0.05f;

                return arrowheadCost + fletchingCost + shaftCost;
            }

            // Factory Method
            public static Arrow CreateEliteArrow()
            {
                return new Arrow(
                    Arrowhead.Steel,
                    Fletching.Plastic,
                    95
                );
            }

            // Factory Method
            public static Arrow CreateBeginnerArrow()
            {
                return new Arrow(
                    Arrowhead.Wood,
                    Fletching.GooseFeathers,
                    75
                );
            }

            // Factory Method
            public static Arrow CreateMarksmanArrow()
            {
                return new Arrow(
                    Arrowhead.Steel,
                    Fletching.GooseFeathers,
                    65
                );
            }
        }
    }
}
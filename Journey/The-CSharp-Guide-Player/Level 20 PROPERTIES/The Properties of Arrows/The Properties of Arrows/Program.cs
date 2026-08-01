namespace The_Properties_of_Arrows
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
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
           public float Length
            {
                get => _length;
            }
            public Arrowhead ArrowheadType
            {
                get { return _arrowhead; }
            }

            public Fletching Fletching
            {
                get { return _fletching; }
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


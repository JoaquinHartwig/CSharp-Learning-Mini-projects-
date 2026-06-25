namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Score best = new Score();
            best.name = "Test";
            best.points = 144000;
            best.level = 15;
            if(best.EarnedStar())
            {
                Console.WriteLine("You eaarned a star");
            }
        }
    }
    class Score
    {
        public string name;
        public int points;
        public int level;
        public bool EarnedStar() => (points / level) > 1000;

    }
}

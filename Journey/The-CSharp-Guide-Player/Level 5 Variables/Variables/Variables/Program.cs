namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username; // Declaring a variable
            username = Console.ReadLine(); // Assigning a value to a variable
            Console.WriteLine("Hi " + username); // Retrieving its current value
            string favoriteColor;
            favoriteColor = Console.ReadLine();
            Console.WriteLine("Hi " + favoriteColor);
            //score = "Generic User"; // DOESN'T COMPILE!  The text "Generic User" is a string, but score’s type is int. 
            int a;
            int b;
            a = 5;
            b = 2;
            b = a;
            a = -3;
            int x, y, z;
            int t = 0;  //  you can declare a variable and initialize it on the same line
            x = y = z = 10; // you can assign the same thing to many variables
                            //this is not very common
                            //Console.WriteLine is built to allow it to work with any type
        }

    }
}

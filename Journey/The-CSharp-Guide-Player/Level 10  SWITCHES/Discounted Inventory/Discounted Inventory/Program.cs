namespace Discounted_Inventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*After sorting through Tortuga’s outfitter shop and making it viable again, Tortuga realizes you’ve put him
 back in business. He wants to repay the favor by giving you a 50% discount on anything you buy from
 him, and he wants you to modify your program to reflect that.
 After asking the user for a number, the program should also ask for their name. If the name supplied is
 your name, cut the price in half before reporting it to the user.
 Objectives:
 • Modify your program from before to also ask the user for their name.
 • If their name equals your name, divide the cost in half*/


            Console.WriteLine("Choose yor item");
            Console.WriteLine(" 1 – Rope\r\n2 – Torches\r\n3 – Climbing Equipment\r\n4 – Clean Water\r\n5 – Machete\r\n6 – Canoe\r\n7 – Food Supplies\r\n");
            int item = Convert.ToInt32(Console.ReadLine());
            int price = 0;
            switch (item)
            {
                case 1:
                    Console.WriteLine("This item cost 10 gold");
                    price = 10;
                    break;

                case 2:
                    Console.WriteLine("This item cost 15 gold");
                    price = 15;
                    break;

                case 3:
                    Console.WriteLine("This item cost 25 gold");
                    price = 25;
                    break;

                case 4:
                    Console.WriteLine("This item cost 1 gold");
                    price = 1;
                    break;

                case 5:
                    Console.WriteLine("This item cost 20 gold");
                    price = 20;
                    break;

                case 6:
                    Console.WriteLine("This item cost 200 gold");
                    price = 200;
                    break;

                case 7:
                    Console.WriteLine("This item cost 1 gold");
                    price = 1;
                    break;

                default:
                    Console.WriteLine("Enter a number valid");
                    break;
                    





            }
            string name = "Joaquin";
            Console.WriteLine("Enter your name");
            string Name = Console.ReadLine();
            if (name == Name)
            {
                price = price * 50 / 100;
            }

            Console.WriteLine($"The new price is {price}");

        }
    }
}



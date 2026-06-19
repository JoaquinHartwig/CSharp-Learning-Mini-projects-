namespace Buying_Inventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*The following items are available:
1 – Rope
2 – Torches
3 – Climbing Equipment
4 – Clean Water
5 – Machete
6 – Canoe
7 – Food Supplies
What number do you want to see the price of?
2
Torches cost 15 gold.
You search around the shop and find ledgers that show the following prices for these items: Rope: 10
gold, Torches: 15 gold, Climbing Equipment: 25 gold, Clean Water: 1 gold, Machete: 20 gold, Canoe: 200
gold, Food Supplies: 1 gold.
Objectives:
• Build a program that will show the menu illustrated above.
• Ask the user to enter a number from the menu.
• Using the information above, use a switch (either type) to show the item’s cost.*/


            Console.WriteLine("Choose yor item");
            Console.WriteLine(" 1 – Rope\r\n2 – Torches\r\n3 – Climbing Equipment\r\n4 – Clean Water\r\n5 – Machete\r\n6 – Canoe\r\n7 – Food Supplies\r\n");
            int item = Convert.ToInt32(Console.ReadLine());
            switch (item)
            {
                case 1:
                    Console.WriteLine("This item cost 10 gold");
                    break;

                case 2:
                    Console.WriteLine("This item cost 15 gold");
                    break;

                case 3:
                    Console.WriteLine("This item cost 25 gold");
                    break;

                case 4:
                    Console.WriteLine("This item cost 1 gold");
                    break;

                case 5:
                    Console.WriteLine("This item cost 20 gold");
                    break;

                case 6:
                    Console.WriteLine("This item cost 200 gold");
                    break;

                case 7:
                    Console.WriteLine("This item cost 1 gold");
                    break;

                default:
                    Console.WriteLine("Enter a number valid");
                    break;






            }
        }
    }
}

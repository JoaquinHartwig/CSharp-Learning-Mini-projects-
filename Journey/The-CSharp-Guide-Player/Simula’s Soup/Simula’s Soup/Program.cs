namespace Simula_s_Soup
{
    internal class Program
    {
        static void Main(string[] args)
        {
            food selectedFood;
            ingredients selectedingridients;
            Condiments selectedcondiments;
           (food, ingredients, Condiments) Soap;

            int foodtype = 0;
            int ingriedient = 0;
            int condiment = 0;

            while (true)
            {
                Console.WriteLine("Choose a type:");
                Console.WriteLine("1 - Soup");
                Console.WriteLine("2 - Stew");
                Console.WriteLine("3 - Gumbo");

                foodtype = Convert.ToInt32(Console.ReadLine());

                if (foodtype >= 1 && foodtype <= 3)
                    break;

                Console.WriteLine("Invalid option. Try again.");
            }
            switch (foodtype)
            {
                case 1:
                    selectedFood = food.Soup;
                    break;
                case 2:
                    selectedFood = food.Stew;
                    break;
                case 3:
                    selectedFood = food.Gumbo;
                    break;
                default:
                    selectedFood = food.Soup;
                    break;





            }

            while (true)
            {
                Console.WriteLine("Choose a type:");
                Console.WriteLine("1 - Mushrooms");
                Console.WriteLine("2 - Chicken");
                Console.WriteLine("3 - Carrots");
                Console.WriteLine("4 - Potatoes");


                ingriedient = Convert.ToInt32(Console.ReadLine());

                if (ingriedient >= 1 && ingriedient <= 4)
                    break;

                Console.WriteLine("Invalid option. Try again.");
            }
            switch (ingriedient)
            {
                case 1:
                    selectedingridients = ingredients.Mushrooms;
                    break;
                case 2:
                    selectedingridients = ingredients.Chicken;
                    break;
                case 3:
                    selectedingridients = ingredients.Carrots;
                    break;
                case 4:
                    selectedingridients = ingredients.Potatoes;
                    break;
                default:
                    selectedingridients = ingredients.Potatoes;
                    break;




            }
            while (true)
            {
                Console.WriteLine("Choose a type:");
                Console.WriteLine("1 - Spicy");
                Console.WriteLine("2 - Salty");
                Console.WriteLine("3 - Sweet");

                condiment = Convert.ToInt32(Console.ReadLine());

                if (condiment >= 1 && condiment <= 3)
                    break;

                Console.WriteLine("Invalid option. Try again.");
            }
            switch (condiment)
            {
                case 1:
                    selectedcondiments = Condiments.spicy;
                    break;
                case 2:
                    selectedcondiments = Condiments.salty;
                    break;
                case 3:
                    selectedcondiments = Condiments.sweet;
                    break;
                default:
                    selectedcondiments = Condiments.salty;
                    break;




            }
           var soup = (selectedFood, selectedingridients, selectedcondiments);

            Console.WriteLine();
            Console.WriteLine($"The soup are conformed for {selectedFood} {selectedingridients} {selectedcondiments} ");

        }
    }
}

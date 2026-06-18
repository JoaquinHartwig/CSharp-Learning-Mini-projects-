namespace Watchtower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Objectives:
• Ask the user for an x value and a y value. These are coordinates of
the enemy relative to the watchtower’s location.
• Using the image on the right, if statements, and relational
operators, display a message about what direction the enemy is
coming from. For example, “The enemy is to the northwest!” or
“The enemy is here!”*/
            Console.WriteLine("Enter the value of x");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of y");
            int y = Convert.ToInt32(Console.ReadLine());

            if(x<0 && y > 0)
            {
                Console.WriteLine("The enemy is to NW");

            }
            else if (x == 0 && y > 0)
            {
                Console.WriteLine("The enemy is to N");

            }
            else if (x > 0 && y > 0)
            {
                Console.WriteLine("The enemy is to NE");

            }
            else if (x < 0 && y == 0)
            {
                Console.WriteLine("The enemy is to W");

            }
           else  if (x > 0 && y == 0)
            {
                Console.WriteLine("The enemy is to E");

            }
          else  if (x < 0 && y < 0)
            {
                Console.WriteLine("The enemy is to SW");

            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("The enemy is to NW");

            }
          else  if (x == 0 && y < 0)
            {
                Console.WriteLine("The enemy is to S");

            }
          else  if (x > 0 && y < 0)
            {
                Console.WriteLine("The enemy is to SE");

            }
            else 
            {
                Console.WriteLine("The enemy is here!");
            }

        }
    }
}

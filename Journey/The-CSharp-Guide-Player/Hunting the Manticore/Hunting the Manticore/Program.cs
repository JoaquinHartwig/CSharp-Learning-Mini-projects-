using System.Reflection;
using static System.Net.Mime.MediaTypeNames;

namespace Hunting_the_Manticore
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int ManticoreDistance;
            int HealthManticore = 10;
            int HealthCity = 15;
            int round = 1;
            int Damage = 0;
            int cannonExpected;
            int Player2Distance = 0;
            while (true)
            {
                Console.WriteLine("Player 1 please enter a number 0 to a 100 for the Manticore’s distance from the city");
                ManticoreDistance = Convert.ToInt32(Console.ReadLine());
                if (ManticoreDistance < 1 || ManticoreDistance > 100)
                {
                    Console.WriteLine("PLease enter a valid number");

                }
                else
                {
                    Console.Clear();
                    break;

                }
            }


            while (HealthManticore > 0 && HealthCity > 0)
            {

                Console.WriteLine($"STATUS: \n  Round: {round} \n  City:{HealthCity}/15  \n Manticore:{HealthManticore}/10");
                cannonExpected = GetCannonDamage(round);
                Console.WriteLine($"The cannon is expected to deal {cannonExpected} damage this round.");
                Console.WriteLine("Enter desired cannon range:");
                Player2Distance = Convert.ToInt32(Console.ReadLine());
                Calculationoftheshot(Player2Distance);
                round++;
                if (HealthManticore > 0)
                    HealthCity--;
                

            }
            Verificationofthewinner(HealthCity, HealthManticore);




            int GetCannonDamage(int round)
            {
                if (round % 5 == 0 && round % 3 == 0)
                {
                    //Console.WriteLine("Hyper Ultra Fireball");
                    Damage = 10;
                    return 10;

                }
                else if (round % 5 == 0)
                {
                    //Console.WriteLine("Eletric ball");
                    Console.WriteLine();
                    Damage = 3;
                    return 3;

                }
                else if (round % 3 == 0)
                {
                    //Console.WriteLine("Normal Fireball");
                    Damage = 3;
                    return 3;

                }
                else
                {
                    //Console.WriteLine("Normal Attack");
                    Damage = 1;
                    return 1;
                }






            }
            void Calculationoftheshot(int Player2Distance)
            {

                if (Player2Distance > ManticoreDistance)
                {
                    Console.WriteLine("OVERSHOT");
                }
                else if (Player2Distance < ManticoreDistance)

                {
                    Console.WriteLine("FELL SHORT");
                }
                else

                {
                    Console.WriteLine("DIRECT HIT");
                    HealthManticore -= Damage;
                }


            }

            void Verificationofthewinner(int HealthCity, int HealthManticore)


            {
                if (HealthCity<= 0)

                {
                    Console.WriteLine("Player 1 Winns");
                    return;

                }
                else if (HealthManticore <= 0)
                {
                    {
                        Console.WriteLine("Player 2 Winns");
                        return;
                    }


                }
            }
        }
    }
}

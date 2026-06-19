namespace The_Prototype
{

    internal class Program
    {
       
        static void Main(string[] args)
        {
            int SecretNumber;
          
            while (true)
            {

                Console.WriteLine("User 1: Enter a number between 0 and 100:");
                SecretNumber = Convert.ToInt32(Console.ReadLine());
                if (SecretNumber < 0 || SecretNumber > 100)
                {
                    Console.WriteLine("Enter a number between 0 and 100");
                   

                }
                else
                {

                    Console.Clear();
                    break;


                }
            }
                Console.WriteLine("User 2: Guess the number ");
                while (true)
                {
                    int Number = Convert.ToInt32(Console.ReadLine());
                    if (Number > SecretNumber)
                    {
                        Console.WriteLine($"{Number} is to high");
                    }
                    else if (Number < SecretNumber)
                    {
                        Console.WriteLine($"{Number} is to low");
                    }
                    else 
                    {
                        Console.WriteLine($"You guessed the number!");


                        break;

                    }


                }
            }

        }
    }











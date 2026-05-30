using System.ComponentModel.Design;

namespace Password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your password ");
            string password = Console.ReadLine();
            Console.WriteLine("Enter your password again");
            string confirmPassword = Console.ReadLine();
            if (!password.Equals(string.Empty) && !password.Equals(string.Empty))
            {
                if (password.Equals(confirmPassword))
                {
                    Console.WriteLine("Password is match");
                }
                else if (!password.Equals(confirmPassword))
                {
                    {
                        Console.WriteLine("Passwords do not match");

                    }


                }
                else
                {
                    Console.WriteLine("Please enter a password");
                }




            }
        }
    }
}

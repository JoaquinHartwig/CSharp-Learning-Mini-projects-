namespace Calculadora_Sencilla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("\tCalculadora ");
            Console.WriteLine("------------------------------");
            double num1, num2;
            num1 = 0; num2 = 0;
            Console.WriteLine("Enter the first number");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Choose a option");
            Console.WriteLine("\t+:Sumar");
            Console.WriteLine("\t-:Restar");
            Console.WriteLine("\t*:Multiplicacion");
            Console.WriteLine("\t/:Division");
            Console.WriteLine("\t^:Potencia");
            string option = Console.ReadLine();
            switch (option)
            {
                case "+":
                    Console.WriteLine($"The result of {num1} + {num2} is: {num1 + num2}");
                    break;
                case "-":
                    Console.WriteLine($"The result of {num1} - {num2} is:{num1 - num2}");
                    break;
                case "*":
                    Console.WriteLine($"The result of {num1} * {num2} is:{num1 * num2}");
                    break;
                case "/":
                    Console.WriteLine($"The result of {num1} / {num2} is:{num1 / num2}");
                    break;
                case "^":
                    Console.WriteLine($"The result of {num1} ^ {num2} is:{Math.Pow(num1, num2)}");
                    break;

            }

        }

    }
}

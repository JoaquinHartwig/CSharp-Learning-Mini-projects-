using System.Globalization;

namespace rock_paper_scissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random objecto = new Random();
            bool play = true;
            string playerChoice;
            string computerChoice;

            while (play)
            {
                playerChoice = null;
                computerChoice = null;
                Console.WriteLine("Elige piedra papel o tijera");
                playerChoice = Console.ReadLine().ToUpper();
                while (playerChoice != "PIEDRA" && playerChoice != "PAPEL" && playerChoice != "TIJERA")
                {
                    Console.WriteLine("Opción no válida. Por favor, elige piedra, papel o tijera.");
                    playerChoice = Console.ReadLine().ToUpper();
                }

                  int randomNumber = objecto.Next(1, 4);
                    switch (randomNumber)
                    {
                        case 1: computerChoice = "PIEDRA"; break;

                        case 2: computerChoice = "PAPEL"; break;

                        case 3:
                            computerChoice = "TIJERA"; break;
                    }
                            Console.WriteLine("Jugador " + playerChoice);
                            Console.WriteLine("Computadora " + computerChoice);
                            switch (playerChoice)
                            {
                                case "PIEDRA":
                                    if (computerChoice == "PIEDRA")
                                    {
                                        Console.WriteLine("Empate!");
                                    }
                                    else if (computerChoice == "PAPEL")
                                    {
                                        Console.WriteLine("Computadora gana!");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Jugador gana!");
                                    }
                                    break;
                                case "PAPEL":
                                    if (computerChoice == "PIEDRA")
                                    {
                                        Console.WriteLine("Jugador gana!");
                                    }
                                    else if (computerChoice == "PAPEL")
                                    {
                                        Console.WriteLine("Empate!");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Computadora gana!");
                                    }
                                    break;
                                case "TIJERA":
                                    if (computerChoice == "PIEDRA")
                                    {
                                        Console.WriteLine("Computadora gana!");
                                    }
                                    else if (computerChoice == "PAPEL")
                                    {
                                        Console.WriteLine("Jugador gana!");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Empate!");
                                    }
                                    break;

                                   
                            }
                Console.WriteLine("Desea jugar nuevamente S/N???");
                string playAgain = Console.ReadLine().ToUpper();
                while(!(playAgain == "S" || playAgain == "N"))
                {
                    Console.WriteLine("Opción no válida. Por favor, ingrese S para sí o N para no.");
                    playAgain = Console.ReadLine().ToUpper();
                }
                if (playAgain == "S")
                {
                    play = true;
                }
                else
                {
                    play = false;
                    

                }




            }
            Console.WriteLine("gracias por jugar");
            
        }


        }



    }



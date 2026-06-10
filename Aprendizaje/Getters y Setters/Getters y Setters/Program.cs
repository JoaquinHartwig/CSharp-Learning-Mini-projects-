using System.ComponentModel.Design;

namespace Getters_y_Setters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Auto auto = new Auto(502);
            Console.WriteLine(auto.Velocidad);
        }
    }
    class Auto
    {
        private int _velocidad; // Cambiamos la variable de publico a privado y luego utilizamos propiedades

        public Auto(int velocidad)
        {
            Velocidad = velocidad;
        }
        public int Velocidad
        {
            get
            { return _velocidad; }//Leer
            set//Asignar un valor con validacion
            {
                if (value > 500)
                {
                    _velocidad = 500;
                }
                else if (value < 0)

                {
                    _velocidad = 0;
                }
                else {
                    _velocidad = value;
                        }




                }




            }
        }
    }

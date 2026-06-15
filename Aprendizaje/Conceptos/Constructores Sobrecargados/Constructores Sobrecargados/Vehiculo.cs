using System;
using System.Collections.Generic;
using System.Text;

namespace Constructores_Sobrecargados
{
    internal class Vehiculo //Clase base (Generica)

    {
        public int Velocidad = 0;

        public void Avanzar()
        {
            Console.WriteLine("El vehículo avanza a " + Velocidad + " km/h");
        }
    }
}

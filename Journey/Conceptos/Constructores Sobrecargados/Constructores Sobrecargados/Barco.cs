using System;
using System.Collections.Generic;
using System.Text;

namespace Constructores_Sobrecargados
{
    internal class Barco : Vehiculo //Heredan de Vehiculo, pero no tienen ruedas, por lo que se asigna el valor de 0 a la variable ruedas, para evitar confusiones con los otros tipos de vehículos.
    {
        public int ruedas = 0;
        

    }
}

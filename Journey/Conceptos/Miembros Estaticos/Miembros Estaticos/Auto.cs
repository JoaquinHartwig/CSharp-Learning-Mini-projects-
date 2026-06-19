using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Miembros_Estaticos
{
    internal class Auto
    {
        public static int _numerodeautos = 0;
        public string _marca;
        public Auto(string marca) { 
        this._marca = marca;
        ++_numerodeautos;
        
        
        }

        public static void MostrarNumerodeAutos() {
            Console.WriteLine($"El numero de autos es: {_numerodeautos}");
        }
    }
}

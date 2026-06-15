using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Clases
{
    internal class Auto
    {
       public string  _marca;
        public string _modelo;
        public int _año;
        public string _color;

        public Auto(string marca, string modelo, int año, string color)
        {
            this._marca = marca;
            this._modelo = modelo;
            this._año = año;
            this._color = color;
        }
        public void Arrancar()
        {
            Console.WriteLine($"El auto {_marca} {_modelo} de color {_color} y año {_año} está arrancando  ");
        }

    }
}

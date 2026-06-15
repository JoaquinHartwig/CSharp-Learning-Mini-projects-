using System;
using System.Collections.Generic;
using System.Text;

namespace Clases
{
    internal class Gato
    {
        //Propiedades o atributos: Son las características o datos que describen a un objeto. En el ejemplo, "nombre" y "edad" son propiedades de la clase "Gato". Estas propiedades pueden tener diferentes valores para cada objeto creado a partir de la clase.
        public string _nombre;
        public int _edad;
        //Metodos: Son las acciones o comportamientos que un objeto puede realizar. En el ejemplo, "Comer", "Dormir" y "Jugar" son métodos de la clase "Gato". Estos métodos definen lo que un gato puede hacer, y pueden ser llamados para realizar esas acciones en los objetos de la clase.
        public Gato(string nombre, int edad)//constructor para inicializar las propiedades del gato,Sirve para crear un nuevo objeto de la clase Gato con un nombre y una edad específicos.
        {
            this._nombre = nombre;
            this._edad = edad;
        }   
        
        public void Comer()
        {
            Console.WriteLine($"El {_nombre} está comiendo");
        }
        public void Dormir()
        {
            Console.WriteLine($"El {_nombre} está durmiendo");
        }
        public void Jugar()
        {
            Console.WriteLine($"El {_nombre} está jugando");
        }   
    }
}

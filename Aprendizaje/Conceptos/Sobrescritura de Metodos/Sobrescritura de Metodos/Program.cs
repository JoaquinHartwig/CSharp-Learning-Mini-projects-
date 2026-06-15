namespace Sobrescritura_de_Metodos
{
    internal class Program// Sobrescritura de métodos
    {
        static void Main(string[] args)// Para sobrescribir un método en  C#,hay tres requisitos que se deben cumplir:1. La primera es q debe tener el mismo nombre,2da debe tener los mismos parametros y la 3ra El metodo original debe estar marcado como virtual,abstracto o ser parte de una interfaz, y el metodo sobrescrito debe estar marcado con la palabra clave override
        {
           Perro perro = new Perro();
           Gato gato = new Gato();
           perro.Hablar(); // Salida: El animal hace un sonido (Ahora distintos objetos pueden tener comportamientos diferentes al llamar al mismo método)
            gato.Hablar(); // Salida: El animal hace un sonido

        }
    }
    class Animal {
    public virtual void Hablar()
        {
            Console.WriteLine("El animal hace un sonido");
        }
    }

    class Perro : Animal
    
    {
        public override void Hablar()//Metodo heredado de la clase padre (Animal) y se sobrescribe para proporcionar una implementación específica para la clase Perro
        {
            Console.WriteLine("El perro hace guau"); ; // Llama al método Hablar() de la clase base (Animal)
        }
    }
    class Gato : Animal
    {
      public override void Hablar()
        {
            Console.WriteLine("El gato hace miau"); // Llama al método Hablar() de la clase base (Animal)
        }
    }
}

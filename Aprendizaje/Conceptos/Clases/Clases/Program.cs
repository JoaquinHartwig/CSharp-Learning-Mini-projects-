

namespace Clases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Mensaje mensaje = new Mensaje();//creamos un objeto de la clase mensaje
            mensaje.Saludar();
            mensaje.Esperar();
            mensaje.Adios();
            // Objetos: Son instancias de una clase, es decir, son entidades concretas que se crean a partir de la plantilla definida por la clase. Un objeto tiene un estado (representado por sus atributos) y un comportamiento (representado por sus métodos). En el ejemplo, "mensaje" es un objeto de la clase "Mensaje".
        
           Gato gato1 = new Gato("Michi",3);//creamos un objeto de la clase gato
            
            gato1.Comer();
            gato1.Dormir();

            Gato gato2 = new Gato("Felix", 5); //Gracias a los constructores, podemos crear objetos de la clase Gato con diferentes atributos (nombre y edad) de manera sencilla. Esto nos permite reutilizar la clase para crear múltiples gatos con características distintas sin tener que escribir código adicional para cada uno.

            gato2.Jugar();
            gato2.Dormir();

            Auto auto1 = new Auto("Toyota", "Corolla", 2020,"Rojo"); //creamos un objeto de la clase Auto utilizando el constructor

            auto1.Arrancar();

            Auto auto2 = new Auto("Honda", "Civic", 2018, "Azul"); //Gracias a los constructores, podemos crear objetos de la clase Auto con diferentes atributos (marca, modelo, año y color) de manera sencilla. Esto nos permite reutilizar la clase para crear múltiples autos con características distintas sin tener que escribir código adicional para cada uno.
            //Para cambiae una de las propiedades del auto2, por ejemplo, el color, podemos hacerlo de la siguiente manera:
            auto2._color = "Violeta"; //cambiamos el color del auto2 a violeta
            //Los atributos deben ser públicos para poder acceder a ellos desde fuera de la clase, como en este caso, donde estamos cambiando el color del auto2. Sin embargo, es importante tener en cuenta que en una buena práctica de programación orientada a objetos, los atributos suelen ser privados y se acceden a través de métodos públicos (getters y setters) para mantener el encapsulamiento y proteger la integridad de los datos.
            //Cambiar de esa manera el color del auto2 no es recomendable, ya que rompe el principio de encapsulamiento
        }
    }

    
}

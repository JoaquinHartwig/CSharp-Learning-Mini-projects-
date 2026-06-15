namespace Miembros_Estaticos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Auto auto1 = new Auto("VW");
            Console.WriteLine(Auto._numerodeautos);
            Auto auto2 = new Auto("Ford");
            Console.WriteLine(Auto._numerodeautos);//Como es estatico se va a incrementar el numero de autos cada vez que se cree un nuevo auto, aunque se cree con una marca diferente, el numero de autos va a ser el mismo para todos los objetos de la clase Auto
        }
        //nunmerosdeautos le pertenece a la clase Auto, no a cada objeto de la clase Auto, por eso es estatico, para que se pueda compartir entre todos los objetos de la clase Auto, y se pueda acceder a el sin necesidad de crear un objeto de la clase Auto, como se hace en el metodo MostrarNumerodeAutos() que es estatico, se puede acceder a el sin necesidad de crear un objeto de la clase Auto, y se puede mostrar el numero de autos que hay en total, aunque se hayan creado varios objetos de la clase Auto con diferentes marcas.
    }
    //Esto es parecido como clase Math, que tiene metodos estaticos como Sqrt, Pow, etc, que se pueden acceder sin necesidad de crear un objeto de la clase Math, y se pueden usar para realizar operaciones matematicas sin necesidad de crear un objeto de la clase Math.
}

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //USO
            Auto auto1 = new Auto("Rojo");
            Auto auto2 = new Auto("Azul");
            Console.WriteLine(auto1.Color); // "Rojo"
            Console.WriteLine(auto2.Color); // "Azul"
            // Acceso a datos de instancia (del objeto):

            // Acceso a datos estáticos (de la clase):
            Console.WriteLine(Auto.ContadorAutos); // 2 (se accede mediante el nombre de la Clase, no del objeto
        }
        public class Auto
        {
            // Atributo de INSTANCIA: cada auto tiene su propio color
            public string Color;

            // Atributo ESTÁTICO: pertenece a la clase, cuenta cuántos autos se crearon en total
            public static int ContadorAutos = 0;

            public Auto(string color)
            {
                this.Color = color;
                ContadorAutos++; // Modifica la única variable global de la clase
            }
        }

        

        
       
    }
}

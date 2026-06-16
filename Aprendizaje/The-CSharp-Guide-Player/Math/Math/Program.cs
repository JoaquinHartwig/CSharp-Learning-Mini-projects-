namespace Math
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a; // Declaring the variable a.
            a = 9 - 2; // Assigning a value to a, using some math.
            a = 3 + 3; // Another assignment.
            int b = 3 + 1; // Declaring b and assigning a value to b all at once.
            b = 1 + 2; // Assigning a second value to b.
            int x =( 2 + 5) * 2;//Al poner parentesis cambia el orden de operacion
            Console.WriteLine(x);
            int partialResult = 2 + 5;//Forzamos q 2 + 5 suceda primero
            int result = partialResult * 2;
            double side1 = 4.5;
            double side2 = 3.5 ;
            double height = 1.5;
            double areaOfTrapezoid = (side1 + side2) / 2.0 * height; //Como la multiplicacion y division tienen la misma prescendencia el programa lee de derecha a izquierda
            Console.WriteLine(areaOfTrapezoid);
        }
    }
}

namespace The_Triangle_Farmer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Objectives:
• Write a program that lets you input the triangle’s base size and height.
• Compute the area of a triangle by turning the above equation into code.
• Write the result of the computation.*/
            /*float Base = Convert.ToSingle(Console.ReadLine());
            float height = Convert.ToSingle(Console.ReadLine());
            float Area = (Base * height) / 2;
            Console.WriteLine(Area);
            */
            int a = 5;
            int b = 2;
            int result = a / b;
            Console.WriteLine(result);
            float t = -30;
            float Result = t / 0;
            Console.WriteLine(Result);//Da como valor infinito,pero no da error ya q es punto flotante y no entero

        }
    }
}

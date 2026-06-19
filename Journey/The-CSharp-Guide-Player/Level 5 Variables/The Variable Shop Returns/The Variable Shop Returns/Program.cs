namespace The_Variable_Shop_Returns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char aLetter = '\u0061'; // An 'a'
            Console.WriteLine(aLetter);
            bool itWorked = true;
            itWorked = false;
            //The Variable Shop
            byte Yauny = 222;// → 0 a 255
            short Silvia = -32222;//→ -32.768 a 32.767
            int numero = 3222222; //→ el más común, números enteros
            long NumeroGrande = 9999999999;//→ números enteros muy grandes
            sbyte Gola = -23;//→ como byte pero con negativos
            ushort Penas = 40000;//→ como short pero sin negativos
            uint Unuty = 500000;//→ como int pero sin negativos
            ulong Ubuntu = 32323232;//→ como long pero sin negativos
            float glota = 23000000F;            // → decimal simple precisión
            double Fafa = 323232D;        // → decimal doble precisión
            decimal Dollars = 3232323324M;           //→ decimal de alta precisión(dinero)
            bool Mujer = false;            //→ true o false
            char simple = 'A';          //→ un solo carácter, ej: 'A'
            string presidente = "javier Milei";        //→ texto, ej: "hola"
            Console.WriteLine($"{Yauny} {Silvia} {numero} {NumeroGrande} {Gola} {Penas} {Unuty} {Ubuntu} {glota} {Fafa} {Dollars} {Mujer} {simple} {presidente}");
            // Nuevos valores
            Yauny = 100;
            Silvia = -12000;
            numero = 500;
            NumeroGrande = 123456789;
            Gola = 50;
            Penas = 65000;
            Unuty = 1000000;
            Ubuntu = 999999999;
            glota = 3.14F;
            Fafa = 2.71828;
            Dollars = 9999.99M;
            Mujer = true;
            simple = 'Z';
            presidente = "Lionel Messi";
            Console.WriteLine($"Yauny: {Yauny}");
            Console.WriteLine($"Silvia: {Silvia}");
            Console.WriteLine($"numero: {numero}");
            Console.WriteLine($"NumeroGrande: {NumeroGrande}");
            Console.WriteLine($"Gola: {Gola}");
            Console.WriteLine($"Penas: {Penas}");
            Console.WriteLine($"Unuty: {Unuty}");
            Console.WriteLine($"Ubuntu: {Ubuntu}");
            Console.WriteLine($"glota: {glota}");
            Console.WriteLine($"Fafa: {Fafa}");
            Console.WriteLine($"Dollars: {Dollars}");
            Console.WriteLine($"Mujer: {Mujer}");
            Console.WriteLine($"simple: {simple}");
            Console.WriteLine($"presidente: {presidente}");
        }
    }
}

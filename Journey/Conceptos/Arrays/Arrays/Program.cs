namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of array");
            int size = Convert.ToInt32(Console.ReadLine());
            string[] autos = new string[size];// declaration of an array with 4 elements,new keyword is used to create an array object in memory,the number idicates the size of the array,which is 4 in this case
            for (int i = 0; i < autos.Length; i++)
            {
                Console.WriteLine("Enter the name of a car:");
                autos[i] = Console.ReadLine();
            }
            Console.WriteLine();
            foreach (string auto in autos) // The foreach loop is used to iterate through each element in the autos array, where auto represents the current element being accessed in each iteration
            {
                Console.WriteLine(auto);
            }
        }

    }
}

using System.Drawing;

namespace Integer_types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ulong aVeryBigNumber = 10000000000U; //U signifies that it is unsigned and must be either a uint or ulong
            aVeryBigNumber = 10000000000L;//. L indicates that the literal must be a long or a ulong, depending on the size.
            aVeryBigNumber = 10000000000UL;
            int bigNumber = 1_000_000_000; //underscore remplace a the comma 
        }
    }
}

using System;
using System.Numerics;


namespace code
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger.TryParse(Console.ReadLine(), out BigInteger A);
            BigInteger.TryParse(Console.ReadLine(), out BigInteger B);

            Console.WriteLine($"{A + B}");
            Console.WriteLine($"{A - B}");
            Console.WriteLine($"{A * B}");

        }
    }
}

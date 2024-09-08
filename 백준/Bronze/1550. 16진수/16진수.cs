using System;


namespace code
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine(Int32.Parse(Console.ReadLine(), System.Globalization.NumberStyles.HexNumber));
        }
    }
}
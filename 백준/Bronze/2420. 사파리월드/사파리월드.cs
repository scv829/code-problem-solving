using System;
using System.IO;
using System.Numerics;
using System.Text;

namespace code
{
    class Program
    {
        static void Main(string[] args)
        {

            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
            StringBuilder sb = new StringBuilder();


            BigInteger[] inputs = Array.ConvertAll(sr.ReadLine().Split(' '), BigInteger.Parse);

            BigInteger result = (inputs[0] - inputs[1]);

            sb.Append( result < 0 ? -result : result );

            sw.WriteLine(sb.ToString());

            sr.Close();
            sw.Close();

        }
    }
}

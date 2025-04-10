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

            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StringBuilder sb = new StringBuilder();

            BigInteger[] inputs = Array.ConvertAll(sr.ReadLine().Split(' '), BigInteger.Parse);

            BigInteger quotient = inputs[0] / inputs[1];
            BigInteger remainder = inputs[0] % inputs[1];

            sb.Append($"{quotient}\n{remainder}");

            sw.WriteLine(sb.ToString());

            sw.Close();
            sr.Close();
        }
    }

}
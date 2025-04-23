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

            sb.Append(inputs[0] + inputs[1]);

            sw.WriteLine(sb.ToString());

            sw.Close();
            sr.Close();
        }
    }

}
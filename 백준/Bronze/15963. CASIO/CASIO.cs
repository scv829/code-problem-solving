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

            sb.Append((inputs[0].Equals(inputs[1]) ? 1 : 0));

            sw.Write(sb.ToString());

            sr.Close();
            sw.Close();

        }
    }
}

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

            BigInteger[] sa = Array.ConvertAll(sr.ReadLine().Split(' '), BigInteger.Parse);

            sb.Append($"{(sa[0] > sa[1] ? sa[1] / 2 : sa[0] / 2)}");

            sw.Write(sb.ToString());

            sr.Close();
            sw.Close();

        }
    }
}

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

            int N = int.Parse(sr.ReadLine());

            for (int i = 0; i < N; i++)
            {
                BigInteger[] lines = Array.ConvertAll(sr.ReadLine().Split(' '), BigInteger.Parse);
                sb.AppendLine($"{lines[0] + lines[1]}");
            }

            sw.WriteLine(sb.ToString());
            sw.Close();
            sr.Close();

        }

    }
}
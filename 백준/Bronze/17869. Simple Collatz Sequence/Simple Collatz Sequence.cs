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

            BigInteger N = BigInteger.Parse(sr.ReadLine());
            int count = 0;


            while (true)
            {
                if (N == 1) { sb.Append(count); break; }
                else
                {
                    N = (N % 2 == 0) ? N / 2 : N + 1;
                    count++;
                }
            }

            sw.WriteLine(sb.ToString());

            sr.Close();
            sw.Close();

        }
    }
}
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

            if (inputs[1] == 1) sb.Append("-1");
            else
            {
                BigInteger result = (inputs[0] * inputs[1]) / (inputs[1] - 1);

                if (inputs[0] * inputs[1] % (inputs[1] - 1) != 0)
                {
                    result += 1;
                }

                sb.Append(result);
            }

            sw.WriteLine(sb.ToString());

            sr.Close();
            sw.Close();

        }
    }
}
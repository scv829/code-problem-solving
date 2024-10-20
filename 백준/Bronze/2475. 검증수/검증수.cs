using System;
using System.IO;
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

            int[] input = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);
            double result = 0;

            for (int i = 0; i < input.Length; i++)
            {
                result += Math.Pow(input[i], 2);
            }

            sb.Append(result % 10);

            sw.Write(sb.ToString());

            sr.Close();
            sw.Close();

        }
    }
}

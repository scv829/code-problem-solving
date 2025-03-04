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

            int T = int.Parse(sr.ReadLine());

            int result = 0;

            for (int i = 0; i < T; i++)
            {
                int[] inputs = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);

                for (int j = 0; j < inputs[0]; j++)
                {
                    double[] doubles = Array.ConvertAll(sr.ReadLine().Split(' '), double.Parse);

                    if (doubles[0] * (doubles[1] / doubles[2]) >= inputs[1]) result++;
                }

                sb.AppendLine($"{result}");
                result = 0;
            }

            sw.Write(sb.ToString());

            sr.Close();
            sw.Close();
        }
    }
}
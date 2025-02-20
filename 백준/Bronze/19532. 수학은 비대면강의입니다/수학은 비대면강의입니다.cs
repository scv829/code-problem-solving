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

            int[] inputs = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);

            for (int i = -999; i <= 999; i++)
            {
                for (int j = -999; j <= 999; j++)
                {
                    if (inputs[0] * i + inputs[1] * j == inputs[2] && inputs[3] * i + inputs[4] * j == inputs[5])
                    {
                        sb.Append($"{i} {j}");
                        break;
                    }
                }
            }

            sw.WriteLine(sb.ToString());
            sr.Close();
            sw.Close();
        }
    }
}
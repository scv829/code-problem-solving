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

            while (true)
            {
                int[] inputs = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);

                if (inputs[0] == 0 && inputs[1] == 0 && inputs[2] == 0) break;

                if (inputs[0] - inputs[1] == inputs[1] - inputs[2])
                {
                    int a = inputs[1] - inputs[0];
                    sb.AppendLine($"AP {inputs[2] + a}");
                }
                else
                {
                    int s = inputs[1] / inputs[0];
                    sb.AppendLine($"GP {inputs[2] * s}");
                }
            }

            sw.WriteLine(sb.ToString());

            sr.Close();
            sw.Close();

        }
    }
}
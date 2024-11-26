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

            float[] inputs = Array.ConvertAll(sr.ReadLine().Split(' '), float.Parse);

            sb.AppendLine($"{( ((inputs[0] - (inputs[0] * (inputs[1] / 100f))) >= 100) ? 0 : 1  )}");

            sw.Write(sb.ToString());

            sr.Close();
            sw.Close();

        }
    }
}

using System;
using System.IO;
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

            int[] inputs = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);

            int result = (inputs[2] - inputs[1] - 1) / (inputs[0] - inputs[1]) + 1;

            sb.AppendLine($"{result}");

            sw.WriteLine(sb.ToString());

            sw.Close();
            sr.Close();
        }

    }
}
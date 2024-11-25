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

            int result = (inputs[0] * 56) + (inputs[1] * 24) + (inputs[2] * 14) + (inputs[3] * 6);

            sb.AppendLine($"{result}");

            sw.Write(sb.ToString());

            sr.Close();
            sw.Close();

        }
    }
}

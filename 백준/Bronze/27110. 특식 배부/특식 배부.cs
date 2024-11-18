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

            int N = int.Parse(sr.ReadLine());

            int[] inputs = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);

            sb.Append(Math.Min(inputs[0], N) + Math.Min(inputs[1], N) + Math.Min(inputs[2], N));

            sw.Write(sb.ToString());

            sr.Close();
            sw.Close();

        }
    }
}
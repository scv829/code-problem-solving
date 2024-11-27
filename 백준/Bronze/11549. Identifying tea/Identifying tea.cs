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

            int[] inputs = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);

            int result = 0;

            foreach (int i in inputs) { if (T == i) result++; }

            sb.AppendLine($"{result}");

            sw.Write(sb.ToString());

            sr.Close();
            sw.Close();

        }
    }
}
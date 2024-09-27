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

            for (int i = 0; i < N; i++)
            {
                int[] line = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);

                sb.AppendLine($"{ ( (line[0] >= line[1]) ? "MMM BRAINS" : "NO BRAINS")}");
            }

            sw.WriteLine(sb.ToString());

            sr.Close();
            sw.Close();

        }
    }
}

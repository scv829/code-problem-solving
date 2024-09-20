using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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

            List<(int, string)> inputs = new List<(int, string)>();

            int N = int.Parse(sr.ReadLine());

            for (int i = 0; i < N; i++)
            {
                string[] line = sr.ReadLine().Split(' ');
                inputs.Add((int.Parse(line[1]), line[0]));
            }

            inputs.Sort();

            sb.AppendLine($"{inputs.First().Item2}");

            sw.Write(sb.ToString());
            sw.Close();
            sr.Close();
        }
    }
}

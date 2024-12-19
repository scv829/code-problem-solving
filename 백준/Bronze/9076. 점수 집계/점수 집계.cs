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

            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
            StringBuilder sb = new StringBuilder();

            int T = int.Parse(sr.ReadLine());

            for(int i = 0; i < T; i++)
            {
                List<int> inputs = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse).ToList();
                inputs.Sort();
                sb.AppendLine($"{(inputs[3] - inputs[1] < 4 ? $"{inputs[1] + inputs[2] + inputs[3]}" : "KIN")}");
            }

            sw.WriteLine(sb.ToString());

            sr.Close();
            sw.Close();

        }
    }
}

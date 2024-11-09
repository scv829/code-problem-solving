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

            int N = int.Parse(sr.ReadLine());
            List<(int, int)> list = new List<(int, int)>();

            for (int i = 0; i < N; i++) 
            { 
                int[] input = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);

                list.Add((input[0], input[1]));
            }

            list.Sort();

            foreach ((int, int) output in list.OrderBy(s => s.Item2)) { sb.AppendLine($"{output.Item1} {output.Item2}"); }

            sw.Write(sb.ToString());

            sr.Close();
            sw.Close();

        }
    }
}

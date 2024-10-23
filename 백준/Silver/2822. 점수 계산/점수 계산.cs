using System;
using System.Collections.Generic;
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

            List<(int, int)> input = new List<(int, int)>();
            List<int> rank = new List<int>();
            int result = 0;

            for (int i = 0; i < 8; i++)
            {
                input.Add((int.Parse(sr.ReadLine()), (i + 1)));
            }

            input.Sort();

            input.RemoveAt(0);
            input.RemoveAt(0);
            input.RemoveAt(0);

            for (int i = 0; i < input.Count; i++)
            {
                result += input[i].Item1;
                rank.Add(input[i].Item2);
            }

            sb.AppendLine($"{result}");

            rank.Sort();

            for (int i = 0; i < rank.Count; i++)
            {
                sb.Append($"{rank[i]} ");
            }

            sw.Write(sb.ToString());

            sr.Close();
            sw.Close();

        }
    }
}

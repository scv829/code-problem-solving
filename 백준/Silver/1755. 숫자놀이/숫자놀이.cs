using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace code
{
    class Program
    {
        enum Number { zero, one, two, three, four, five, six, seven, eight, nine }

        static void Main(string[] args)
        {

            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
            StringBuilder sb = new StringBuilder();

            string[] inputs = sr.ReadLine().Split(' ');

            int M = int.Parse(inputs[0]);
            int N = int.Parse(inputs[1]);

            List<(string, int)> result = new List<(string, int)>();

            for (int num = M; num <= N; num++)
            {
                if (num > 9)
                {
                    sb.Append($"{(Number)(num / 10)}{(Number)(num % 10)}");
                }
                else
                {
                    sb.Append($"{(Number)(num)}");
                }
                result.Add((sb.ToString(), num));
                sb.Clear();
            }

            result.Sort();

            for (int i = 1; i <= result.Count; i++)
            {
                sb.Append($"{result[i - 1].Item2} ");
                if (i % 10 == 0) sb.Append("\n");
            }

            sw.Write(sb.ToString());

            sr.Close();
            sw.Close();

        }
    }
}

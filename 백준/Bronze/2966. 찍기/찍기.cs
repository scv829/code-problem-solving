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

            // 상근 : A B C
            char[] adrian = new char[3] { 'A', 'B', 'C' };
            // 창영 : B A B C
            char[] bruno = new char[4] { 'B', 'A', 'B', 'C' };
            // 현진 : C C A A B B
            char[] goran = new char[6] { 'C', 'C', 'A', 'A', 'B', 'B' };

            int[] counts = new int[3];

            int N = int.Parse(sr.ReadLine());

            string input = sr.ReadLine();

            for (int i = 0; i < N; i++)
            {
                if (adrian[i % 3].Equals(input[i])) counts[0]++;
                if (bruno[i % 4].Equals(input[i])) counts[1]++;
                if (goran[i % 6].Equals(input[i])) counts[2]++;
            }

            List<(int, string)> result = new List<(int, string)>(3);

            result.Add((counts[0], "Adrian"));
            result.Add((counts[1], "Bruno"));
            result.Add((counts[2], "Goran"));

            List<string> winner = new List<string>();

            result.Sort();

            sb.AppendLine($"{result[2].Item1}");
            winner.Add(result[2].Item2);

            if (result[1].Item1.Equals(result[2].Item1))
            {
                winner.Add(result[1].Item2);
            }

            if (result[0].Item1.Equals(result[2].Item1)) winner.Add(result[0].Item2);

            winner.Sort();

            foreach (string s in winner) sb.AppendLine(s);

            sw.Write(sb.ToString());

            sr.Close();
            sw.Close();

        }
    }
}
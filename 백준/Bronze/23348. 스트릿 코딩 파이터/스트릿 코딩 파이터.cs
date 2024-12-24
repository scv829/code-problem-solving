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

            int[] rate = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);
            int N = int.Parse(sr.ReadLine());

            List<int> result = new List<int>();
            int score;

            for(int i = 0; i < N; i++)
            {
                score = 0;
                for(int j = 0; j < 3; j++)
                {
                    int[] skill = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);
                    score += skill[0] * rate[0] + skill[1] * rate[1] + skill[2] * rate[2];
                }
                result.Add(score);
            }

            sb.Append(result.Max());

            sw.WriteLine(sb.ToString());

            sr.Close();
            sw.Close();

        }
    }
}

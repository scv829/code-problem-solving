using System;
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

            int[] inputs = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);
            int[] values;

            int N = inputs[0];
            int K = inputs[1];
            int L = inputs[2];

            int count = 0;

            for (int i = 0; i < N; i++)
            {
                values = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);

                if (values.Count(x => x >= L) == 3 && values.Sum() >= K)
                {
                    count += 1;
                    sb.Append($"{values[0]} {values[1]} {values[2]} ");
                }
            }

            sw.WriteLine(count);
            sw.WriteLine(sb.ToString());

            sr.Close();
            sw.Close();

        }
    }
}
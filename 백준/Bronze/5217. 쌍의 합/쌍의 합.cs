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
                int num = int.Parse(sr.ReadLine());

                sb.Append($"Pairs for {num}:");

                for (int index = 1; index < num; index++)
                {
                    int pair = num - index;
                    if (pair <= index) break;

                    if (index != 1) sb.Append(",");
                    sb.Append($" {index} {pair}");

                }

                sb.Append('\n');
            }

            sw.WriteLine(sb.ToString());

            sr.Close();
            sw.Close();

        }
    }
}

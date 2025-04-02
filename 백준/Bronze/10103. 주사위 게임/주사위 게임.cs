using System;
using System.IO;
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

            int N = int.Parse(sr.ReadLine());
            int[] inputs;
            int[] result = new int[2] { 100, 100 };

            for (int i = 0; i < N; i++)
            {
                inputs = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);

                if (inputs[0] > inputs[1])
                {
                    result[1] -= inputs[0];
                }
                else if (inputs[0] < inputs[1])
                {
                    result[0] -= inputs[1];
                }
            }

            sb.AppendLine($"{result[0]}");
            sb.AppendLine($"{result[1]}");

            sw.WriteLine(sb.ToString());

            sw.Close();
            sr.Close();
        }
    }
}
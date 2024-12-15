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
            StringBuilder input = new StringBuilder();

            int N = int.Parse(sr.ReadLine());

            for (int i = 0; i < N; i++)
            {
                input.Clear();
                input.Append(sr.ReadLine());
                sb.AppendLine((input.ToString()[input.Length - 1] % 2 == 0) ? "even" : "odd");
            }


            sw.WriteLine(sb.ToString());

            sr.Close();
            sw.Close();

        }
    }
}

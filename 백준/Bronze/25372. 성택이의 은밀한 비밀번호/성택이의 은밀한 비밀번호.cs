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
                string line = sr.ReadLine();
                sb.AppendLine((6 <= line.Length && line.Length <= 9) ? "yes" : "no");
            }


            sw.Write(sb.ToString());

            sr.Close();
            sw.Close();

        }
    }
}

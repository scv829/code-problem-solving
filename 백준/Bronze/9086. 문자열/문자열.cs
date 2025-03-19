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

            int n = int.Parse(sr.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string s = sr.ReadLine();

                if (s.Length > 1) sb.Append($"{s[0]}{s[s.Length - 1]}");
                else sb.Append($"{s[0]}{s[0]}");

                sb.AppendLine();
            }

            sw.WriteLine(sb.ToString());

            sw.Close();
            sr.Close();
        }

    }
}
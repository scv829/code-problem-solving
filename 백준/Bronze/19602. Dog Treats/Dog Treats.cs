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
            StringBuilder line = new StringBuilder();

            int S = int.Parse(sr.ReadLine());
            int M = int.Parse(sr.ReadLine());
            int L = int.Parse(sr.ReadLine());

            sb.Append((S + (2 * M) + (3 * L) ) >= 10 ? "happy" : "sad");

            sw.WriteLine(sb.ToString());

            sr.Close();
            sw.Close();

        }
    }
}

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

            int a = int.Parse(sr.ReadLine());
            int b = int.Parse(sr.ReadLine());

            if (3 <= a && b <= 4) sb.AppendLine("TroyMartian");
            if (a <= 6 && 2 <= b) sb.AppendLine("VladSaturnian");
            if (a <= 2 && b <= 3) sb.AppendLine("GraemeMercurian");

            sw.WriteLine(sb.ToString());

            sr.Close();
            sw.Close();

        }
    }
}
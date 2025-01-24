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

            int n = int.Parse(sr.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = sr.ReadLine();

                int g = input.Count(x => x.Equals('g') || x.Equals('G'));
                int b = input.Count(x => x.Equals('b') || x.Equals('B'));

                sb.AppendLine($"{input} is { (g.Equals(b) ? "NEUTRAL" : ((g > b) ? "GOOD" : "A BADDY") )}");
            }

            sw.WriteLine(sb.ToString());

            sr.Close();
            sw.Close();

        }
    }
}
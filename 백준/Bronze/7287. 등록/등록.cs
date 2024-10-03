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

            sb.AppendLine($"149");
            sb.Append($"scv829");

            sw.WriteLine(sb.ToString());

            sr.Close();
            sw.Close();

        }
    }
}

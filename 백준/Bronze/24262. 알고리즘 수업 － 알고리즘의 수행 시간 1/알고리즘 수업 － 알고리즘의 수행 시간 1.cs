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

            sb.AppendLine($"{1}");
            sb.AppendLine($"{0}");

            sw.WriteLine(sb.ToString());

            sw.Close();
            sr.Close();
        }
    }
}
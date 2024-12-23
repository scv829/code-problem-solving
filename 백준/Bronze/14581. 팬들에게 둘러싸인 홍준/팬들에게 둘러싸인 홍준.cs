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

            sb.AppendLine(":fan::fan::fan:");
            sb.AppendLine($":fan::{sr.ReadLine()}::fan:");
            sb.AppendLine(":fan::fan::fan:");

            sw.WriteLine(sb.ToString());

            sr.Close();
            sw.Close();

        }
    }
}

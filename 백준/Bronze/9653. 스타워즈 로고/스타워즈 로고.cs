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

            sb.AppendLine("    8888888888  888    88888");
            sb.AppendLine("   88     88   88 88   88  88");
            sb.AppendLine("    8888  88  88   88  88888");
            sb.AppendLine("       88 88 888888888 88   88");
            sb.AppendLine("88888888  88 88     88 88    888888\n");
            sb.AppendLine("88  88  88   888    88888    888888");
            sb.AppendLine("88  88  88  88 88   88  88  88");
            sb.AppendLine("88 8888 88 88   88  88888    8888");
            sb.AppendLine(" 888  888 888888888 88  88      88");
            sb.AppendLine("  88  88  88     88 88   88888888");

            sw.WriteLine(sb.ToString());

            sr.Close();
            sw.Close();

        }
    }
}

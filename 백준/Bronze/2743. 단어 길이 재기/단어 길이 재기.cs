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

            sb.AppendLine($"{sr.ReadLine().Length}");

            sw.Write(sb.ToString());

            sr.Close();
            sw.Close();

        }
    }
}

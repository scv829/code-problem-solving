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

            int result = 0;

            for (int i = 0; i < 5; i++) result += int.Parse(sr.ReadLine());

            sb.AppendLine($"{result}");

            sw.WriteLine(sb.ToString());

            sr.Close();
            sw.Close();

        }
    }
}

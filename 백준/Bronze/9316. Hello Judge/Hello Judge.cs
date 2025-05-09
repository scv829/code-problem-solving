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

            int input = int.Parse(sr.ReadLine());

            for (int i = 1; i <= input; i++)
            {
                sb.AppendLine($"Hello World, Judge {i}!");
            }

            sw.Write(sb.ToString());

            sr.Close();
            sw.Close();

        }
    }
}

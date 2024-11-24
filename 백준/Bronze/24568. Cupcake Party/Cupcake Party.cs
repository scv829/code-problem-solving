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


            int R = int.Parse(sr.ReadLine());
            int S = int.Parse(sr.ReadLine());

            int result = (R * 8) + (S * 3) - 28;

            sb.AppendLine($"{result}");

            sw.Write(sb.ToString());

            sr.Close();
            sw.Close();

        }
    }
}

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

            int N = int.Parse(sr.ReadLine());

            sb.Append($"{2024 + ( (7 * N) / 12 )} { 1 + (7 * N) % 12}");

            sw.WriteLine(sb.ToString());

            sw.Close();
            sr.Close();
        }
    }

}
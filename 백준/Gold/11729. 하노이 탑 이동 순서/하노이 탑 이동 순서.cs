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

            int input = int.Parse(sr.ReadLine());

            sb.AppendLine($"{Math.Pow(2, input) - 1}");

            Hano(1, 3, input, sb);

            sw.WriteLine(sb.ToString());

            sw.Close();
            sr.Close();
        }
        static void Hano(int a, int b, int n, StringBuilder sb)
        {
            if (n == 1)
            {
                sb.AppendLine($"{a} {b}");
                return;
            }
            Hano(a, 6 - a - b, n - 1, sb);
            sb.AppendLine($"{a} {b}");
            Hano(6 - a - b, b, n - 1, sb);
        }
    }
}

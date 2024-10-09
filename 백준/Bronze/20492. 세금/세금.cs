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

            double N = double.Parse(sr.ReadLine());

            double num1 = N * 0.78;
            double num2 = (N * 0.8) + (N * 0.2 * 0.78);

            sb.Append($"{num1} {num2}");

            sw.Write(sb.ToString());

            sr.Close();
            sw.Close();

        }
    }
}

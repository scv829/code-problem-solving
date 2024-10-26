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

            int A = int.Parse(sr.ReadLine());
            int B = int.Parse(sr.ReadLine());

            int C = B + (B - A);

            sb.Append(C);

            sw.Write(sb.ToString());

            sr.Close();
            sw.Close();

        }
    }
}
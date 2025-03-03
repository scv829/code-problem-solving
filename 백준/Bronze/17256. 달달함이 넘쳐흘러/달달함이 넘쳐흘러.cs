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

            int[] a = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);
            int[] c = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);

            sb.Append($"{c[0] - a[2]} {c[1] / a[1]} {c[2] - a[0]}");

            sw.Write(sb.ToString());

            sr.Close();
            sw.Close();
        }
    }
}
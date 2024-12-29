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
            StringBuilder line = new StringBuilder();

            int a = int.Parse(sr.ReadLine());
            int b = int.Parse(sr.ReadLine());
            int c = int.Parse(sr.ReadLine());

            if (!(a + b + c).Equals(180)) sb.Append("Error");
            else if (a.Equals(60) && b.Equals(60) && c.Equals(60)) sb.Append("Equilateral");
            else if (a.Equals(b) || b.Equals(c) || c.Equals(a)) sb.Append("Isosceles");
            else sb.Append("Scalene");

            sw.WriteLine(sb.ToString());

            sr.Close();
            sw.Close();

        }
    }
}

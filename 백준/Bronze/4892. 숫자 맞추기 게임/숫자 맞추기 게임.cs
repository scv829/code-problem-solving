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

            int count = 1;

            while(true)
            {
                int n0 = int.Parse(sr.ReadLine());

                if (n0 == 0) break;

                int n1 = n0 * 3;
                int n2 = (n1 % 2 == 0) ? n1 / 2 : (n1+1) / 2;
                int n3 = n2 * 3;
                int n4 = n3 / 9;

                sb.AppendLine($"{count++}. {((n1 % 2 == 0) ? "even" : "odd")} {n4}");
            }

            sw.WriteLine(sb.ToString());

            sr.Close();
            sw.Close();

        }
    }
}

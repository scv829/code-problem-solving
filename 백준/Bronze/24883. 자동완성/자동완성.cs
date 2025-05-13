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

            sb.Append((sr.ReadLine().Equals("n", StringComparison.OrdinalIgnoreCase)) ? "Naver D2" : "Naver Whale");

            sw.WriteLine(sb.ToString());

            sw.Close();
            sr.Close();
        }

    }
}

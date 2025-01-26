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

            int n = int.Parse(sr.ReadLine());

            int youngCarlos = int.Parse(sr.ReadLine());

            sb.Append("S");

            for (int i = 1; i < n; i++)
            {
                if (youngCarlos < int.Parse(sr.ReadLine()))
                {
                    sb.Clear();
                    sb.Append('N');
                    break;
                }
            }

            sw.WriteLine(sb.ToString());

            sr.Close();
            sw.Close();

        }
    }
}
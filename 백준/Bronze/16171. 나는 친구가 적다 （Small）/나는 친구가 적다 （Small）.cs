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
            string input = sr.ReadLine();

            for (int i = 0; i < 10; i++)
            {
                input = input.Replace(i.ToString(), "");
            }

            string find = sr.ReadLine();

            sb.AppendLine((input.Contains(find) ? "1": "0"));

            sw.WriteLine(sb.ToString());

            sr.Close();
            sw.Close();

        }
    }
}
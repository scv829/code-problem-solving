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

            string line = sr.ReadLine();

            string result = "";

            while (line.Length % 3 != 0)
            {
                line = "0" + line;
            }

            for (int i = 0; i < line.Length - 1; i += 3)
            {
                int n1 = line[i] - '0';
                int n2 = line[i + 1] - '0';
                int n3 = line[i + 2] - '0';

                result += ((n1 * 4) + (n2 * 2) + n3).ToString();
            }

            sb.AppendLine(result);

            sw.Write(sb.ToString());

            sr.Close();
            sw.Close();
        }
    }
}
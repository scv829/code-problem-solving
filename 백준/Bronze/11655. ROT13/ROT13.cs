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

            foreach(char c in line)
            {
                if('A' <= c && c <= 'Z')
                {
                    int n = ((c - 'A' + 13) % 26);
                    sb.Append((char)(n + 'A'));
                }
                else if('a' <= c && c <= 'z')
                {
                    int n = ((c - 'a' + 13) % 26);
                    sb.Append((char)(n + 'a'));
                }
                else
                {
                    sb.Append(c);
                }
            }

            sw.Write(sb.ToString());

            sr.Close();
            sw.Close();
        }
    }
}
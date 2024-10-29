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

            foreach (char c in input) 
            { 
                // 65 , 97
                if('A' <= c && c <= 'Z') sb.Append((char)((c - 'A') + 'a'));
                else sb.Append((char)((c - 'a') + 'A'));
            }

            sw.Write(sb.ToString());

            sr.Close();
            sw.Close();

        }
    }
}
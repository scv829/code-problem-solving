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

            int S = int.Parse(sr.ReadLine());



            for (int i = 0; i < S; i++)
            {
                string line = sr.ReadLine();
                int consonants = 0;
                int vowels = 0;

                foreach (char c in line)
                {
                    if (c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U' ||
                       c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u') vowels++;
                    else if(c != ' ') consonants++;
                }

                sb.AppendLine($"{consonants} {vowels}");
            }

            sw.Write(sb.ToString());

            sw.Close();
            sr.Close();

        }
    }
}
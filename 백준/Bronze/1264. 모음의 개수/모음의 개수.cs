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


            while (true)
            {
                string line = sr.ReadLine();
                int count = 0;
                if (line == "#") break;
                else
                {
                    foreach (char c in line)
                    {
                        if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' ||
                            c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
                        {
                            count++;
                        }
                    }

                    sb.AppendLine($"{count}");
                }
            }

            sw.Write(sb.ToString());

            sw.Close();
            sr.Close();

        }
    }
}
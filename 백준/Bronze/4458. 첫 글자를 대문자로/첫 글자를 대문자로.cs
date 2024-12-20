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

            int N = int.Parse(sr.ReadLine());

            for (int i = 0; i < N; i++)
            {
                char[] input = sr.ReadLine().ToCharArray();
                for (int j = 0; j < input.Length; j++)
                {
                    if (97 <= input[j] && input[j] <= 122)
                    {
                        input[j] = input[j].ToString().ToUpper()[0];
                        break;
                    }
                    else if (65 <= input[j] && input[j] <= 90) break;

                }
                sb.AppendLine(new string(input));
            }

            sw.WriteLine(sb.ToString());

            sr.Close();
            sw.Close();

        }
    }
}
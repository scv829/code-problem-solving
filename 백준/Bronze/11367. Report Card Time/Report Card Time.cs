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

            int N = int.Parse(sr.ReadLine());

            for (int i = 0; i < N; i++)
            {
                string[] line = sr.ReadLine().Split(' ');
                sb.AppendLine($"{line[0]} {CheckGrade(int.Parse(line[1]))}");
            }

            sw.Write(sb.ToString());

            sw.Close();
            sr.Close();

        }

        static string CheckGrade(int score)
        {
            if (97 <= score) return "A+";
            else if (90 <= score && score <= 96) return "A";
            else if (87 <= score && score <= 89) return "B+";
            else if (80 <= score && score <= 86) return "B";
            else if (77 <= score && score <= 79) return "C+";
            else if (70 <= score && score <= 76) return "C";
            else if (67 <= score && score <= 69) return "D+";
            else if (60 <= score && score <= 66) return "D";
            else return "F";
        }
    }
}
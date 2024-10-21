using System;
using System.Collections.Generic;
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

            Dictionary<string, string> grade = new Dictionary<string, string>();
            grade.Add("A+", "4.3"); grade.Add("A0", "4.0"); grade.Add("A-", "3.7");
            grade.Add("B+", "3.3"); grade.Add("B0", "3.0"); grade.Add("B-", "2.7");
            grade.Add("C+", "2.3"); grade.Add("C0", "2.0"); grade.Add("C-", "1.7");
            grade.Add("D+", "1.3"); grade.Add("D0", "1.0"); grade.Add("D-", "0.7");
            grade.Add("F", "0.0");

            string input = sr.ReadLine();

            sb.AppendLine(grade[input]);

            sw.Write(sb.ToString());

            sr.Close();
            sw.Close();

        }
    }
}

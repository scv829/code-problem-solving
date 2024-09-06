using System;
using System.IO;
using System.Linq;
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
                string[] lines = sr.ReadLine().Split(' ');
                foreach (string s in lines)
                {
                    sb.Append($"{new string(s.Reverse().ToArray())} ");
                }
                sb.AppendLine();
            }

            sw.WriteLine(sb.ToString());
            sw.Close();
            sr.Close();

        }

    }
}
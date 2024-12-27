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
            StringBuilder line = new StringBuilder();

            int T = int.Parse(sr.ReadLine());

            for(int i = 0; i < T; i++)
            {
                string[] inputs = sr.ReadLine().Split(' ');
                int p = int.Parse(inputs[0]);
                foreach(char c in inputs[1])
                {
                    for(int j = 0; j < p; j++) { line.Append(c); }

                }
                sb.AppendLine(line.ToString());
                line.Clear();
            }

            sw.WriteLine(sb.ToString());

            sr.Close();
            sw.Close();

        }
    }
}

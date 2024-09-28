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


            while(true)
            {
                int[] line = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);

                if (line[0] == 0 && line[1] == 0) break;

                sb.AppendLine($"{ ( (line[0] > line[1]) ? "Yes" : "No")}");
            }

            sw.WriteLine(sb.ToString());

            sr.Close();
            sw.Close();

        }
    }
}

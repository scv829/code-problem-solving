using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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

            while (true)
            {
                List<int> line = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse).ToList();

                if (line[0].Equals(0) &&
                    line[1].Equals(0) &&
                    line[2].Equals(0)) break;

                line.Sort();

                if (line[2] >= line[0] + line[1]) sb.AppendLine("Invalid");
                else if (line[0].Equals(line[1]) &&
                    line[1].Equals(line[2]) &&
                    line[2].Equals(line[0])) sb.AppendLine("Equilateral");
                else if (!line[0].Equals(line[1]) &&
                    !line[1].Equals(line[2]) &&
                    !line[2].Equals(line[0])) sb.AppendLine("Scalene");
                else sb.AppendLine("Isosceles");
            }

            sw.Write(sb.ToString());

            sr.Close();
            sw.Close();

        }
    }
}

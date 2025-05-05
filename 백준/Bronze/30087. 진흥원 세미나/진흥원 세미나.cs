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

            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StringBuilder sb = new StringBuilder();

            Dictionary<string, string> dic = new Dictionary<string, string>()
            {
                { "Algorithm", "204" },
                { "DataAnalysis", "207" },
                { "ArtificialIntelligence", "302" },
                { "CyberSecurity", "B101" },
                { "Network", "303" },
                { "Startup", "501" },
                { "TestStrategy", "105" },
            };

            int N = int.Parse(sr.ReadLine());

            for (int i = 0; i < N; i++)
            {
                sb.AppendLine(dic[sr.ReadLine()]);
            }

            sw.WriteLine(sb.ToString());

            sw.Close();
            sr.Close();
        }
    }
}

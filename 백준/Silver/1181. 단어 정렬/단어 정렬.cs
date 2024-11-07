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

            int N = int.Parse(sr.ReadLine());
            List<string> list = new List<string>();

            for (int i = 0; i < N; i++) 
            { 
                string input = sr.ReadLine();
                if (list.Contains(input)) continue;
                list.Add(input);
            }

            list.Sort();

            foreach (string input in list.OrderBy(s => s.Length)) { sb.AppendLine(input); }
            
            sw.Write(sb.ToString());

            sr.Close();
            sw.Close();

        }
    }
}

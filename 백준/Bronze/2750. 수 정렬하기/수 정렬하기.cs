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

            int N = int.Parse(sr.ReadLine());
            List<int> list = new List<int>(); 

            for(int i = 0; i < N; i++)
            {
                list.Add(int.Parse(sr.ReadLine()));
            }

            list.Sort();

            foreach (int output in list) { sb.AppendLine($"{output}" ); }

            sw.Write(sb.ToString());

            sr.Close();
            sw.Close();

        }
    }
}

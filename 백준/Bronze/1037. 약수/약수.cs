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
            List<int> list = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse).ToList(); 

            list.Sort();

            sb.AppendLine($"{((N == 1) ? list[0] * list[0] : list[0] * list[list.Count - 1] )}");

            sw.Write(sb.ToString());

            sr.Close();
            sw.Close();

        }
    }
}

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
            
            Dictionary<string, int> dic = new Dictionary<string, int>();
            int n = int.Parse(sr.ReadLine());

            for (int i = 0; i < n; i++) 
            {
                string[] input = sr.ReadLine().Split('.');
                if (dic.ContainsKey(input[1]))
                {
                    dic[input[1]]++;
                }
                else
                {
                    dic.Add(input[1], 1);
                }
            }
            foreach( var value in dic.OrderBy(x => x.Key))
            {
                sb.AppendLine($"{value.Key} {value.Value}");
            }

            sw.WriteLine(sb.ToString());

            sr.Close();
            sw.Close();

        }
    }
}

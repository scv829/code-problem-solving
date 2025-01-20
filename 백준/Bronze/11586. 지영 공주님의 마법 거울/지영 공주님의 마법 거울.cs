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
            
            int n = int.Parse(sr.ReadLine());
            List<string> list = new List<string>(n);

            for(int i = 0; i < n; i++)
            {
                list.Add(sr.ReadLine());
            }

            int k = int.Parse(sr.ReadLine());

            if (k == 3)
            {
                for(int i = list.Count -1; i >= 0; i--)
                {
                    sb.AppendLine(list[i]);
                }
            }
            else if (k == 2)
            {
                foreach(string s in list) 
                {
                    sb.AppendLine(new string(s.Reverse().ToArray()));
                }
            }
            else 
            {
                foreach (string s in list)
                {
                    sb.AppendLine(s);
                }
            }
  
            
            sw.WriteLine(sb.ToString());

            sr.Close();
            sw.Close();

        }
    }
}
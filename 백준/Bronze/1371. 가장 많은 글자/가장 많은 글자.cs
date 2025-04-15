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

            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StringBuilder sb = new StringBuilder();
            StringBuilder num = new StringBuilder();

            List<int> list = new List<int>(26);

            for (int i = 0; i < 26; i++) list.Add(0);

            string input = sr.ReadToEnd();

            foreach (char c in input)
            {
                if (c < 'a' || c > 'z') continue;

                list[(c - 'a')]++;
            }
            

            int max = list.Max();

            for (int i = 0; i < 26; i++)
            {
                if (list[i].Equals(max)) sb.Append((char)('a' + i));
            }

            sw.WriteLine(sb.ToString());

            sw.Close();
            sr.Close();
        }
    }

}
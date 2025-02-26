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

            Dictionary<char, int> map = new Dictionary<char, int>();

            string input = sr.ReadLine();

            for(int i = 0; i < 26; i++)
            {
                map.Add( (char)('a' + i) , -1);
            }

            for(int i = 0; i < input.Length; i++)
            {
                if (map[input[i]] == -1)
                {
                    map[input[i]] = i;
                }
            }

            foreach(int num in map.Values)
            {
                sb.Append($"{num} ");
            }

            sw.Write(sb.ToString());

            sr.Close();
            sw.Close();
        }
    }
}
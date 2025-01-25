using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Numerics;
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

            Dictionary<string, int> map = new Dictionary<string, int>();

            int n = int.Parse(sr.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = sr.ReadLine();
                if (map.ContainsKey(input))
                {
                    map[input] += 1;
                }
                else
                {
                    map[input] = 1;
                }
            }

            int max = map.Max(x => x.Value);

            var items = map.Where(x => x.Value.Equals(max)).ToList();

            foreach (var v in items.OrderBy(x => BigInteger.Parse(x.Key)))
            {
                sb.AppendLine(v.Key);
                break;
            }

            sw.WriteLine(sb.ToString());

            sr.Close();
            sw.Close();

        }
    }
}
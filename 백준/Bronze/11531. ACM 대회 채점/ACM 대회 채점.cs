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

            Dictionary<string, (int, string, int)> map = new Dictionary<string, (int, string, int)>();


            while (true)
            {
                string[] logs = sr.ReadLine().Split(' ');

                if (logs[0] == "-1") break;

                if (map.TryGetValue(logs[1], out var value))
                {
                    value.Item1 = int.Parse(logs[0]);
                    value.Item2 = logs[2];
                    value.Item3 += 1;

                    map[logs[1]] = value;
                }
                else
                {
                    map.Add(logs[1], (int.Parse(logs[0]), logs[2], 0));
                }

            }

            int count = map.Count(x => x.Value.Item2.Equals("right"));
            int result = map.Where(x => x.Value.Item2.Equals("right")).Sum(x => x.Value.Item1 + (x.Value.Item3 * 20));

            sb.Append($"{count} {result}");

            sw.WriteLine(sb.ToString());

            sw.Close();
            sr.Close();
        }
    }

}
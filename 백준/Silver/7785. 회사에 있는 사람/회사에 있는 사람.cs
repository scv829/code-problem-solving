using System;
using System.Collections.Generic;
using System.Text;


namespace code
{
    class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int N);

            Dictionary<string, bool> dic = new Dictionary<string, bool>();

            List<string> result = new List<string>();

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < N; i++)
            {
                string[] line = Console.ReadLine().Split(' ');
                dic[line[0]] = line[1].Equals("enter") ? true : false;
            }

            foreach (string key in dic.Keys)
            {
                if (dic[key]) result.Add(key);
            }

            result.Sort();
            result.Reverse();

            foreach (string key in result) { sb.AppendLine(key); }

            Console.WriteLine(sb.ToString());
        }
    }
}

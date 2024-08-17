using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace code
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = Console.ReadLine().Split(' ');
            StringBuilder sb = new StringBuilder();
            List<long> result = new List<long>();

            long n = 0;
            long count = 0;

            for (long i = 0; i < lines.Length; i++)
            {
                if (i == 0) long.TryParse(lines[0], out n);
                else
                {
                    if (lines[i] != "")
                    {
                        result.Add(long.Parse(new string(lines[i].Reverse().ToArray())));
                        count++;
                    }
                }
            }

            while (count < n)
            {
                lines = Console.ReadLine().Split(' ');

                for (long i = 0; i < lines.Length; i++)
                {
                    if (lines[i] != "")
                    {
                        result.Add(long.Parse(new string(lines[i].Reverse().ToArray())));
                        count++;
                    }
                }
            }

            result.Sort();

            foreach (long i in result)
            {
                sb.AppendLine(i.ToString());
            }

            Console.WriteLine(sb.ToString());
        }
    }
}

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
            List<char>[] line = new List<char>[5];
            List<char> result = new List<char>();


            for (int i = 0; i < 5; i++)
            {
                line[i] = Console.ReadLine().ToList();
            }

            while (true)
            {
                for (int i = 0; i < 5; i++)
                {
                    if (line[i].Count > 0)
                    {
                        result.Add(line[i].First());
                        line[i].Remove(line[i].First());
                    }
                }

                if (line[0].Count == 0 &&
                    line[1].Count == 0 &&
                    line[2].Count == 0 &&
                    line[3].Count == 0 &&
                    line[4].Count == 0)
                {
                    break;
                }
            }

            StringBuilder sb = new StringBuilder();

            foreach (char c in result)
            {
                sb.Append(c);
            }
            Console.WriteLine(sb.ToString());
        }
    }
}


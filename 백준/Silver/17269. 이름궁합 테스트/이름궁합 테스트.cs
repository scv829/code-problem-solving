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

            Dictionary<char, int> map = new Dictionary<char, int>
            {
                { 'A', 3 }, { 'B', 2 }, { 'C', 1 }, { 'D', 2 }, { 'E', 4 },
                { 'F', 3 }, { 'G', 1 }, { 'H', 3 }, { 'I', 1 }, { 'J', 1 },
                { 'K', 3 }, { 'L', 1 }, { 'M', 3 }, { 'N', 2 }, { 'O', 1 },
                { 'P', 2 }, { 'Q', 2 }, { 'R', 2 }, { 'S', 1 }, { 'T', 2 },
                { 'U', 1 }, { 'V', 1 }, { 'W', 1 }, { 'X', 2 }, { 'Y', 2 }, { 'Z', 1 }
            };

            List<int> list = new List<int>();

            int[] lens = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);

            string[] names = sr.ReadLine().Split(' ');

            int len = lens.Min();
            int index = (names[0].Length.Equals(len)) ? 1 : 0;

            for (int i = 0; i < len; i++)
            {
                list.Add(map[names[0][i]]);
                list.Add(map[names[1][i]]);
            }

            for (int i = len; i < lens.Max(); i++)
            {
                list.Add(map[names[index][i]]);
            }

            while (list.Count > 2)
            {
                for (int i = 0; i < list.Count - 1; i++)
                {
                    list[i] = list[i] + list[i + 1];

                    if (list[i] >= 10) list[i] %= 10;
                }

                list.RemoveAt(list.Count - 1);
            }

            for (int i = 0; i < list.Count; i++)
            {
                if (i == 0 && list[i] == 0) continue;
                sb.Append(list[i]);
            }

            sb.Append("%");

            sw.Write(sb.ToString());

            sr.Close();
            sw.Close();
        }
    }
}
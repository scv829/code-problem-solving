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

            int[] input = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);
            List<int> heights = new List<int>();

            heights = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse).ToList();

            heights.Sort();

            for(int i = 0; i < heights.Count; i++)
            {
                if (heights[i] <= input[1]) input[1]++;
                else break;
            }

            sb.Append(input[1]);


            sw.Write(sb.ToString());

            sr.Close();
            sw.Close();

        }
    }
}

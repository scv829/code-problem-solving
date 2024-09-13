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
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StringBuilder sb = new StringBuilder();

            int[] ints = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);

            List<int> answer = new List<int>(ints[0]);

            for(int i = 1; i <= ints[0]; i++)
            {
                answer.Add(i);
            }

            for(int i = 0; i < ints[1]; i++)
            {
                int[] nums = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);

                answer.Reverse(nums[0] - 1, nums[1] - nums[0] + 1);
            }

            foreach (int num in answer) sb.Append($"{num} ");

            sw.Write(sb.ToString());

            sw.Close();
            sr.Close();

        }
    }
}
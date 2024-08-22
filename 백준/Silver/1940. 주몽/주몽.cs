using System;
using System.IO;


namespace code
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());


            int N = int.Parse(sr.ReadLine());
            int M = int.Parse(sr.ReadLine()); 
            int[] nums = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            Array.Sort(nums);

            int i = 0;
            int j = N - 1;
            int cnt = 0;

            while (i < j)
            {
                if (nums[i] + nums[j] == M)
                {
                    cnt++;
                    i++;
                    j--;
                }
                if (nums[i] + nums[j] > M)
                {
                    j--;
                }
                if (nums[i] + nums[j] < M)
                {
                    i++;
                }
            }

            sw.WriteLine(cnt);

            sr.Close();
            sw.Close();
        }
    }
}

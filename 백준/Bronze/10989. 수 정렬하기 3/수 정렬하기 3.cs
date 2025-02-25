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
            int[] arr = new int[10001];

            for (int i = 0; i < N; i++)
            {
                arr[int.Parse(sr.ReadLine())]++;
            }

            for (int i = 0; i <= 10000; i++)
            {
                for (int j = 0; j < arr[i]; j++)
                {
                    sw.WriteLine(i);
                }
            }

            sr.Close();
            sw.Close();
        }
    }
}
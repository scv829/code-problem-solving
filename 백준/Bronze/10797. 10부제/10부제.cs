using System;
using System.IO;
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

            int day = int.Parse(sr.ReadLine());
            int[] cars = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);
            int result = 0;

            foreach (int car in cars)
            {
                if ((day % 10).Equals(car)) result++;
            }

            sb.Append(result);

            sw.Write(sb.ToString());

            sr.Close();
            sw.Close();
        }
    }
}
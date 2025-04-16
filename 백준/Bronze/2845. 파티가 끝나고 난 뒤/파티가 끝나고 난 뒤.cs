using System;
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

            int[] area = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);
            int[] news = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);

            foreach (int num in news)
            {
                sb.Append($"{num - (area[0] * area[1])} ");
            }

            sw.WriteLine(sb.ToString());

            sw.Close();
            sr.Close();
        }
    }

}
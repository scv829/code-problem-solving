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

            int[] bucketA = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);
            int[] bucketB = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);

            sb.Append(Math.Min((bucketA[0] + bucketB[1]),(bucketA[1] + bucketB[0])));

            sw.WriteLine(sb.ToString());

            sw.Close();
            sr.Close();
        }
    }
}
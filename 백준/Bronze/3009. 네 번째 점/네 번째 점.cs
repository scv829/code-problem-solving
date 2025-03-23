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

            int[] pos1 = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);
            int[] pos2 = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);
            int[] pos3 = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);

            int[] pos4 = new int[2];

            pos4[0] = (pos1[0].Equals(pos2[0]) ? pos3[0] : (pos1[0].Equals(pos3[0]) ? pos2[0] : pos1[0]));
            pos4[1] = (pos1[1].Equals(pos2[1]) ? pos3[1] : (pos1[1].Equals(pos3[1]) ? pos2[1] : pos1[1]));

            sb.AppendLine($"{pos4[0]} {pos4[1]}");

            sw.WriteLine(sb.ToString());

            sw.Close();
            sr.Close();
        }

    }
}
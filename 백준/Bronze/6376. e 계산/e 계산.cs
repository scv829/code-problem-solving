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

            sb.AppendLine("n e");
            sb.AppendLine("- -----------");

            double[] arr = new double[10];

            arr[0] = 1;

            for(int i = 1; i < 10; i++)
            {
                double n = 1;
                for (int j = 1; j <= i; j++) n *= j;
                arr[i] = arr[i - 1] + ( 1 / n);
            }

            for(int i = 0; i < arr.Length; i++)
            {
                if(i == 8) sb.AppendLine($"{i} {Math.Round(arr[i], 9):N9}");
                else sb.AppendLine($"{i} {Math.Round(arr[i], 9)}");
            }

            sw.Write(sb.ToString());

            sr.Close();
            sw.Close();
        }
    }
}
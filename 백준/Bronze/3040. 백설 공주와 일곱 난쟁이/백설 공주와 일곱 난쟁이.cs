using System;
using System.IO;
using System.Linq;
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

            int[] arr = new int[9];

            int index1 = 0;
            int index2 = 0;
            int result = 0;


            for (int i = 0; i < 9; i++)
            {
                arr[i] = int.Parse(sr.ReadLine());
            }


            for (int i = 0; i < 8; i++)
            {
                for (int j = i + 1; j < 9; j++)
                {
                    int sum = arr.Sum() - (arr[i] + arr[j]);
                    if (sum <= 100 && sum >= result)
                    {
                        index1 = i; index2 = j;
                        result = sum;
                    }
                }
            }

            for (int i = 0; i < 9; i++)
            {
                if (i.Equals(index1) || i.Equals(index2)) continue;

                sb.AppendLine($"{arr[i]}");
            }

            sw.WriteLine(sb.ToString());

            sw.Close();
            sr.Close();
        }
    }

}
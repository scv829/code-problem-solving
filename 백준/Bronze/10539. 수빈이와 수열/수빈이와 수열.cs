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

            int B = int.Parse(sr.ReadLine());

            int[] Bs = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);
            int[] As = new int[B];

            if (B == 1)
            {
                sb.Append(Bs[0]);
            }
            else
            {
                for (int i = 1; i <= B; i++)
                {
                    int sum = Bs[i - 1] * i;

                    for (int j = 0; j < i - 1; j++) sum -= As[j];

                    As[i - 1] = sum;
                }

                foreach (int i in As)
                {
                    sb.Append($"{i} ");
                }
            }

            sw.WriteLine(sb.ToString());

            sr.Close();
            sw.Close();

        }
    }
}

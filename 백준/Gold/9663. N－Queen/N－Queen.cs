using System;
using System.IO;
using System.Text;

namespace code
{
    class Program
    {

        static int n, count;
        static bool[][] isUsed = new bool[3][];

        static void Main(string[] args)
        {

            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StringBuilder sb = new StringBuilder();

            int input = int.Parse(sr.ReadLine());

            n = input;

            isUsed[0] = new bool[n];
            isUsed[1] = new bool[2 * n - 1];
            isUsed[2] = new bool[2 * n - 1];

            count = 0;

            Func(0);

            sb.Append(count);

            sw.Write(sb.ToString());

            sw.Close();
            sr.Close();
        }
        static void Func(int cur)
        {
            if(cur == n)
            {
                count++;
                return;
            }

            for(int i = 0; i < n; i++)
            {
                if (isUsed[0][i] || isUsed[1][cur + i] || isUsed[2][cur - i + n - 1]) continue;

                isUsed[0][i] = true;
                isUsed[1][cur + i] = true;
                isUsed[2][cur - i + n - 1] = true;

                Func(cur + 1);

                isUsed[0][i] = false;
                isUsed[1][cur + i] = false;
                isUsed[2][cur - i + n - 1] = false;
            }
        }
    }
}

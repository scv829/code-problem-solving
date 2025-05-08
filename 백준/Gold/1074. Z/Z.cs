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

            int[] inputs = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse); 

            sb.Append(Func(inputs[0], inputs[1], inputs[2]));

            sw.WriteLine(sb.ToString());

            sw.Close();
            sr.Close();
        }
        static int Func(int n, int r, int c)
        {
            if (n == 0)
            {
                return 0;
            }
            int half = (int)Math.Pow(2, n - 1);

            if(r < half && c < half) return Func(n - 1, r, c);
            if(r < half && c >= half) return half * half + Func(n - 1, r, c - half);
            if(r >= half && c < half) return 2 * half * half + Func(n - 1, r - half, c);
            return 3 * half * half + Func(n - 1, r - half, c - half);
        }
    }
}

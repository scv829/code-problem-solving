using System;
using System.IO;
using System.Numerics;
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

            int[] ACircle = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);
            int[] BCircle = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);

            BigInteger distance = (BigInteger)Math.Sqrt(Math.Pow(ACircle[0] - BCircle[0], 2f) + Math.Pow(ACircle[1] - BCircle[1], 2f));

            if (distance < ACircle[2] + BCircle[2])
            {
                sb.Append("YES");
            }
            else
            {
                sb.Append("NO");
            }


            sw.WriteLine(sb.ToString());
            sr.Close();
            sw.Close();
        }
    }
}
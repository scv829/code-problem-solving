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

            int N = int.Parse(sr.ReadLine());

            for(int i = 0; i < N; i++)
            {
                int[] stat = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);

                sb.Append( 
                    (Math.Max(1, stat[0] + stat[4])) + 
                    ( 5 * Math.Max(1, stat[1] + stat[5]) ) + 
                    ( 2 * Math.Max(0, stat[2] + stat[6])) + 
                    ( 2 * (stat[3] + stat[7])));

                sb.AppendLine();
            }

            sw.WriteLine(sb.ToString());

            sw.Close();
            sr.Close();
        }
    }
}

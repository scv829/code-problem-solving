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

            int works = 0;

            int[] inputs = Array.ConvertAll( sr.ReadLine().Split(' '), int.Parse);
            int[] times = Array.ConvertAll( sr.ReadLine().Split(' '), int.Parse);

            for (int i = 0; i < inputs[0]; i++)
            {
                works += times[i];

                if (works > inputs[1])
                {
                    sb.Append(i);
                    break;
                }
            }

            if (sb.ToString().Length == 0) sb.Append(inputs[0]);

            sw.WriteLine(sb.ToString());

            sr.Close();
            sw.Close();

        }
    }
}

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

            int[] inputs;

            int result = 0;
            int max = 0;

            for(int i = 0; i < 4; i++)
            {
                inputs = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);

                result += (inputs[1] - inputs[0]);

                max = (result > max) ? result : max;
            }

            sb.Append(max);

            sw.WriteLine(sb.ToString());

            sr.Close();
            sw.Close();
        }
    }
}
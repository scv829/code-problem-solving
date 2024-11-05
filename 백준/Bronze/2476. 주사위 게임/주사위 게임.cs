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

            int N = int.Parse(sr.ReadLine());
            int result = 0;

            for (int i = 0; i < N; i++)
            {
                int[] inputs = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);

                if (inputs[0].Equals(inputs[1]) &&
                    inputs[1].Equals(inputs[2]) &&
                    inputs[2].Equals(inputs[0])) result = Math.Max(result, (10000 + (inputs[0] * 1000)));
                else if(!inputs[0].Equals(inputs[1]) &&
                    !inputs[1].Equals(inputs[2]) &&
                    !inputs[2].Equals(inputs[0])) result = Math.Max(result, (Math.Max(inputs[2], Math.Max(inputs[0], inputs[1])) * 100));
                else
                {
                    result = Math.Max(result, (1000 + ((inputs[0].Equals(inputs[1]) ? inputs[0] : inputs[2]) * 100)));
                }
            }
            sb.Append(result);

            sw.Write(sb.ToString());

            sr.Close();
            sw.Close();

        }
    }
}

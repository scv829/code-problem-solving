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

            int[] inputs = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);

            int N = inputs[0];

            int[] basket = new int[N];

            for (int i = 0; i < inputs[1]; i++)
            {
                int[] line = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);

                for (int index = line[0] - 1; index < line[1]; index++)
                {
                    basket[index] = line[2];
                }
            }

            foreach (int i in basket)
            {
                sb.Append($"{i} ");
            }

            sw.WriteLine(sb.ToString());

            sr.Close();
            sw.Close();

        }
    }
}

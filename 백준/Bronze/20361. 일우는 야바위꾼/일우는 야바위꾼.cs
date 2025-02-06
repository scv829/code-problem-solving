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

            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
            StringBuilder sb = new StringBuilder();

            int[] inputs = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);

            int[] ints;

            int[] cups = new int[inputs[0]];

            cups[inputs[1] - 1] = 1;

            for(int i = 0; i < inputs[2]; i++)
            {
                ints = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);

                int temp = cups[ints[0] - 1];
                cups[ints[0] - 1] = cups[ints[1] - 1];
                cups[ints[1] - 1] = temp;
            }

            sb.Append(cups.ToList().IndexOf(1) + 1);

            sw.WriteLine(sb.ToString());

            sr.Close();
            sw.Close();

        }
    }
}
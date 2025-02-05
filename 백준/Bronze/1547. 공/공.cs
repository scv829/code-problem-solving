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

            int T = int.Parse(sr.ReadLine());
            int[] inputs;

            if (T <= 0)
            {
                sb.Append(-1);
            }
            else
            {
                int[] cups = new int[3] { 1, 0, 0 };

                for (int i = 0; i < T; i++)
                {
                    inputs = Array.ConvertAll(sr.ReadLine().Split(' '),int.Parse);

                    int temp = cups[inputs[0] - 1];
                    cups[inputs[0] - 1] = cups[inputs[1] - 1];
                    cups[inputs[1] - 1] = temp;
                }
                sb.Append(cups.ToList().IndexOf(1) + 1);
            }


            sw.WriteLine(sb.ToString());

            sr.Close();
            sw.Close();

        }
    }
}
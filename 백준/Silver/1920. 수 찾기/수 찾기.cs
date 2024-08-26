using System;
using System.Collections.Generic;
using System.Text;


namespace code
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            double.TryParse(Console.ReadLine(), out double N);
            Dictionary<double, bool> dic = new Dictionary<double, bool>();

            string[] line = Console.ReadLine().Split(' ');

            foreach (string s in line)
            {
                dic[double.Parse(s)] = true;
            }
            double.TryParse(Console.ReadLine(), out double M);
            double[] input = Array.ConvertAll(Console.ReadLine().Split(' '), double.Parse);

            foreach (double d in input)
            {
                if (dic.ContainsKey(d))
                {
                    sb.AppendLine("1");
                }
                else
                {
                    sb.AppendLine("0");
                }
            }

            Console.WriteLine(sb.ToString());
        }
    }
}

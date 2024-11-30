using System;
using System.Collections.Generic;
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

            List<(int, int)> result = new List<(int, int)> ();

            for(int i = 0; i < 5; i++)
            {
                int[] intpus = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);
                int sum = intpus.Sum();

                result.Add((sum, (i+1)));
            }

            result.Sort();

            sb.Append($"{result[4].Item2} {result[4].Item1}");

            sw.Write(sb.ToString());

            sr.Close();
            sw.Close();

        }
    }
}
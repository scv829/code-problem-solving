using System;
using System.Collections.Generic;
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
            Dictionary<int, int> outputs = new Dictionary<int, int>();
            List<int> list = new List<int>(); 

            int[] inputs = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);

            foreach (int i in inputs) 
            { 
                if(!outputs.TryGetValue(i , out int num)) outputs.Add(i, 1);
            }

            foreach ( int i in outputs.Keys)
            {
                list.Add(i);
            }

            list.Sort();

            foreach (int output in list) { sb.Append($"{output} " ); }

            sw.Write(sb.ToString());

            sr.Close();
            sw.Close();

        }
    }
}

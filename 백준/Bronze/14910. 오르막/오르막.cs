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

            string inputs = sr.ReadLine();

            List<int> arr1 = Array.ConvertAll(inputs.Split(' '), int.Parse).ToList();

            List<int> arr2 = Array.ConvertAll(inputs.Split(' '), int.Parse).ToList();


            arr2.Sort();

            for (int i = 0; i < arr1.Count; i++) 
            {
                if (arr1[i] != arr2[i])
                { 
                    sb.Append("Bad");
                    break;
                }
            }

            if (sb.Length == 0) sb.Append("Good");

            sw.Write(sb.ToString());

            sr.Close();
            sw.Close();
        }
    }
}
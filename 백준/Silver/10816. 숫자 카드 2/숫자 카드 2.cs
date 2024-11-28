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

            Dictionary<int, int> dictionary = new Dictionary<int, int>();


            int N = int.Parse(sr.ReadLine());

            int[] cards = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);

            int M = int.Parse(sr.ReadLine());

            int[] finds = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);

            foreach (int card in cards)
            {
                if (dictionary.ContainsKey(card))
                {
                    dictionary[card]++;
                }
                else
                {

                    dictionary.Add(card, 1);
                }
            }

            foreach (int find in finds)
            {
                sb.Append($"{(dictionary.ContainsKey(find) ? dictionary[find] : 0)} ");
            }

            sw.Write(sb.ToString());

            sr.Close();
            sw.Close();

        }
    }
}
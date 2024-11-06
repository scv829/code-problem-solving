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
            int[] result = new int[2];

            string input = sr.ReadLine();

            foreach (char c in input) 
            {
                if (c.Equals('A')) result[0]++;
                else result[1]++;
            }

            sb.AppendLine( (result[0].Equals(result[1]) ? "Tie" : (result[0] > result[1]) ? "A" : "B"));

            sw.Write(sb.ToString());

            sr.Close();
            sw.Close();

        }
    }
}

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

            int S = int.Parse(sr.ReadLine());
            string input = sr.ReadLine();
            int[] result = new int[2];

            foreach(char c in input)
            {
                if (c.Equals('2')) result[0]++;
                else result[1]++;
            }

            if (result[0].Equals(result[1])) sb.Append("yee");
            else if (result[0] > result[1]) sb.Append(2);
            else sb.Append('e');

            sw.Write(sb.ToString());

            sr.Close();
            sw.Close();

        }
    }
}

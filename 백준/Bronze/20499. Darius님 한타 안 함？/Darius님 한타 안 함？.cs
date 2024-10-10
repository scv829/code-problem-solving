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

            int[] kda = Array.ConvertAll(sr.ReadLine().Split('/'), int.Parse);

            sb.Append($"{((kda[1] == 0 || kda[0] + kda[2] < kda[1]) ? "hasu" : "gosu")}");

            sw.Write(sb.ToString());

            sr.Close();
            sw.Close();

        }
    }
}

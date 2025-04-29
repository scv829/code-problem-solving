using System;
using System.IO;
using System.Text;
namespace code
{
    class Program
    {

        static void Main(string[] args)
        {

            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StringBuilder sb = new StringBuilder();

            string input = sr.ReadLine();
            string key = sr.ReadLine();

            for (int i = 0; i < key.Length; i++) sb.Append(1);

            string change = sb.ToString();
            sb.Clear();

            int count = 0;

            while (input.Contains(key))
            {
                int startIndex = input.IndexOf(key);

                if (startIndex == -1) break;

                input = input.Remove(startIndex, key.Length);
                input = input.Insert(startIndex, change);

                count++;
            }

            sb.Append(count);

            sw.WriteLine(sb.ToString());

            sw.Close();
            sr.Close();
        }
    }

}
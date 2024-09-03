using System;
using System.Collections.Generic;
using System.Text;


namespace code
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> password = new Dictionary<string, string>();
            StringBuilder sb = new StringBuilder();
            int[] ints = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            for (int i = 0; i < ints[0]; i++)
            {
                string[] lines = Console.ReadLine().Split(' ');
                password[lines[0]] = lines[1];
            }

            for (int i = 0; i < ints[1]; i++)
            {
                sb.AppendLine(password[Console.ReadLine()]);
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
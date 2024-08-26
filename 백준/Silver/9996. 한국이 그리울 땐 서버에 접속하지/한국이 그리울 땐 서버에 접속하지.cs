using System;
using System.Text;


namespace code
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            int.TryParse(Console.ReadLine(), out int N);

            string[] line = Console.ReadLine().Split('*');

            for (int i = 0; i < N; i++)
            {
                string input = Console.ReadLine();

                if (input.Length < line[0].Length + line[1].Length)
                {
                    sb.AppendLine("NE");
                    continue;
                }

                if (!line[0].Equals(input.Substring(0, line[0].Length)) ||
                    !line[1].Equals(input.Substring(input.Length - line[1].Length, line[1].Length)))
                {
                    sb.AppendLine("NE");
                }
                else
                {
                    sb.AppendLine("DA");
                }

            }

            Console.WriteLine(sb.ToString());
        }
    }
}

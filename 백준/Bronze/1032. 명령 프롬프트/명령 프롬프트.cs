using System;
using System.Text;

namespace code
{
    class Program
    {

        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int N);
            StringBuilder sb = new StringBuilder();
            bool flag = false;

            string[] files = new string[N];

            for (int i = 0; i < N; i++)
            {
                files[i] = Console.ReadLine();
            }

            for (int i = 0; i < files[0].Length; i++)
            {
                flag = false;
                for (int j = 0; j < N; j++)
                {
                    if (files[0][i] != files[j][i])
                    {
                        flag = true;
                        break;
                    }
                }

                if (flag) sb.Append("?");
                else sb.Append(files[0][i]);

            }

            Console.WriteLine(sb.ToString());
        }
    }
}

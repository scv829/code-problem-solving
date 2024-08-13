using System;
using System.Text;

namespace code
{
    class Program
    {

        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int N);

            (int, int)[] list = new (int, int)[N];
            int[] result = new int[N];

            StringBuilder sb = new StringBuilder();


            for (int i = 0; i < N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                list[i].Item1 = int.Parse(s[0]);
                list[i].Item2 = int.Parse(s[1]);
            }


            for (int i = 0; i < N; i++)
            {
                result[i] = 1;
                for (int j = 0; j < N; j++)
                {
                    if (i == j) continue;
                    if ((list[i].Item1 < list[j].Item1) &&
                         (list[i].Item2 < list[j].Item2)
                    )
                    {
                        result[i] += (list[i] != list[j]) ? 1 : 0;
                    }
                }
                sb.Append(result[i] + " ");
            }

            Console.WriteLine(sb.ToString());
        }
    }
}


using System;
using System.Text;

namespace code
{
    class Program
    {

        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            bool direction = false;
            bool turn = false; ;
            int.TryParse(Console.ReadLine(), out int N);

            int x = 1, y = 1;

            for (int i = 1; i < N; i++)
            {
                if (y == 1 && !turn)
                {
                    direction = false;
                    x++;
                    turn = true;
                }
                else if (x == 1 && !turn)
                {
                    direction = true;
                    turn = true;
                    y++;
                }
                else if (turn == true || x != 1 && y != 1)
                {
                    x = direction ? x + 1 : x - 1;
                    y = direction ? y - 1 : y + 1;
                    turn = false;
                }
            }

            sb.Append(y + "/" + x);

            Console.WriteLine(sb.ToString());

        }
    }
}


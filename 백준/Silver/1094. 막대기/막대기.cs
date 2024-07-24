using System;

namespace code
{
    class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int X);
            int count = 0;

            string str = Convert.ToString(X, 2);

            foreach(char c in str)
            {
                if (c == '1') count++;
            }

            Console.WriteLine(count);

        }
    }
}

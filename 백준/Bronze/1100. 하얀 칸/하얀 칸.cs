using System;

namespace code
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;


            for(int i = 0; i < 8; i++)
            {
                string line = Console.ReadLine();           
                for (int j = (i % 2 == 0) ? 0 : 1; j < 8; j += 2)
                {
                    if (line[j] == 'F') count++;
                }
            }

            Console.WriteLine(count);

        }
    }
}

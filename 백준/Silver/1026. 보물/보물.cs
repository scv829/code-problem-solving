using System;

class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int N);

            string[] strA = Console.ReadLine().Split();
            string[] strB = Console.ReadLine().Split();

            int[] A = Array.ConvertAll(strA, s => int.Parse(s));
            int[] B = Array.ConvertAll(strB, s => int.Parse(s));

            int S = 0;

            Array.Sort(A);
            Array.Sort(B, (num1, num2) => num2.CompareTo(num1));

            for (int i = 0; i < N; i++)
            {
                S += A[i] * B[i];
            }

            Console.WriteLine(S);

        }
    }
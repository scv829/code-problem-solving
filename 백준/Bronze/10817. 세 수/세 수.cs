using System;
using System.Collections.Generic;
using System.Linq;

namespace code
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse).ToList();
            list.Sort();
            Console.WriteLine(list[1]);
        }
    }
}

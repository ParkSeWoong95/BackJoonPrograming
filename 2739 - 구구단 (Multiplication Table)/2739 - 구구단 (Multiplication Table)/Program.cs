using System;

namespace _2739___구구단__Multiplication_Table_
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            if (N >= 1 && N < 10)
            {
                for (int i = 1; i < 10; i++)
                {
                    Console.WriteLine($"{N} * {i} = {N * i}");
                }
            }
        }
    }
}

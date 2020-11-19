using System;

namespace _8393___합
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int A = 0;

            for (int i = n; 0 <= i; i--)
            {
                A += i;
            }
            Console.WriteLine(A);
        }
    }
}

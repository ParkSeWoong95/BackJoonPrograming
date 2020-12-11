using System;

namespace _11022___A_B___8
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            int[] A = new int[T];
            int[] B = new int[T];
            for (int i = 0; i < T; i++)
            {
                string[] array = Console.ReadLine().Split(' ');
                A[i] = int.Parse(array[0]);
                B[i] = int.Parse(array[1]);
            }
            for (int j = 0; j < T; j++)
            {
                int C = A[j] + B[j];
                Console.WriteLine($"Case #{j + 1}: {A[j]} + {B[j]} = {C}");
        }
    }
}
}

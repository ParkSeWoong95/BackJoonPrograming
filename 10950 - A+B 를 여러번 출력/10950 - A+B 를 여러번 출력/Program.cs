using System;

namespace _10950___A_B_를_여러번_출력
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
                string[] number = Console.ReadLine().Split(' ');
                A[i] = int.Parse(number[0]);
                B[i] = int.Parse(number[1]);
            }
            for (int j = 0; j < T; j++)
            {
                Console.WriteLine("{0}", A[j] + B[j]);
            }
        }
    }
}

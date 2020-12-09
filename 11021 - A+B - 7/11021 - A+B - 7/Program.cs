using System;
using System.Text;
namespace _11021___A_B___7
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            int[] A = new int[T];
            int[] B = new int[T];
            StringBuilder stringbuilding = new StringBuilder();

            for (int i = 0; i < T; i++)
            {
                string[] number = Console.ReadLine().Split();
                A[i] = int.Parse(number[0]);
                B[i] = int.Parse(number[1]);
            }
            for (int j = 0; j < T; j++)
            {
                Console.WriteLine("Case #" +(j+1)+ ": " +(A[j] + B[j]));
            }
        }
    }
}

using System;

namespace _10818___최소_최대
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1 = Console.ReadLine();
            int n = int.Parse(input1);

            string[] input2 = Console.ReadLine().Split();
            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(input2[i]);
            }

            int min = array[array.Length - 1];
            int max = array[array.Length - 1];
            for (int i = 0; i < array.Length; i++)
            {
                int endN = array[array.Length - (i + 1)];
                if (max <= endN)
                {
                    max = endN;
                }

                if (min >= endN)
                {
                    min = endN;
                }
            }
            Console.WriteLine("{0} {1}", min, max);

            // 시간 초과로 틀림 원인미상.  n^2 계산이라?
            //int N = int.Parse(Console.ReadLine());
            //string[] number = Console.ReadLine().Split();

            //for ( int i = 0; i < N; i++)
            //{
            //    for (int j = i + 1; j < N; j++)
            //    {
            //        if (int.Parse(number[i]) > int.Parse(number[j]))
            //        {
            //            string temp = number[i];
            //            number[i] = number[j];
            //            number[j] = temp;
            //        }
            //    }
            //}
            //Console.WriteLine($"{number[0]} {number[4]}");
        }
    }
}

using System;
using System.Text;
using System.IO;

namespace baekjoon
{
    class MainApp
    {
        static void Main()
        {
            int[] numsArray = new int[9];

            int count = 0;

            int maxValue = numsArray[0];

            for (int i = 0; i < numsArray.Length; i++)
            {
                numsArray[i] = int.Parse(Console.ReadLine());

                if (numsArray[i] > maxValue)
                {
                    maxValue = numsArray[i];
                    count = i +1;
                }
            }
            Console.WriteLine(maxValue);
            Console.WriteLine(count); 
        }
    }
}
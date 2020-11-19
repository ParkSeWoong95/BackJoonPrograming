using System;

namespace _2588___곱셈__multiply_
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstThreeDigit = int.Parse(Console.ReadLine());
            string secondThreeDigit = Console.ReadLine();

            char[] secondNumArray = secondThreeDigit.ToCharArray();

            int[] forSecondNumArray = new int[secondNumArray.Length];

            for (int i = 0; i < forSecondNumArray.Length; i++)
            {
                forSecondNumArray[i] = int.Parse(secondNumArray[i].ToString());
            }

            Console.WriteLine(firstThreeDigit * forSecondNumArray[2]); //3번째 줄
            Console.WriteLine(firstThreeDigit * forSecondNumArray[1]); //4번째 줄
            Console.WriteLine(firstThreeDigit * forSecondNumArray[0]); //5번째 줄
            Console.WriteLine(firstThreeDigit * forSecondNumArray[2] 
                + firstThreeDigit * forSecondNumArray[1] * 10 
                + firstThreeDigit * forSecondNumArray[0] * 100); //6번째 줄
        }
    }
}

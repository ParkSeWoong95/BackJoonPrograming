using System;
using System.Text;
namespace _10871___X보다_작은_수
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputInteger = Console.ReadLine().Split();
            int n = int.Parse(inputInteger[0]);
            int x = int.Parse(inputInteger[1]);
            int[] array = new int[n];

            StringBuilder build = new StringBuilder();
            string[] stringNumber = Console.ReadLine().Split();
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(stringNumber[i]);
                if (array[i] < x)
                {
                    build.Append(array[i] + " ");
                }
            }
            Console.WriteLine(build.ToString());
        }
    }
}

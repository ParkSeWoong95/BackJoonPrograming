using System;
using System.Text;
namespace _10952___A_B__5
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            while (true)
            {
                string[] inputNumber = Console.ReadLine().Split();
                int A = int.Parse(inputNumber[0]);
                int B = int.Parse(inputNumber[1]);
                int sum = A + B;

                if (sum == 0)
                {
                    break;
                }
                sb.Append(sum + "\n");
            }
            Console.WriteLine(sb);
        }
    }
}

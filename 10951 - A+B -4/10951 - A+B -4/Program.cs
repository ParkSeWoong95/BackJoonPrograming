using System;
using System.Text;
namespace _10951___A_B__4
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string number = Console.ReadLine();
                if (number == null)
                {
                    break;
                }
                string[] input = number.Split();
                int A = int.Parse(input[0]);
                int B = int.Parse(input[1]);
                Console.WriteLine(A + B);
            }
        }
    }
}

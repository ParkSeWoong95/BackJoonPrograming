using System;
using System.Reflection;

namespace 백준프로그래밍공부
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] timeSplit = input.Split(' ');

            int hour = int.Parse(timeSplit[0]);
            int minute = int.Parse(timeSplit[1]);

            minute -= 45;
            if (minute > 0)
            {
                Console.WriteLine($"{hour} {minute}");
            }
            else if (minute < 0)
            {
                if (hour == 0)
                {
                    hour = 23;
                }
                else
                {
                    hour -= 1;
                }
                minute += 60;
                Console.WriteLine($"{hour} {minute}");

                // 실패인가
                
            }
        }
    }
}


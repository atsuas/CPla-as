using System;

namespace CPla_as
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var i = 0; i < 50; i++)
            {
                if (i % 13 != 0)
                {
                    continue;
                }
                Console.WriteLine($"{i}は13で割り切れる数字です");
            }
        }
    }
}

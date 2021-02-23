using System;

namespace CPla_as
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = 15;
            if (num % 3 == 0 || num % 5 == 0)
            {
                Console.WriteLine("numは3か5でわりきれる");
            }
        }
    }
}

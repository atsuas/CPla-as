using System;

namespace CPla_as
{
    class Program
    {
        static void Main(string[] args)
        {
            var tax = 1.1;
            var count = Console.ReadLine();
            var price = int.Parse(count);
            var total = (int)(price * tax);
            Console.WriteLine(total);
        }
    }
}

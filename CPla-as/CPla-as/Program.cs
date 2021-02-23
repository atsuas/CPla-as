using System;

namespace CPla_as
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = Console.ReadLine();
            var price = int.Parse(count);
            var point = (price * 0.01 * 1) * 5;
            var total = price + point;
            Console.WriteLine(total);
        }
    }
}

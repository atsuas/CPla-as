using System;

namespace CPla_as
{
    class Program
    {
        static void Main(string[] args)
        {
            var scores = new int[10];
            for (var i = 0; i < scores.Length; i++)
            {
                var line = Console.ReadLine();
                var number = int.Parse(line);
                scores[i] = number;
            }

            var total = 0;
            for (var i = 0; i < scores.Length; i++)
            {
                total += scores[i];
            }
            Console.WriteLine("合計: {0}", total);
        }
    }
}

using System;

namespace CPla_as
{
    class Program
    {
        static void Main(string[] args)
        {
            var season = '夏';
            var temperature = 39;
            var str = string.Format("{0}の気温は、{1}度です", season, temperature);

            Console.WriteLine(str);
        }
    }
}

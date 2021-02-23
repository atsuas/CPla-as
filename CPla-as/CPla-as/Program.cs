using System;

namespace CPla_as
{
    class Program
    {
        static void Main(string[] args)
        {
            var season = '夏';
            var temperature = 39;
            var str = $"{season}の気温は、{temperature}度です";

            Console.WriteLine(str);
        }
    }
}

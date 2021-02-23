using System;

namespace CPla_as
{
    class Program
    {
        static void Main(string[] args)
        {
            var array2d = new int[4, 3];
            array2d[3, 2] = 12;
            Console.WriteLine(array2d[3, 2]);
        }
    }
}

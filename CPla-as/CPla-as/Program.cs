using System;

namespace CPla_as
{
    class Program
    {
        static void Main(string[] args)
        {
            var squareRoot = 1.41421356;
            var sideLength = 10.0;
            var diagonal = sideLength * squareRoot;
            Console.WriteLine("対角線の長さ:{0}メートル", diagonal);
        }
    }
}

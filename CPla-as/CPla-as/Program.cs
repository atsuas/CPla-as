using System;

namespace CPla_as
{
    class Program
    {
        static void Main(string[] args)
        {
            var total = 100;
            var line = Console.ReadLine();
            var count = int.Parse(line);    //文字列をint型に変換
            var num = total / count;
            Console.WriteLine(num);
        }
    }
}

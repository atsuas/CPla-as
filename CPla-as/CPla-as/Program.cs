using System;

namespace CPla_as
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("名前を入力してください");

            var name = Console.ReadLine();

            Console.WriteLine("{0}さん、おはようございます", name);

        }
    }
}

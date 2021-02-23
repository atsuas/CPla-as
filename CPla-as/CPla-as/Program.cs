using System;

namespace CPla_as
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ご希望の時間帯の番号をにゅうりょくしてください");
            Console.WriteLine("1:9時");
            Console.WriteLine("2:12時");
            Console.WriteLine("3:15時");
            var line = Console.ReadLine();
            var value = int.Parse(line);

            switch (value)
            {
                case 1:
                    Console.WriteLine("9時に予約しました");
                    break;
                case 2:
                    Console.WriteLine("12時に予約しました");
                    break;
                case 3:
                    Console.WriteLine("15時に予約しました");
                    break;
                default:
                    Console.WriteLine("入力された値がおかしいです");
                    break;
            }
        }
    }
}

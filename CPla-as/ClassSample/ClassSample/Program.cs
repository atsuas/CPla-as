using System;

namespace ClassSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var book1 = new Book
            {
                Title = "吾輩は猫である",
                Auther = "夏目漱石",
                Pages = 600,
                Rating = 5
            };

            var book2 = new Book
            {
                Title = "太宰治",
                Auther = "だじゃお",
                Pages = 500,
                Rating = 4
            };

            book1.Print();
            book2.Print();
            
        }
    }

    class Book
    {
        public string Title { get; set; }
        public string Auther { get; set; }
        public int Pages { get; set; }
        public int Rating { get; set; }

        public void Print()
        {
            Console.WriteLine($" {Title}");
            Console.WriteLine($" {Auther} {Pages}ページ 評価:{Rating}");
        }
    }
}

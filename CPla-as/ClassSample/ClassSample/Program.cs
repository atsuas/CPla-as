using System;

namespace ClassSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book
            {
                Title = "吾輩は猫である",
                Auther = "夏目漱石",
                Pages = 600,
                Rating = 5
            };

            var title = book.Title;

            Console.WriteLine(title);
            
        }
    }

    class Book
    {
        public string Title { get; set; }
        public string Auther { get; set; }
        public int Pages { get; set; }
        public int Rating { get; set; }
    }
}

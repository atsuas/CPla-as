using System;

namespace ClassSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book();
            book.Title = "吾輩は猫である";
            book.Auther = "夏目漱石";
            book.Pages = 600;
            book.Rating = 5;
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

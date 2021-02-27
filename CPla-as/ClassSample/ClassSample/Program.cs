using System;

namespace ClassSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var book1 = new Book { Title = "伊豆の踊子", Auther = "川端康成" };
            book1.PrintTitle();
            var book2 = new Book { Title = "走れメロス", Auther = "太宰治" };
            book2.PrintTitle();
            var book3 = new Book { Title = "銀河鉄道の夜", Auther = "宮沢賢治" };
            book3.PrintTitle();
            Book.ClearCount();
            Console.WriteLine(Book.Count);
        }
    }

    class Book
    {
        public static int Count { get; set; }

        public static void ClearCount()
        {
            Count = 0;
        }

        public string Title { get; set; }
        public string Auther { get; set; }
        public int Pages { get; set; }

        int _rating;    //フィールドの定義

        public int Rating   //プロパティの定義
        {
            get //getアクセサーの定義
            {
                return _rating; //参照時にこのコードが実行される
            }
            set //setアクセサーの定義
            {
                _rating = value;    //代入時にこのコードが実行される
            }
        }

        public void PrintTitle()
        {
            Console.WriteLine("書籍名: {0}", Title);
            Count++;

            Console.WriteLine(Count);
        }
        
    }
}




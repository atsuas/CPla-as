using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassSample
{
    class Program
    {
        static void Main()
        {
            var pet1 = new FoodiePet("たべお");
            pet1.Play();
            pet1.Eat();
            pet1.Sleep();
            Console.WriteLine($"{pet1.Name} 機嫌:{pet1.Mood} エネルギー:{pet1.Energy}");

            var pet2 = new CheerfulPet("げんき");
            pet2.Play();
            pet2.Eat();
            pet2.Sleep();
            Console.WriteLine($"{pet2.Name} 機嫌:{pet2.Mood} エネルギー:{pet2.Energy}");

            var pet3 = new SleepyPet("ねむお");
            pet3.Play();
            pet3.Eat();
            pet3.Sleep();
            Console.WriteLine($"{pet3.Name} 機嫌:{pet3.Mood} エネルギー:{pet3.Energy}");

            //VirtualPet pet1 = new FoodiePet("たべお");
            //VirtualPet pet2 = new FoodiePet("たべお");
            //VirtualPet pet3 = new FoodiePet("たべお");

        }   
    }
    class VirtualPet
    {
        public string Name { get; private set; }
        public int Mood { get; set; }
        public int Energy { get; set; }

        //コンストラクター
        public VirtualPet(string name)
        {
            Name = name;
            Mood = 5;
            Energy = 100;
        }

        public virtual void Eat()   //virtualキーワードを使っている
        {

        }
        public virtual void Play()
        {

        }
        public virtual void Sleep()
        {

        }
    }

    class FoodiePet : VirtualPet
    {
        public FoodiePet(string name) : base(name)  //baseキーワードで継承元のコンストラクターを呼び出す
        {

        }

        public override void Eat()  //overrideを使って上書き定義
        {
            Mood += 3;
            Energy += 5;
            Console.WriteLine("FoodiePet.Eatメソッドが実行されました");
        }

        public override void Play() //overrideを使って上書き定義
        {
            Mood -= 1;
            Energy -= 10;
            Console.WriteLine("FoodiePet.Playメソッドが実行されました");
        }

        public override void Sleep()    //overrideを使って上書き定義
        {
            Mood -= 1;
            Energy += 2;
            Console.WriteLine("FoodiePet.Sleepメソッドが実行されました");
        }
    }

    class CheerfulPet : VirtualPet
    {
        public CheerfulPet(string name) : base(name)
        {

        }
        public override void Eat()
        {
            Mood += 0;  //値は変化しない
            Energy += 5;
            Console.WriteLine("CheerfulPet.Eatメソッドが実行されました");
        }
        public override void Play()
        {
            Mood += 3;
            Energy -= 10;
            Console.WriteLine("CheerfulPet.Playメソッドが実行されました");
        }

        public override void Sleep()
        {
            Mood -= 1;
            Energy += 2;
            Console.WriteLine("CheerfulPet.Sleepメソッドが実行されました");
        }
    }

    class SleepyPet : VirtualPet
    {
        public SleepyPet(string name) : base(name)
        {

        }
        public override void Eat()
        {
            Mood -= 1;
            Energy += 5;
            Console.WriteLine("SleepyPet.Eatメソッドが実行されました");
        }
        public override void Play()
        {
            Mood -= 1;
            Energy -= 10;
            Console.WriteLine("SleepyPet.Playメソッドが実行されました");
        }

        public override void Sleep()
        {
            Mood += 2;
            Energy += 2;
            Console.WriteLine("SleepyPet.Sleepメソッドが実行されました");
        }
    }
}




﻿using System;

namespace ClassSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("名前を入力してください⇒");
            var name = Console.ReadLine();
            var mypet = new VirtualPet(name);   //引数を指定したコンストラクターが呼ばれる
            Console.WriteLine($"Name: {mypet.Name}");
            Console.WriteLine($"Mood: {mypet.Mood}");
            Console.WriteLine($"Energy: {mypet.Energy}");

        }

        class VirtualPet
        {
            public string Name { get; set; }
            public int Mood { get; set; }
            public int Energy { get; set; }

            public VirtualPet(string name) //コンストラクターの名前はクラスと同じにする
            {
                Name = name;
                Mood = 5;
                Energy = 100;
            }
        }
    }
}





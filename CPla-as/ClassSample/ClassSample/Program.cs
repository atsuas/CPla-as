using System;

namespace ClassSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var bmicalc = new BmiCalculator();
            var bmi = bmicalc.GetBmi(180, 80);
            var type = bmicalc.GetBodyType(bmi);
            Console.WriteLine($"あなたは{type}です");
        }
    }

    class BmiCalculator
    {
        public double GetBmi(double height, double weight)
        {
            var meterstall = height / 100.0;
            var bmi = weight / (meterstall * meterstall);
            return bmi;
        }

        public string GetBodyType(double bmi)
        {
            if (bmi < 18.5)
            {
                return "痩せ型";
            }
            if (bmi < 25)
            {
                return "普通体重";
            }
            if (bmi < 30)
            {
                return "肥満１度";
            }
            if (bmi < 35)
            {
                return "肥満２度";
            }
            if (bmi < 40)
            {
                return "肥満３度";
            }
            return "肥満４度";
        }
    }
}





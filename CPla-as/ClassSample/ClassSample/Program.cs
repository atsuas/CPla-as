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
            var type = "";
            if (bmi < 18.5)
            {
                type = "瘦せ型";
            }
            else if (bmi < 25)
            {
                type = "普通体重";
            }
            else if (bmi < 30)
            {
                type = "肥満1度";
            }
            else if (bmi < 35)
            {
                type = "肥満２度";
            }
            else if (bmi < 40)
            {
                type = "肥満３度";
            }
            else
            {
                type = "肥満４度";
            }
            return type;
        }
    }
}





using System;

namespace ClassSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var bmicalc = new BmiCalculator();
            var bmi = bmicalc.GetBmi(178, 80);
            Console.WriteLine("{0:.00}", bmi);
        }
    }

    class BmiCalculator
    {
        public double GetBmi(double height, double weight)
        {
            var metersTall = height / 100.0;
            var bmi = weight / (metersTall * metersTall);
            return bmi;
        }
    }
}

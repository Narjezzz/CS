using System;
using System.Globalization;


public class Program{

    public static void Main(){
        Check(1,10);
    }

    sealed class Ratio{
        private int numerator;
        private int denominator;
        private double value;

        public int Numerator{
            get => numerator;
            set => throw new Exception("You cannot assign");
        }
        public int Denominator{
            get => denominator;
            set => throw new Exception("You cannot assign");
        }
        public double Value{
            get => value;
            set => throw new Exception("You cannot assign");
        }

        public Ratio(int num, int den){
            numerator = num;
            denominator = den;
            value = Convert.ToDouble(num) / Convert.ToDouble(den);
        }
    }

    public static void Check(int num, int den){
        var ratio = new Ratio(num, den);
        Console.WriteLine("{0}/{1} = {2}",
            ratio.Numerator, ratio.Denominator,
            ratio.Value.ToString(CultureInfo.InvariantCulture));
    }
}
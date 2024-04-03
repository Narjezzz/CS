using System;

public class Program
{
    public static void Main()
    {
        Vector vector = new(3, 4);
        Console.WriteLine(vector.ToString());

        vector.X = 0;
        vector.Y = -1;
        Console.WriteLine(vector.ToString());

        vector = new Vector(9, 40);
        Console.WriteLine(vector.ToString());

        Console.WriteLine(new Vector(0,0).ToString());
    }

    public class Vector
    {
        private double x;
        private double y;
        private double length;

        public double X{
            get => x;
            set => x = value;
        }
        public double Y{
            get => y;
            set => y = value;
        }
        public double Length{
            get => length;
            set => throw new Exception("you cannot assing");
        }

        public Vector(double x, double y)
        {
            this.x = Math.Abs(x);
            this.y = Math.Abs(y);
            length = Math.Sqrt(this.x * this.x + this.y * this.y);// теорема пифагора
        }

        public override string ToString()
        {
            return string.Format("({0}, {1}) with length: {2}", X, Y, Length);
        }
    }
}
using System;

namespace DIANA
{

    class CustomError : Exception
    {
        public CustomError(string mes) : base(mes)
        {

        }
    }


    class Rectangle
    {
        double a;
        double b;

        public double A
        {
            get => a;
            set
            {
                if (value <= 0) throw new CustomError("error");
                a = value;
            }
        }

        public double B
        {
            get => b;
            set
            {
                if (value <= 0) throw new CustomError("error");
                b = value;
            }
        }

        public Rectangle(double _a, double _b)
        {
            a = _a;
            b = _b;
        }

        public Rectangle()
        {

        }

        public double Square() => a * b;

        public double Perim() => (a + b) * 2;

        public bool IsSquare()
        {
            if (a == b) return true;
            return false;
        }

        public void Print() => Console.WriteLine($"{a} {b}");


    }


    class Program
    {
        public static void Main(string[] args)
        {
            Rectangle a = new Rectangle(4, 4);
            Console.WriteLine(a.IsSquare());
            a.Print();
            
        }
    }
}
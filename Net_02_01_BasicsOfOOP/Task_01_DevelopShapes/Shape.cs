using System;
using System.Collections.Generic;
using System.Text;

namespace Task_01_DevelopShapes
{
    public abstract class Shape
    {
        public abstract double Area();
        public abstract double Perimeter();
    }

    public class Circle : Shape
    {
        private readonly double r;
        private const double pi = 3.14;

        public Circle(double r)
        {
            Console.WriteLine("Circle:");
            this.r = r;
        }

        public override double Area()
        {
            return pi * r * r;
        }

        public override double Perimeter()
        {
            return 2 * pi * r;
        }
    }

    public class Triangle : Shape
    {
        private readonly double ab;
        private readonly double bc;
        private readonly double ac;

        public Triangle(double ab, double bc, double ac)
        {
            Console.WriteLine("Triangle:");
            this.ab = ab;
            this.bc = bc;
            this.ac = ac;
        }

        public override double Area()
        {
            double p = (ab + bc + ac) / 2;
            return Math.Sqrt(p * (p - ab) * (p - bc) * (p - ac));
        }

        public override double Perimeter()
        {
            return ab + bc + ac;
        }
    }

    public class Square : Shape
    {
        private readonly double a;

        public Square(double a)
        {
            Console.WriteLine("Square:");
            this.a = a;
        }

        public override double Area()
        {
            return a * a;
        }

        public override double Perimeter()
        {
            return 4 * a;
        }
    }

    public class Rectangle : Shape
    {
        private readonly double width;
        private readonly double height;

        public Rectangle(double width, double height)
        {
            Console.WriteLine("Rectangle:");
            this.width = width;
            this.height = height;
        }

        public override double Area()
        {
            return width * height;
        }

        public override double Perimeter()
        {
            return 2 * (width + height);
        }
    }
}

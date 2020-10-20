using System;

namespace Task_01_DevelopShapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = new Shape[4];
            shapes[0] = new Circle(r: 5);
            shapes[1] = new Triangle(ab: 3, bc: 2, ac: 3);
            shapes[2] = new Square(a: 5);
            shapes[3] = new Rectangle(width: 5, height: 9);

            foreach(Shape shape in shapes)
            {
                Console.WriteLine(shape.Area());
            }
        }
    }
}

using System;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes= new List<Shape>();
        
        // Square square = new Square("Red", 4);
        // Console.WriteLine(square.GetColor());
        // Console.WriteLine(square.GetArea());
        Square shape1 = new Square("red", 4);
        Retangle shape2 = new Retangle("blue",5,10);
        Circle shape3 = new Circle("yellow",6);
        shapes.Add(shape1);
        shapes.Add(shape2);
        shapes.Add(shape3);
        foreach(Shape differentShape in shapes){
            string color = differentShape.GetColor();
            double area = differentShape.GetArea();
            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}
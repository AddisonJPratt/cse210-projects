using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> difShapes = new List<Shape>();

        Square sq = new Square(12, "Green");
        difShapes.Add(sq);

        Rectangle rec = new Rectangle(6, 4, "Purple");
        difShapes.Add(rec);

        Circle circ = new Circle(6, "Orange");
        difShapes.Add(circ);

        foreach (Shape shap in difShapes)
        {
            Console.WriteLine(shap.GetColor());
            Console.WriteLine(shap.GetArea());
        }

    }
}
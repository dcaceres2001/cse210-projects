using System;
using System.Collections.Generic;
namespace Shapes
{
    class Program
    {


        static void Main(string[] args)
        {
            List<abstractShape> shapes = [];

            Square s1 = new("red", 5);
            shapes.Add(s1);
            Rectangle r1 = new("blue", 4, 6);
            shapes.Add(r1);
            Circle c1 = new("green", 3);
            shapes.Add(c1);

            foreach (abstractShape shape in shapes)
            {
                Console.WriteLine($"The area of the {shape.GetColor()} {shape.GetType().Name} is {shape.GetArea():F2}");
            }


        }
    }
}
    
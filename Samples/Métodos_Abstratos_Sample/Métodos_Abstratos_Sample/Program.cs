using System;
using System.Globalization;
using System.Collections.Generic;
using Métodos_Abstratos_Sample.Entities;
using Métodos_Abstratos_Sample.Entities.Enums;

namespace Métodos_Abstratos_Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            char choice;

            int n;
            double width, height, radius;

            Color color;
            List<Shape> shapes = new List<Shape>();

            Console.Write("Enter the number of shapes: ");
            n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Shape #{i} data:");

                Console.Write("Rectange or Circle (r/c)? ");
                choice = char.Parse(Console.ReadLine());

                if(choice == 'r')
                {
                    Console.Write("Color (Black/Blue/Red)? ");
                    color = Enum.Parse<Color>(Console.ReadLine());

                    Console.Write("Width: ");
                    width = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.Write("Height: ");
                    height = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    shapes.Add(new Rectangle(width, height, color));
                }

                else
                {
                    Console.Write("Color (Black/Blue/Red)? ");
                    color = Enum.Parse<Color>(Console.ReadLine());

                    Console.Write("Radius: ");
                    radius = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    shapes.Add(new Circle(radius, color));
                }
            }

            Console.WriteLine();
            Console.WriteLine("SHAPE AREAS:");
            foreach(Shape s in shapes)
            {
                Console.WriteLine(s.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}

using DrawingSim.Application;
using DrawingSim.Application.Abstract;
using DrawingSim.Domain;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingSim.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            ICanvas<string> canvas = new ConsoleCanvas();
            Rect rect = new Rect(30, 40, new Point(10, 10));
            Square square = new Square(35, new Point(15, 30));
            Ellipse ellipse = new Ellipse(300, 200, new Point(100, 150));
            Circle circle = new Circle(300, new Point(1, 1));
            TextBox textBox = new TextBox(200, 100, new Point(5, 5), "sample text");

            canvas
                .Add(rect)
                .Add(square)
                .Add(ellipse)
                .Add(circle)
                .Add(textBox);
            IEnumerable<string> output = canvas.Print().ToArray();

            foreach (string line in output)
            {
                System.Console.WriteLine(line);
            }
            System.Console.ReadKey();
        }
    }
}

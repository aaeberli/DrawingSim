using DrawingSim.Application;
using DrawingSim.Common.Abstract;
using DrawingSim.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;
using System.Linq;

namespace DrawingSim.Test
{
    [TestClass]
    public class CanvasUT
    {
        [TestMethod]
        public void Test_canvas_draw()
        {
            // Arrange
            ICanvas<string> canvas = new ConsoleCanvas();
            Rect rect = new Rect(30, 40, new Point(10, 10));
            Square square = new Square(35, new Point(15, 30));
            Ellipse ellipse = new Ellipse(300, 200, new Point(100, 150));
            Circle circle = new Circle(300, new Point(1, 1));
            TextBox textBox = new TextBox(200, 100, new Point(5, 5), "sample text");
            string[] expected_output =
            {
                "Rectangle (10,10) width=30 height=40",
                "Square (15,30) size=35",
                "Ellipse (100,150) diameterH = 300 diameterV = 200",
                "Circle (1,1) size=300",
                "Textbox (5,5) width=200 height=100 Text=\"sample text\"",
            };

            // Act
            canvas
                .Add(rect)
                .Add(square)
                .Add(ellipse)
                .Add(circle)
                .Add(textBox);
            string[] output = canvas.Print().ToArray();

            // Assert
            Assert.AreEqual(expected_output.Length, output.Length);
            for (int i = 0; i < expected_output.Length; i++)
            {
                Assert.AreEqual(expected_output[i], output[i]);
            }
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;
using DrawingSim.Domain;

namespace DrawingSim.Test
{
    [TestClass]
    public class WidgetDrawUT
    {
        [TestMethod]
        public void Test_draw_rectangle()
        {
            // Arrange
            uint width = 30;
            uint height = 40;
            Point position = new Point(10, 10);

            // Act
            Rect rect = new Rect(width, height, position);

            // Assert
            Assert.IsNotNull(rect);
            Assert.IsTrue(rect.Drawable);
            Assert.AreEqual(rect.Draw(), "Rectangle (10,10) width=30 height=40");
        }


        [TestMethod]
        public void Test_draw_square()
        {
            // Arrange
            uint width = 35;
            Point position = new Point(15,30);

            // Act
            Square square = new Square(width, position);

            // Assert
            Assert.IsNotNull(square);
            Assert.IsTrue(square.Drawable);
            Assert.AreEqual(square.Draw(), "Square (15,30) size=35");
        }


        [TestMethod]
        public void Test_draw_ellipse()
        {
            // Arrange
            uint width = 300;
            uint height = 200;
            Point position = new Point(100, 150);

            // Act
            Ellipse ellipse = new Ellipse(width, height, position);

            // Assert
            Assert.IsNotNull(ellipse);
            Assert.IsTrue(ellipse.Drawable);
            Assert.AreEqual(ellipse.Draw(), "Ellipse (100,150) diameterH = 300 diameterV = 200");
        }

        [TestMethod]
        public void Test_draw_circle()
        {
            // Arrange
            uint width = 300;
            Point position = new Point(1,1);

            // Act
            Circle circle = new Circle(width, position);

            // Assert
            Assert.IsNotNull(circle);
            Assert.IsTrue(circle.Drawable);
            Assert.AreEqual(circle.Draw(), "Circle (1,1) size=300");
        }

        [TestMethod]
        public void Test_draw_textbox()
        {
            // Arrange
            uint width = 200;
            uint height = 100;
            Point position = new Point(5,5);
            string text = "sample text";

            // Act
            TextBox textBox = new TextBox(width, height, position, text);

            // Assert
            Assert.IsNotNull(textBox);
            Assert.IsTrue(textBox.Drawable);
            Assert.AreEqual(textBox.Draw(), "Textbox (5,5) width=200 height=100 Text=\"sample text\"");
        }
    }
}

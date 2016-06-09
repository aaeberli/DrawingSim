using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DrawingSim.Domain;
using System.Drawing;

namespace DrawingSim.Test
{
    [TestClass]
    public class WidgetCreationUT
    {
        [TestMethod]
        public void Test_create_proper_rectangle()
        {
            // Arrange
            uint width = 10;
            uint height = 15;
            Point position = new Point(33, -12);

            // Act
            Rect rect = new Rect(width, height, position);

            // Assert
            Assert.IsNotNull(rect);
            Assert.IsTrue(rect.Drawable);
        }

        [TestMethod]
        public void Test_create_rectangle_wrong_width()
        {
            // Arrange
            uint width = 0;
            uint height = 15;
            Point position = new Point(33, -12);

            // Act
            Rect rect = new Rect(width, height, position);

            // Assert
            Assert.IsNotNull(rect);
            Assert.IsFalse(rect.Drawable);
        }

        [TestMethod]
        public void Test_create_rectangle_wrong_height()
        {
            // Arrange
            uint width = 10;
            uint height = 0;
            Point position = new Point(33, -12);

            // Act
            Rect rect = new Rect(width, height, position);

            // Assert
            Assert.IsNotNull(rect);
            Assert.IsFalse(rect.Drawable);
        }

        [TestMethod]
        public void Test_create_proper_square()
        {
            // Arrange
            uint width = 10;
            Point position = new Point(33, -12);

            // Act
            Square square = new Square(width, position);

            // Assert
            Assert.IsNotNull(square);
            Assert.IsTrue(square.Drawable);
        }

        [TestMethod]
        public void Test_create_square_wrong_width()
        {
            // Arrange
            uint width = 0;
            Point position = new Point(33, -12);

            // Act
            Square square = new Square(width, position);

            // Assert
            Assert.IsNotNull(square);
            Assert.IsFalse(square.Drawable);
        }

        [TestMethod]
        public void Test_create_proper_ellipse()
        {
            // Arrange
            uint width = 23;
            uint height = 11;
            Point position = new Point(234, 0);

            // Act
            Ellipse ellipse = new Ellipse(width, height, position);

            // Assert
            Assert.IsNotNull(ellipse);
            Assert.IsTrue(ellipse.Drawable);
        }

        [TestMethod]
        public void Test_create_ellipse_wrong_width()
        {
            // Arrange
            uint width = 0;
            uint height = 221;
            Point position = new Point(-45, -49);

            // Act
            Ellipse ellipse = new Ellipse(width, height, position);

            // Assert
            Assert.IsNotNull(ellipse);
            Assert.IsFalse(ellipse.Drawable);
        }

        [TestMethod]
        public void Test_create_ellipse_wrong_height()
        {
            // Arrange
            uint width = 10;
            uint height = 0;
            Point position = new Point(33, -12);

            // Act
            Ellipse ellipse = new Ellipse(width, height, position);

            // Assert
            Assert.IsNotNull(ellipse);
            Assert.IsFalse(ellipse.Drawable);
        }

        [TestMethod]
        public void Test_create_proper_circle()
        {
            // Arrange
            uint width = 99;
            Point position = new Point(-1, 12);

            // Act
            Circle circle = new Circle(width, position);

            // Assert
            Assert.IsNotNull(circle);
            Assert.IsTrue(circle.Drawable);
        }

        [TestMethod]
        public void Test_create_circle_wrong_width()
        {
            // Arrange
            uint width = 0;
            Point position = new Point(2, -64);

            // Act
            Circle circle = new Circle(width, position);

            // Assert
            Assert.IsNotNull(circle);
            Assert.IsFalse(circle.Drawable);
        }

        [TestMethod]
        public void Test_create_proper_textbox()
        {
            // Arrange
            uint width = 2354;
            uint height = 11;
            Point position = new Point(-2, -99);
            string text = "I'm a proper txtbox";

            // Act
            TextBox textBox = new TextBox(width, height, position, text);

            // Assert
            Assert.IsNotNull(textBox);
            Assert.IsTrue(textBox.Drawable);
        }

        [TestMethod]
        public void Test_create_textbox_wrong_width()
        {
            // Arrange
            uint width = 0;
            uint height = 2;
            Point position = new Point(76, -5);
            string text = "I'm a wrong txtbox";
            // Act
            TextBox textBox = new TextBox(width, height, position, text);

            // Assert
            Assert.IsNotNull(textBox);
            Assert.IsFalse(textBox.Drawable);
        }

        [TestMethod]
        public void Test_create_textbox_wrong_height()
        {
            // Arrange
            uint width = 41;
            uint height = 0;
            Point position = new Point(0, 0);
            string text = "I'm another wrong txtbox";

            // Act
            TextBox textBox = new TextBox(width, height, position, text);

            // Assert
            Assert.IsNotNull(textBox);
            Assert.IsFalse(textBox.Drawable);
        }

        [TestMethod]
        public void Test_create_textbox_empty_text()
        {
            // Arrange
            uint width = 41;
            uint height = 12;
            Point position = new Point(0, 0);
            string text = string.Empty;

            // Act
            TextBox textBox = new TextBox(width, height, position, text);

            // Assert
            Assert.IsNotNull(textBox);
            Assert.IsFalse(textBox.Drawable);
        }

        public void Test_create_textbox_null_text()
        {
            // Arrange
            uint width = 41;
            uint height = 12;
            Point position = new Point(0, 0);
            string text = null;

            // Act
            TextBox textBox = new TextBox(width, height, position, text);

            // Assert
            Assert.IsNotNull(textBox);
            Assert.IsFalse(textBox.Drawable);
        }

        public void Test_create_textbox_space_text()
        {
            // Arrange
            uint width = 41;
            uint height = 12;
            Point position = new Point(0, 0);
            string text = "   ";

            // Act
            TextBox textBox = new TextBox(width, height, position, text);

            // Assert
            Assert.IsNotNull(textBox);
            Assert.IsFalse(textBox.Drawable);
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using DrawingSim.Console;

namespace DrawingSim.Test
{
    [TestClass]
    public class ProgramUT
    {
        [TestMethod]
        public void Test_program_output()
        {
            // Arrange
            using (StringWriter sw = new StringWriter())
            {
                System.Console.SetOut(sw);
                string expected =
                @"----------------------------------------------------------------
Current Drawing
----------------------------------------------------------------
Rectangle (10,10) width=30 height=40
Square (15,30) size=35
Ellipse (100,150) diameterH = 300 diameterV = 200
Circle (1,1) size=300
Textbox (5,5) width=200 height=100 Text=""sample text""
----------------------------------------------------------------
";
                
                // Act
                Program.Main(null);
                string actual = sw.ToString();

                // Assert
                Assert.AreEqual<string>(expected, actual);
            }
        }
    }
}

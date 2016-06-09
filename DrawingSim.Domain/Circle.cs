using DrawingSim.Common;
using DrawingSim.Domain.Abstract;
using System.Drawing;
using System;

namespace DrawingSim.Domain
{
    [WidgetName(Name = "Circle")]
    public class Circle : Rounded<string>
    {
        public Circle(uint width, Point position)
            : base(width, position)
        {

        }

        public override string Draw()
        {
            return $"{GetName()} ({Position.X},{Position.Y}) size={Width}";
        }
    }
}

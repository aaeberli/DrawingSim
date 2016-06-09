using DrawingSim.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using DrawingSim.Common;

namespace DrawingSim.Domain
{
    [WidgetName(Name = "Square")]
    public class Square : Quadrilateral<string>
    {
        public Square(uint width, Point position)
            : base(width, position)
        {

        }

        public override string Draw()
        {
            return $"{GetName()} ({Position.X},{Position.Y}) size={Width}";
        }
    }
}

using DrawingSim.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DrawingSim.Domain
{
    public class Square : Quadrilateral
    {
        public Square(uint width, Point position)
            : base(width, position)
        {

        }
    }
}

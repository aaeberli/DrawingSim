using DrawingSim.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingSim.Domain
{
    public class Circle : Rounded
    {
        public Circle(uint width, Point position)
            : base(width, position)
        {

        }
    }
}

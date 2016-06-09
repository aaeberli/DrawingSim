using DrawingSim.Common;
using DrawingSim.Domain.Abstract;
using System;
using System.Drawing;

namespace DrawingSim.Domain
{
    [WidgetName(Name = "Ellipse")]
    public class Ellipse : Rounded<string>
    {
        public uint Height { get; private set; }

        protected override Func<bool> VerificationFunction
        {
            get
            {
                return () =>
                {
                    return
                        base.VerificationFunction()
                        && Height > 0;
                };
            }
        }

        public Ellipse(uint width, uint height, Point position)
            : base(width, position)
        {
            Height = height;
        }

        public override string Draw()
        {
            return $"{GetName()} ({Position.X},{Position.Y}) diameterH = {Width} diameterV = {Height}";
        }
    }
}

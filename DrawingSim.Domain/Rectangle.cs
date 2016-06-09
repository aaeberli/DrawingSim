using DrawingSim.Common;
using DrawingSim.Domain.Abstract;
using System;
using System.Drawing;

namespace DrawingSim.Domain
{
    [WidgetName(Name = "Rectangle")]
    public class Rect : Quadrilateral<string>
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

        public Rect(uint width, uint height, Point position)
            : base(width, position)
        {
            Height = height;
        }

        public override string Draw()
        {
            return $"{GetName()} ({Position.X},{Position.Y}) width={Width} height={Height}";
        }
    }
}

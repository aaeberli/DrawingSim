using DrawingSim.Common.Abstract;
using System;
using System.Drawing;

namespace DrawingSim.Domain.Abstract
{
    public abstract class Quadrilateral : Widget
    {
        public uint Width { get; protected set; }
        public Point Position { get; protected set; }

        protected override Func<bool> VerificationFunction
        {
            get
            {
                return () =>
                {
                    return
                        Width > 0;
                };
            }
        }
        protected Quadrilateral()
        {

        }

        public Quadrilateral(uint width, Point position)
        {
            Width = width;
            Position = position;
        }
    }
}

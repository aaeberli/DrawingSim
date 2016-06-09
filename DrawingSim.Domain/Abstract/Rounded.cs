using DrawingSim.Common.Abstract;
using System;
using System.Drawing;

namespace DrawingSim.Domain.Abstract
{
    public abstract class Rounded : Widget
    {
        public virtual uint Width { get; private set; }


        public virtual Point Position { get; private set; }

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

        protected Rounded()
        {

        }
        public Rounded(uint width, Point position)
        {
            Width = width;
            Position = position;
        }
    }
}

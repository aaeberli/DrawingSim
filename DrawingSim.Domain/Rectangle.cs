using DrawingSim.Common.Abstract;
using DrawingSim.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingSim.Domain
{
    public class Rect : Quadrilateral
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
    }
}

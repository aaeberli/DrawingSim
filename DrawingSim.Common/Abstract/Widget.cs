using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingSim.Common.Abstract
{
    public abstract class Widget
    {
        public virtual bool Drawable
        {
            get
            {
                return VerificationFunction();
            }
        }

        protected abstract Func<bool> VerificationFunction { get; }
        
    }
}

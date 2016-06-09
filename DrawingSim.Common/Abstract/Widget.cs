using DrawingSim.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingSim.Common.Abstract
{
    public abstract class Widget<TDraw>
    {
        public virtual bool Drawable
        {
            get
            {
                return VerificationFunction();
            }
        }

        protected abstract Func<bool> VerificationFunction { get; }

        protected virtual string GetName()
        {
            object attribute = this.GetType().GetCustomAttributes(true).SingleOrDefault(a => a is WidgetNameAttribute);
            return (attribute as WidgetNameAttribute)?.Name;
        }

        public abstract TDraw Draw();
    }
}

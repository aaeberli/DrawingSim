using DrawingSim.Common.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingSim.Application.Abstract
{
    public interface ICanvas<TDraw, out TRendered>
    {
        void Add(Widget<TDraw> widget);

        IEnumerable<TRendered> Print();
    }
}

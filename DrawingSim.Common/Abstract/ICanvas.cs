using DrawingSim.Common.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingSim.Common.Abstract
{
    public interface ICanvas<TDraw>
    {
        ICanvas<TDraw> Add(Widget<TDraw> widget);

        IEnumerable<TDraw> Print();
    }
}

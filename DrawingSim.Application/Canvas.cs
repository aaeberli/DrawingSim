using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrawingSim.Application.Abstract;
using DrawingSim.Common.Abstract;

namespace DrawingSim.Application
{
    public class ConsoleCanvas : ICanvas<string>
    {
        public List<Widget<string>> Widgets { get; protected set; }

        public ConsoleCanvas()
        {
            Widgets = new List<Widget<string>>();
        }
        public ICanvas<string> Add(Widget<string> widget)
        {
            Widgets.Add(widget);
            return this;
        }

        public IEnumerable<string> Print()
        {
            foreach (Widget<string> widget in Widgets)
            {
                yield return widget.Draw();
            }
        }
    }
}

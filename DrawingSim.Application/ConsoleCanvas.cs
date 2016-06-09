using DrawingSim.Common.Abstract;
using System.Collections.Generic;

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

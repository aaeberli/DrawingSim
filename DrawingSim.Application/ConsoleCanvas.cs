using DrawingSim.Common;
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
            return new List<string>()
                 .AddRangeFluent(_PrintHeader())
                 .AddRangeFluent(_print())
                 .AddRangeFluent(_PrintFooter());
        }
        private IEnumerable<string> _print()
        {
            foreach (Widget<string> widget in Widgets)
            {
                yield return widget.Draw();
            }
        }

        private IEnumerable<string> _PrintHeader()
        {
            List<string> header = new List<string>();
            header
                .AddFluent("----------------------------------------------------------------")
                .AddFluent("Current Drawing")
                .AddFluent("----------------------------------------------------------------");
            return header;
        }
        private IEnumerable<string> _PrintFooter()
        {
            List<string> footer = new List<string>();
            footer
                .Add("----------------------------------------------------------------");
            return footer;
        }
    }
}

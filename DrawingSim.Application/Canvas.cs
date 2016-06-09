using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrawingSim.Application.Abstract;
using DrawingSim.Common.Abstract;

namespace DrawingSim.Application
{
    public class ConsoleCanvas : ICanvas<string, string>
    {
        public void Add(Widget<string> widget)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> Print()
        {
            throw new NotImplementedException();
        }
    }
}

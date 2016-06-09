using DrawingSim.Common;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingSim.Domain
{
    [WidgetName(Name = "Textbox")]
    public class TextBox : Rect
    {
        public string Text { get; private set; }

        protected override Func<bool> VerificationFunction
        {
            get
            {
                return () =>
                {
                    return
                        base.VerificationFunction()
                        && !string.IsNullOrEmpty(Text)
                        && !string.IsNullOrWhiteSpace(Text);
                };
            }
        }

        public TextBox(uint width, uint height, Point position, string text)
            : base(width, height, position)
        {
            Text = text;
        }

        public override string Draw()
        {
            return $"{GetName()} ({Position.X},{Position.Y}) width={Width} height={Height} Text=\"{Text}\"";
        }
    }
}

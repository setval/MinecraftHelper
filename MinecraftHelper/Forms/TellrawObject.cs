using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MinecraftHelper.Forms
{
    class TellrawObject
    {
        private string text;
        private string color;

        public TellrawObject(string text, string color)
        {
            this.text = text;
            this.color = color;
        }

        public string getText() { return text; }
        public string getColor() { return color; }
    }
}

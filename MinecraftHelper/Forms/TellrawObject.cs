using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MinecraftHelper.Forms
{
    class TellrawObject
    {
        private string text;

        public TellrawObject(string text)
        {
            this.text = text;
        }

        public string getText() { return text; }
    }
}

using System.Collections.Generic;

namespace MinecraftHelper.Forms
{
    class TellrawObject
    {
        private int id;
        private string text;
        private string color;
        private List<string> listFormats;

        public TellrawObject(string text, string color, List<string> listFormats)
        {
            this.text = text;
            this.color = color;
            this.listFormats = listFormats;
        }

        public string getText() { return text; }
        public string getColor() { return color; }
        public List<string> getListFormats() { return listFormats; }
        public int getId() { return id; }
    }
}

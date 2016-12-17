using System.Collections.Generic;

using MinecraftHelper.Forms.Tellraw;

namespace MinecraftHelper.Forms
{
    class TellrawObject
    {
        private int id;
        private string text;
        private string color;   
        private List<string> listFormats;
        private IScoreboard scoreboards;

        public TellrawObject(string text, string color, List<string> listFormats, IScoreboard scoreboards)
        {
            this.text = text;
            this.color = color;
            this.listFormats = listFormats;
            this.scoreboards = scoreboards;
        }

        public string getText() { return text; }
        public string getColor() { return color; }
        public List<string> getListFormats() { return listFormats; }
        public int getId() { return id; }
        public IScoreboard getScoreboards() { return scoreboards; }
    }
}

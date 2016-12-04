using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MinecraftHelper.Forms.Tellraw
{
    class Scoreboard
    {

        private ScoreboardTypes scoreboardDo;
        private ScoreboardTypes scoreboardTypes;
        private string text;

        public Scoreboard(ScoreboardTypes scoreboardDo)
        {
            this.scoreboardDo = scoreboardDo;
            this.scoreboardTypes = ScoreboardTypes.NONE;
            this.text = "";
        }

        public Scoreboard(ScoreboardTypes scoreboardDo, ScoreboardTypes scoreboardTypes, string text)
        {
            this.scoreboardDo = scoreboardDo;
            this.scoreboardTypes = scoreboardTypes;
            this.text = text;
        }

        public ScoreboardTypes getScoreboardDo() { return scoreboardDo; }
        public ScoreboardTypes getScoreboardTypes() { return scoreboardTypes; }
        public string getText() { return text; }
    }
}

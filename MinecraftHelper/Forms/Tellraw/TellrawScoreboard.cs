using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MinecraftHelper.Forms.Tellraw
{
    class TellrawScoreboard
    {
        private TellrawScoreboardType tellrawScoreboardType { get; set; }
        private string text { get; set; }

        public TellrawScoreboard(TellrawScoreboardType tellrawScoreboardType, string text)
        {
            this.tellrawScoreboardType = tellrawScoreboardType;
            this.text = text;
        }

        public TellrawScoreboardType getTellrawScoreboardType() { return tellrawScoreboardType; }
        public string getText() { return text; }
    }
}

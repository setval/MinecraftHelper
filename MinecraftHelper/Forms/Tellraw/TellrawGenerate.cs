using MinecraftHelper.Forms.Tellraw;
using System.Collections.Generic;

namespace MinecraftHelper.Forms
{
    class TellrawGenerate : Generate
    {
        private List<string> texts;
        private List<string> code;
        private List<string> colors;
        private List<List<string>> formats;
        private List<IScoreboard> scoreboards;

        private string command;
        private string player;

        private void Generate()
        {
            int score = 0;
            foreach (string s in texts)
            {
                string d_string = "";
                if (colors[score] == "" && formats[score].Count == 0 && scoreboards[score].Scoreboard_Press.getScoreboardDo() == ScoreboardTypes.NONE && scoreboards[score].Scoreboard_Guidance.getScoreboardDo() == ScoreboardTypes.NONE)
                    code.Add("{\"text\":\"" + s + "\"}");
                else
                {
                    if (colors[score] != "") d_string = ",\"color\":\"" + colors[score] + "\"";
                    if (formats[score].Count != 0)
                    {
                        foreach (string str in formats[score])
                            d_string += ",\"" + str + "\":true";
                    }
                    if (scoreboards.Count != 0)
                    {
                        if (scoreboards[score].Scoreboard_Press.getScoreboardDo() == ScoreboardTypes.PRESS)
                        {
                            string dd_string = "";
                            switch (scoreboards[score].Scoreboard_Press.getScoreboardTypes())
                            {
                                case ScoreboardTypes.DO_COMMAND: dd_string = "run_command"; break;
                                case ScoreboardTypes.INVITE_COMMAND: dd_string = "suggest_command"; break;
                                case ScoreboardTypes.OPEN_URL: dd_string = "open_url"; break;
                                case ScoreboardTypes.CHANGE_PAGE: dd_string = "change_page"; break;
                            }
                            d_string += ",\"clickEvent\":{\"action\":\"" + dd_string + "\",\"value\":\"" + scoreboards[score].Scoreboard_Press.getText() + "\"}";

                        }
                        if (scoreboards[score].Scoreboard_Guidance.getScoreboardDo() == ScoreboardTypes.GUIDANCE)
                        {
                            string dd_string = "";
                            switch (scoreboards[score].Scoreboard_Guidance.getScoreboardTypes())
                            {
                                case ScoreboardTypes.SHOW_TEXT: dd_string = "show_text"; break;
                                case ScoreboardTypes.SHOW_ITEM: dd_string = "show_item"; break;
                                case ScoreboardTypes.SHOW_ENTITY: dd_string = "show_entity"; break;
                                case ScoreboardTypes.SHOW_ATTAINMENT: dd_string = "show_achievement"; break;
                            }
                            d_string += ",\"hoverEvent\":{\"action\":\"" + dd_string + "\",\"value\":\"" + scoreboards[score].Scoreboard_Guidance.getText() + "\"}";
                        }
                    }
                    code.Add("{\"text\":\"" + s + "\"" + d_string + "}");
                }
                score++;
            }
            command = "/tellraw " + player + " [\"\"";
            foreach (string s in code)
            {
                command += "," + s;
            }
            command += "]";
        }

        public TellrawGenerate(List<TellrawObject> obj)
        {
            texts = new List<string>();
            code = new List<string>();
            colors = new List<string>();
            formats = new List<List<string>>();
            scoreboards = new List<IScoreboard>();
            try
            {
                player = obj[0].getPlayer();
            }
            catch
            {
                player = "@p";
            }
            
            foreach (TellrawObject tellobj in obj)
            {
                texts.Add(tellobj.getText());
                colors.Add(tellobj.getColor());
                formats.Add(tellobj.getListFormats());
                scoreboards.Add(tellobj.getScoreboards());
            }
            
            Generate();
            ReturnCode();
        }

        public string ReturnCode()
        {
            return command;
        }

    }
}

using MinecraftHelper.Forms.Tellraw;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MinecraftHelper.Forms
{
    class TellrawGenerate : Generate
    {
        private List<string> texts;
        private List<string> code;
        private List<string> colors;
        private List<List<string>> formats;
        private List<List<Scoreboard>> scoreboards;

        private string command;

        private void Generate()
        {
            int score = 0;
            foreach (string s in texts)
            {
                string d_string = "";
                if (colors[score] == "" && formats[score].Count == 0 && scoreboards[score].Count == 0)
                    code.Add("{\"text\":\"" + s + "\"}");
                else
                {
                    if (colors[score] != "") d_string = ",\"color\":\"" + colors[score] + "\"";
                    if (formats[score].Count != 0)
                    {
                        foreach (string str in formats[score])
                            d_string += ",\"" + str + "\":true";
                    }
                    if (scoreboards[score].Count != 0)
                    {
                        foreach (Scoreboard listScoreboards in scoreboards[score])
                        {
                            if (listScoreboards.getScoreboardDo() != ScoreboardTypes.PRESS) continue;
                            string dd_string = "";
                            switch (listScoreboards.getScoreboardTypes())
                            {
                                case ScoreboardTypes.DO_COMMAND: dd_string = "run_command"; break;
                                case ScoreboardTypes.INVITE_COMMAND: dd_string = "suggest_command"; break;
                                case ScoreboardTypes.OPEN_URL: dd_string = "open_url"; break;
                                case ScoreboardTypes.CHANGE_PAGE: dd_string = "change_page"; break;
                            }
                            d_string += ",\"clickEvent\":{\"action\":\"" + dd_string + "\",\"value\":\"" + listScoreboards.getText() + "\"}";
                        }
                        foreach (Scoreboard listScoreboards in scoreboards[score])
                        {
                            if (listScoreboards.getScoreboardDo() != ScoreboardTypes.GUIDANCE) continue;
                            string dd_string = "";
                            switch (listScoreboards.getScoreboardTypes())
                            {
                                case ScoreboardTypes.SHOW_TEXT: dd_string = "show_text"; break;
                                case ScoreboardTypes.SHOW_ITEM: dd_string = "show_item"; break;
                                case ScoreboardTypes.SHOW_ENTITY: dd_string = "show_entity"; break;
                                case ScoreboardTypes.SHOW_ATTAINMENT: dd_string = "show_achievement"; break;
                            }
                            d_string += ",\"hoverEvent\":{\"action\":\"" + dd_string + "\",\"value\":\"" + listScoreboards.getText() + "\"}";
                        }
                    }


                    code.Add("{\"text\":\"" + s + "\"" + d_string + "}");
                }          
                score++;
            }
            command = "/tellraw @p [\"\"";
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
            scoreboards = new List<List<Scoreboard>>();
            
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

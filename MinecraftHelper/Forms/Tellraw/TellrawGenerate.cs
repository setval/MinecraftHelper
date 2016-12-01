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

        private string command;

        private void generate()
        {
            int score = 0;
            foreach (string s in texts)
            {
                string d_string = "";
                if (colors[score] == "" && formats[score].Count == 0)
                    code.Add("{\"text\":\"" + s + "\"}");
                else
                {
                    if (colors[score] != "") d_string = ",\"color\":\"" + colors[score] + "\"";
                    if (formats[score].Count != 0)
                    {                        
                        foreach (string str in formats[score])
                                d_string += ",\"" + str + "\":true";
                    }
                    code.Add("{\"text\":\"" + s + "\""+d_string+"}");
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
            
            foreach (TellrawObject tellobj in obj)
            {
                texts.Add(tellobj.getText());
                colors.Add(tellobj.getColor());
                formats.Add(tellobj.getListFormats());
            }
            
            generate();
            returnCode();
        }

        public string returnCode()
        {
            return command;
        }

    }
}

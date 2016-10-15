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

        private string command;

        private void generate()
        {
            foreach (string s in texts)
            {
                code.Add("{\"text\":\""+s+"\"}");
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
            foreach (TellrawObject tellobj in obj)
                texts.Add(tellobj.getText());
            
            generate();
            returnCode();
        }

        public string returnCode()
        {
            return command;
        }

    }
}

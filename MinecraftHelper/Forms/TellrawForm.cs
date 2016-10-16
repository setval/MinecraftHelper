using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MinecraftHelper.Forms
{
    public partial class TellrawForm : Form
    {
        private List<Control> controls;
        private List<TellrawObject> objects;

        public TellrawForm()
        {
            InitializeComponent();
            objects = new List<TellrawObject>();
            this.controls = new List<Control>();
            controls.Add(this.constructorGroupBox);            
        }

        public List<Control> returnControls()
        {
            return controls;
        }

        public string TellrawGen()
        {
            return new TellrawGenerate(objects).returnCode();
        }

        private void addTellraw_Click(object sender, EventArgs e)
        {
            List<string> word_orign = new List<string>();
            List<string> word = new List<string>();
            word.Add("");
            word.Add("red");
            word.Add("yellow");
            word.Add("green");
            word.Add("blue");
            word.Add("white");
            word.Add("black");
            int index = colorsTellraw.Items.IndexOf(colorsTellraw.Text);
            if (index == -1) index = 0;
            objects.Add(new TellrawObject(this.textTellraw.Text, word[index]));
        }
    }
}

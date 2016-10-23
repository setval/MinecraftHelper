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
        private List<TellrawElementsForm> tellrawElementsForm;

        private const int width = 35;

        public TellrawForm()
        {
            InitializeComponent();
            objects = new List<TellrawObject>();
            tellrawElementsForm = new List<TellrawElementsForm>();
            this.controls = new List<Control>();
            controls.Add(this.constructorGroupBox);
            controls.Add(this.elementsTellraw);
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
            TellrawObject TellrawObject = new TellrawObject(this.textTellraw.Text, word[index]);
            objects.Add(TellrawObject);
            this.textTellraw.Text = "";
            this.colorsTellraw.Text = "Цвет";

            tellrawElementsForm.Add(new TellrawElementsForm());

            UpdateElementsPanel();
        }

        private void UpdateElementsPanel()
        {
            elementsTellraw.Controls.Clear();
            int i = 0;
            foreach(TellrawElementsForm tef in tellrawElementsForm)
            {
                tef.setName(tef.returnPanelElement(), tef.getName(tef.returnPanelElement()) + Convert.ToString(i));
                tef.setName(tef.returnShowElement(), tef.getName(tef.returnShowElement()) + Convert.ToString(i));
                tef.setName(tef.returnDeleteElement(), tef.getName(tef.returnDeleteElement()) + Convert.ToString(i));
                Point p = tef.getPos(tef.returnPanelElement());
                tef.setPos(tef.returnPanelElement(), new Point(p.X, p.Y+i));
                elementsTellraw.Controls.Add(tef.returnShowElement());
                elementsTellraw.Controls.Add(tef.returnDeleteElement());
                elementsTellraw.Controls.Add(tef.returnPanelElement());
                MessageBox.Show(String.Format("{0} {1} {2}\n", tef.getName(tef.returnPanelElement()), tef.getName(tef.returnShowElement()), tef.getName(tef.returnDeleteElement())));
                i++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = "";
            foreach(TellrawElementsForm tef in tellrawElementsForm)
            {
                s = String.Format("{0} {1} {2}\n", tef.getName(tef.returnPanelElement()), tef.getName(tef.returnShowElement()), tef.getName(tef.returnDeleteElement()));
            }
            MessageBox.Show(s);
        }
    }
}

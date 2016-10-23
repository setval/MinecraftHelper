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
        private List<List<Control>> tellrawElementsForm;

        private const int width = 35;

        public TellrawForm()
        {
            InitializeComponent();
            objects = new List<TellrawObject>();
            tellrawElementsForm = new List<List<Control>>();
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
            

            tellrawElementsForm.Add(new TellrawElementsForm().returnControls());

            UpdateElementsPanel();
        }

        private void UpdateElementsPanel()
        {
            elementsTellraw.Controls.Clear();
            int i = 0;
            foreach(List<Control> list in tellrawElementsForm)
            {
                foreach (Control tef in list)
                {
                    int score = 0;
                    switch(tef.Name)
                    {
                        case "deleteElement_": tef.Name = "deleteElement_" + i; score = 14;  break;
                        case "showElement_": tef.Name = "showElement_" + i; score = 12; break;
                        case "panelElement_": tef.Name = "panelElement_" + i; score = 13; break;
                        default: break;
                    }
                    //tef.Name = tef.Name + Convert.ToString(i);
                    if (score > 0)
                    {
                        string buffer = "";
                        for (int q = score; q < tef.Name.Length; q++)
                            buffer += tef.Name[q];
                        tef.Location = new Point(tef.Location.X, Convert.ToInt32(buffer));
                    }
                    elementsTellraw.Controls.Add(tef);
                    //MessageBox.Show(String.Format("{0} {1} {2}\n", tef.getName(tef.returnPanelElement()), tef.getName(tef.returnShowElement()), tef.getName(tef.returnDeleteElement())));
                }
                i += width;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = "";
            foreach (List<Control> list in tellrawElementsForm)
                foreach (Control control in list)
                    MessageBox.Show(control.Name);
        }
    }
}
